using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YelpHelp
{
    class clsRestClient
    {
        const string BasePath = "https://api.yelp.com/v3";

        static Dictionary<string, Category> CategoriesMap = new Dictionary<string, Category>();

        //Get All categories from Yelp and convert to class objects
        public static Dictionary<string, string> GetCategories()
        {
            const string CategoriesPath = BasePath + "/categories";
            RestClient objRestClient = new RestClient(CategoriesPath);
            RestRequest objRequest = new RestRequest(Method.GET);
            objRequest.RequestFormat = DataFormat.Json;
            objRequest.AddHeader("Content-Type", "application/json");
            objRequest.AddHeader("Authorization", "Bearer 1wH24EiSwVfHufOi0VQtR1us8xFzurDL-ZHoQXbSaYqhv68ANOAKvumo3G1h-q16WsiYUo7XSYj0gTeDuRpHWxZ2KVMhC1ndEUtKPv50-b-xFKUtYmmhpxXX0FpDXnYx");

            IRestResponse objResponse = objRestClient.Execute(objRequest);
            string responseString = objResponse.Content.ToString().Trim();

            Dictionary<string, string> CategoriesList = null;

            //If API throws error message
            if (objResponse.StatusCode.Equals(HttpStatusCode.OK) == false)
            {
                string msgBox_Heading = "Connectivity Error";
                string msgBox_Message = "Unable to connect the TestRail. Please check the url,userid and password \n " +
                                        "Also, Please check the TestRail is up and Running \n" +
                                        "Error Message: " + responseString;
                MessageBox.Show(msgBox_Message, msgBox_Heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return CategoriesList;
            }

            //Debug.WriteLine(responseString);
            CategoriesList = new Dictionary<string, string>();

            clsCategories ObjCategories = JsonConvert.DeserializeObject<clsCategories>(responseString);
            foreach (Category objCategory in ObjCategories.CategoriesList)
            {
                CategoriesMap.Add(objCategory.Alias, objCategory);

                if (objCategory.ParentCategories.Length == 0)
                    CategoriesList.Add(objCategory.Alias, objCategory.Title);
            }

            return CategoriesList;

            /*
            //Convert String to JSON
            JObject JSON_Object = JObject.Parse(responseString);

            //Get Categories Array
            JArray JArray_Categories = (JArray)JSON_Object["categories"];

            //Convert String to JSON
            foreach (JObject JObj_Category in JArray_Categories)
            {
                bool restaurants = false;
                JArray JArray_Parents = (JArray)JObj_Category["parent_aliases"];
                foreach (JValue parent in JArray_Parents)
                {
                    if (string.Equals(parent.ToString(), "restaurants"))
                        restaurants = true;
                }

                if (restaurants == true)
                { 
                JProperty alias = JObj_Category.Property("alias");
                    JProperty title = JObj_Category.Property("title");
                    CategoriesList.Add(alias.Value.ToString(), title.Value.ToString());
                    //Debug.WriteLine("name: " + projectName.Value);
                }
            }

            return CategoriesList;
            */
        }

        //Get only the level one herirachy
        public static Dictionary<string, string> GetChildCategories(string ParentCategory)
        {
            Dictionary<string, string> ChildCategoriesList = new Dictionary<string, string>();

            //Loop through Catergories List
            foreach (KeyValuePair<string, Category> KVP in CategoriesMap)
            {
                Category objCategory = KVP.Value;

                if (objCategory.ParentCategories.Length == 0) continue;

                foreach (string strCategory in objCategory.ParentCategories)
                {
                    if (string.Compare(strCategory, ParentCategory)==0)
                    {
                        ChildCategoriesList.Add(objCategory.Alias, objCategory.Title);
                        break;
                    }
                }
            }

            return ChildCategoriesList;
        }

        //Get all level of herirarchy
        public static Dictionary<string, string> GetChildCategories_Hierarchy(string ParentCategory)
        {
            Dictionary<string, string> ChildCategoriesList = new Dictionary<string, string>();
            Category objParentCategory = CategoriesMap[ParentCategory];

            //Loop through Catergories List
            foreach (KeyValuePair<string, Category> KVP in CategoriesMap)
            {
                Category objCategory = KVP.Value;
                string CategoryTitle = BelongsToCateogry(ParentCategory, objCategory);

                if(string.IsNullOrEmpty(CategoryTitle) == false)
                {
                    //If parent category matches the category that is passed return the Parent category Title then 
                    // only add parent category title
                    if (string.Compare(CategoryTitle, objParentCategory.Title) == 0)
                        ChildCategoriesList.Add(objCategory.Alias, objCategory.Title);
                    else
                        //Add child category + Parent Category
                        ChildCategoriesList.Add(objCategory.Alias, CategoryTitle + "-" + objCategory.Title);
                }
            }

            // Sort Dictionary by value using linq
            var items = from pair in ChildCategoriesList
                        orderby pair.Value ascending
                        select pair;
            Dictionary<string, string> SortedList = new Dictionary<string, string>();
            
            //Adding Parent Category as first Category
            SortedList.Add(objParentCategory.Alias, objParentCategory.Title + "-All");
            
            //Adding sorted child category
            foreach (KeyValuePair<string, string> pair in items)
            {
                SortedList.Add(pair.Key,pair.Value);
            }

            return SortedList;
        }

        //Recursive function to get the category Heirarchy
        static string BelongsToCateogry(string ParentCategory, Category objCategory)
        {
            //Back to called function if the parent catergory is count is 0
            if (objCategory.ParentCategories.Length == 0)
                return string.Empty;

            string ResultString = string.Empty;

            //Loop through each parent category
            foreach (string strCategory in objCategory.ParentCategories)
            {
                //If parent category matches the category that is passed return the Parent category Title
                if (string.Compare(ParentCategory, strCategory) == 0)
                {
                    Category objParentCategory = CategoriesMap[strCategory];
                    ResultString = objParentCategory.Title;
                    break;
                }  
                else
                {
                    //Get Parent Category Object
                    Category objParentCategory = CategoriesMap[ParentCategory];

                    //Get Child Category Object
                    Category objChildCategory = CategoriesMap[strCategory];

                    //Call recursive function to get heirarchy
                    string Output = BelongsToCateogry(ParentCategory, objChildCategory);

                    //If value is not empty
                    if(string.IsNullOrEmpty(Output) == false)
                    {
                        // When output and parent category title are same return only parent title
                        if (string.Compare(Output, objParentCategory.Title) == 0)
                            ResultString = objChildCategory.Title;
                        else
                            //Return output + Child category title
                            ResultString = Output + "-" + objChildCategory.Title;

                        break;
                    }
                }
            }

            return ResultString;
        }

        // Search Yelp based on parameter that is passed and convert to class object
        public static List<Business> YelpSearch(Dictionary<string,string> Parameters)
        {
            const string BusinessSearchPath = BasePath + "/businesses/search";
            RestClient objRestClient = new RestClient(BusinessSearchPath);
            RestRequest objRequest = new RestRequest(Method.GET);
            objRequest.RequestFormat = DataFormat.Json;
            objRequest.AddHeader("Content-Type", "application/json");
            objRequest.AddHeader("Authorization", "Bearer 1wH24EiSwVfHufOi0VQtR1us8xFzurDL-ZHoQXbSaYqhv68ANOAKvumo3G1h-q16WsiYUo7XSYj0gTeDuRpHWxZ2KVMhC1ndEUtKPv50-b-xFKUtYmmhpxXX0FpDXnYx");

            //Loop through each parameter
            foreach (KeyValuePair<string, string> KVP in Parameters)
                objRequest.AddParameter(KVP.Key.ToString(),KVP.Value.ToString());

            IRestResponse objResponse = objRestClient.Execute(objRequest);
            string responseString = objResponse.Content.ToString().Trim();

            clsBusinessResults ObjBusinessResults = JsonConvert.DeserializeObject<clsBusinessResults>(responseString);

            return ObjBusinessResults.BusinessList;
        }

        // Search Yelp based on parameter that is passed and convert to class object
        public static List<Business> YelpFullSearch(Dictionary<string, string> Parameters)
        {
            bool StopSearch = false;
            int offSetCounter = 0;
            //int PageOffset = int.Parse(Parameters["limit"]);
            const int PageOffset = 50;
            const string BusinessSearchPath = BasePath + "/businesses/search";
            List<Business> BusinessList = new List<Business>();

            //Setting offset counter to restrict the result. Prevent Overkill of rest call
            while (StopSearch == false && offSetCounter < 10)
            {
                RestClient objRestClient = new RestClient(BusinessSearchPath);
                RestRequest objRequest = new RestRequest(Method.GET);
                objRequest.RequestFormat = DataFormat.Json;
                objRequest.AddHeader("Content-Type", "application/json");
                objRequest.AddHeader("Authorization", "Bearer 1wH24EiSwVfHufOi0VQtR1us8xFzurDL-ZHoQXbSaYqhv68ANOAKvumo3G1h-q16WsiYUo7XSYj0gTeDuRpHWxZ2KVMhC1ndEUtKPv50-b-xFKUtYmmhpxXX0FpDXnYx");

                //Loop through each parameter
                foreach (KeyValuePair<string, string> KVP in Parameters)
                    objRequest.AddParameter(KVP.Key.ToString(), KVP.Value.ToString());

                objRequest.AddParameter("offset", (offSetCounter * PageOffset).ToString());
                offSetCounter++;

                IRestResponse objResponse = objRestClient.Execute(objRequest);

                string responseString = objResponse.Content.ToString().Trim();

                clsBusinessResults ObjBusinessResults = JsonConvert.DeserializeObject<clsBusinessResults>(responseString);

                if (ObjBusinessResults.BusinessList.Count == 0)
                {
                    StopSearch = true;
                }
                else
                {
                    foreach (Business objBusiness in ObjBusinessResults.BusinessList)
                    {
                        BusinessList.Add(objBusiness);
                    }
                }
            }

            return BusinessList;
        }

        //Get External IP of the current system
        public static clsRequestorIP GetExternalIPv4Address()
        {
            //Create account in the ipstack
            const string CategoriesPath = "http://api.ipstack.com/check";
            RestClient objRestClient = new RestClient(CategoriesPath);
            RestRequest objRequest = new RestRequest(Method.GET);
            objRequest.AddQueryParameter("access_key", "d08595cb93d6e74518ea8bfb36a48101");

            IRestResponse objResponse = objRestClient.Execute(objRequest);
            string responseString = objResponse.Content.ToString().Trim();
            //Debug.WriteLine(responseString);
            clsRequestorIP ObjRequestorIP = JsonConvert.DeserializeObject<clsRequestorIP>(responseString);

            return ObjRequestorIP;
        }
    }
}
