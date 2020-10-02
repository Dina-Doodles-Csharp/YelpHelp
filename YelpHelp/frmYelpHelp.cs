using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace YelpHelp
{
    public partial class frmYelpHelp : Form
    {
        public frmYelpHelp()
        {
            InitializeComponent();
        }

        Dictionary<string, string> CategoriesList = null;
        Dictionary<string, string> ChildCategoriesList = null;
        Dictionary<string, string> SortBy = new Dictionary<string, string>();
        Dictionary<string, string> Distance = new Dictionary<string, string>();
        Dictionary<string, string> Attributes = new Dictionary<string, string>();
        List<Business> BusinessList = null;

        private void frmYelpHelp_Load(object sender, EventArgs e)
        {
            Load_Categories();
            Load_SortBy();
            Load_Distance();
            LoadGeo();

            chk_Category.Checked = true;

            chk_Term.Checked = false;
            txt_Term.Enabled = false;

            radio_Geo.Checked = true;
            radio_None.Checked = true;

            chk_CompactSearch.Checked = true;
        }

        private void cmb_CategoryParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ChildCategories();
        }

        private void radio_Term_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                txt_Term.Enabled = true;
                cmb_CategoryParent.Enabled = false;
                cmb_CategoriesChild.Enabled = false;
            }
        }

        private void radio_Category_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                txt_Term.Enabled = false;
                cmb_CategoryParent.Enabled = true;
                cmb_CategoriesChild.Enabled = true;
            }
        }

        private void radio_Geo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                txt_Geo.Enabled = true;
                txt_Gps_Lat.Enabled = false;
                txt_Gps_Long.Enabled = false;
            }
        }

        private void radio_Gps_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                txt_Geo.Enabled = false;
                txt_Gps_Lat.Enabled = true;
                txt_Gps_Long.Enabled = true;
            }
        }

        private void radio_OpenAt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                dtp_OpenAtDate.Enabled = true;
                dtp_OpenAtTime.Enabled = true;
            }
        }

        private void radio_None_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                dtp_OpenAtDate.Enabled = false;
                dtp_OpenAtTime.Enabled = false;
            }
        }

        private void radio_OpenNow_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                dtp_OpenAtDate.Enabled = false;
                dtp_OpenAtTime.Enabled = false;
            }
        }

        private void chk_Term_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = sender as CheckBox;
            if (chkBox.Checked)
            {
                txt_Term.Enabled = true;
            }
            else
            {
                txt_Term.Enabled = false;
            }
        }

        private void chk_Category_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkBox = sender as CheckBox;
            if (chkBox.Checked)
            {
                cmb_CategoryParent.Enabled = true;
                cmb_CategoriesChild.Enabled = true;
            }
            else
            {
                cmb_CategoryParent.Enabled = false;
                cmb_CategoriesChild.Enabled = false;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SearchAndDisplay();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ExportData();
        }

        private void Load_Categories()
        {
            CategoriesList = clsRestClient.GetCategories();

            if (CategoriesList == null) return;

            //Loop through Parent Categories
            foreach (KeyValuePair<string, string> KVP in CategoriesList)
                cmb_CategoryParent.Items.Add(KVP.Value);

            if (cmb_CategoryParent.Items.Count > 0)
                cmb_CategoryParent.SelectedIndex = 0;
        }

        private void Load_ChildCategories()
        {
            if (cmb_CategoryParent.Items.Count <= 0) return;

            int CategoryIndex = cmb_CategoryParent.SelectedIndex;

            string SelectedIndexCategoryKey = CategoriesList.ElementAt(CategoryIndex).Key;
            ChildCategoriesList = clsRestClient.GetChildCategories_Hierarchy(SelectedIndexCategoryKey);

            cmb_CategoriesChild.Items.Clear();
            
            //Loop through Child Categories
            foreach (KeyValuePair<string, string> KVP in ChildCategoriesList)
            {
                cmb_CategoriesChild.Items.Add(KVP.Value);
                //Debug.WriteLine(KVP.Value);
            }

            if (cmb_CategoriesChild.Items.Count > 0)
                cmb_CategoriesChild.SelectedIndex = 0;
        }

        //Load Sort By field values
        private void Load_SortBy()
        {
            SortBy.Add("none", "None");
            SortBy.Add("best_match","Best Match");
            SortBy.Add("rating", "Rating");
            SortBy.Add("review_count", "Review Count");
            SortBy.Add("distance", "Distance");

            foreach (KeyValuePair<string, string> KVP in SortBy)
                cmb_SortBy.Items.Add(KVP.Value);

            if (cmb_SortBy.Items.Count > 0)
                cmb_SortBy.SelectedIndex = 0;
        }

        //Load Distance in Miles and map the meters as key
        private void Load_Distance()
        {
            string Key = string.Empty;
            string value = string.Empty;

            Distance.Add("default", "Default");
            for (int i=1; i<25; i++)
            {
                Key = (i * 1609).ToString();
                value = Convert.ToString(i) + " Mile";
                Distance.Add(Key, value);
            }

            foreach (KeyValuePair<string, string> KVP in Distance)
                cmb_Distance.Items.Add(KVP.Value);

            if (cmb_Distance.Items.Count > 4)
                cmb_Distance.SelectedIndex = 5;
            else if (cmb_Distance.Items.Count > 0)
                cmb_Distance.SelectedIndex = 0;
        }

        //Load Attributes. At present not used
        private void Load_Atrributes()
        {
            Attributes.Add("hot_and_new", "Hot and New");
            //Attributes.Add("request_a_quote", "Request a Quote");
            Attributes.Add("reservation", "Reservation");
            Attributes.Add("waitlist_reservation", "Yelp Waitlist");
            Attributes.Add("cashback", "Yelp CashBack");
            Attributes.Add("deals", "Yelp Deals");
            Attributes.Add("gender_neutral_restrooms", "Gender Neutral RestRoom");
            Attributes.Add("open_to_all", "Open To All");
            Attributes.Add("wheelchair_accessible", "Wheelchair Accessible");

            foreach (KeyValuePair<string, string> KVP in SortBy)
                cmb_SortBy.Items.Add(KVP.Value);

            if (cmb_SortBy.Items.Count > 0)
                cmb_SortBy.SelectedIndex = 0;
        }

        //Get City and Lattitude & Longtitude of current IP address and populate to user
        private void LoadGeo()
        {
            clsRequestorIP ObjRequestorIP = clsRestClient.GetExternalIPv4Address();
            txt_Geo.Text = ObjRequestorIP.City;

            //Round the Lattitude to 6 decimal points
            double dblLattitude = double.Parse(ObjRequestorIP.Latitude);
            string strRoundLattitude = Math.Round(dblLattitude, 6, MidpointRounding.ToEven).ToString();
            //txt_Gps_Lat.Text = ObjRequestorIP.Latitude;
            txt_Gps_Lat.Text = strRoundLattitude;

            //Round the Longtitude to 6 decimal points
            double dblLongitude = double.Parse(ObjRequestorIP.Longitude);
            string strRoundLongitude = Math.Round(dblLongitude, 6, MidpointRounding.ToEven).ToString();
            //txt_Gps_Long.Text = ObjRequestorIP.Longitude;
            txt_Gps_Long.Text = strRoundLongitude;
        }

        private void SearchAndDisplay()
        {
            Dictionary<string, string> SearchParameters = new Dictionary<string, string>();

            //Add Search Term to Search Parameter
            if (chk_Term.Checked == true)
            {
                string SearchTerm = txt_Term.Text.Trim();
                SearchParameters.Add("term", SearchTerm);
            }

            //Add Search Category to Search Parameter
            if (chk_Category.Checked == true)
            {
                int CategoryIndex = cmb_CategoriesChild.SelectedIndex;
                string SearchCategory = ChildCategoriesList.ElementAt(CategoryIndex).Key;
                SearchParameters.Add("categories", SearchCategory);
            }

            //Add Geographical Location to search parameter
            if (radio_Geo.Checked == true)
            {
                string Location = txt_Geo.Text.Trim();
                if (string.IsNullOrEmpty(Location))
                {
                    string msgBox_Heading = "Invalid Geographical value";
                    string msgBox_Message = "Please enter valid Geographical value";
                    MessageBox.Show(msgBox_Message, msgBox_Heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SearchParameters.Add("location", Location);
            }

            //Add Lattitude and Longtitude Location to search parameter
            if (radio_Gps.Checked == true)
            {
                string latitude = txt_Gps_Lat.Text.Trim();
                string longitude = txt_Gps_Long.Text.Trim();

                if (string.IsNullOrEmpty(latitude) || string.IsNullOrEmpty(longitude))
                {
                    string msgBox_Heading = "Invalid Lattitude or Longtitude value";
                    string msgBox_Message = "Please enter valid Lattitude and Longtitude value";
                    MessageBox.Show(msgBox_Message, msgBox_Heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SearchParameters.Add("latitude", latitude);
                SearchParameters.Add("longitude", longitude);
            }

            //Add Price category to search parameter
            if (chk_Price1.Checked || chk_Price2.Checked || chk_Price3.Checked || chk_Price4.Checked)
            {
                string PriceValue = string.Empty;
                if (chk_Price1.Checked) PriceValue = PriceValue + 1 + ",";
                if (chk_Price2.Checked) PriceValue = PriceValue + 2 + ",";
                if (chk_Price3.Checked) PriceValue = PriceValue + 3 + ",";
                if (chk_Price4.Checked) PriceValue = PriceValue + 4 + ",";

                PriceValue = PriceValue.Remove(PriceValue.Length - 1, 1);
                SearchParameters.Add("price", PriceValue);
            }

            //Add Open Now to search parameter
            if (radio_OpenNow.Checked)
            {
                SearchParameters.Add("open_now", "true");
            }

            //Add Open At value to search parameter
            if (radio_OpenAt.Checked)
            {
                DateTime SelectedDate = dtp_OpenAtDate.Value.Date;
                TimeSpan SelectedTimeSpan = dtp_OpenAtTime.Value.TimeOfDay;
                SelectedDate = SelectedDate + SelectedTimeSpan;
                SelectedDate = SelectedDate.ToUniversalTime();
                //string strSelectedDate = SelectedDate.ToString();
                //Debug.WriteLine(DateTimeToUnixTimeStamp(SelectedDate));
                string openAtValue = DateTimeToUnixTimeStamp(SelectedDate).ToString();
                SearchParameters.Add("open_at", openAtValue);
            }

            //Add Sort by value to search parameter
            string sortByValue = cmb_SortBy.Text;
            if (string.Compare(sortByValue, "None") != 0)
            {
                int sortKeyIndex = cmb_SortBy.SelectedIndex;
                string sortKeyValue = SortBy.ElementAt(sortKeyIndex).Key;
                SearchParameters.Add("sort_by", sortKeyValue);
            }

            //Add Distance to search parameter
            string distanceValue = cmb_Distance.Text;
            if (string.Compare(sortByValue, "Default") != 0)
            {
                int distanceIndex = cmb_Distance.SelectedIndex;
                string distanceKeyValue = Distance.ElementAt(distanceIndex).Key;
                SearchParameters.Add("radius", distanceKeyValue);
            }

            //Add Hot and new value to search parameter
            if (chkbox_HotAndNew.Checked)
            {
                SearchParameters.Add("attributes", "hot_and_new");
            }

            //Add Limit value to search parameter
            SearchParameters.Add("limit", "50");


            //Clear the list view
            listView_Result.Items.Clear();
            tssl_RecordCount.Text = "Record Count = 0";

            Disable_Controls();
            tssl_Status.Text = "Please wait while data being fetched from Yelp...";
            Application.DoEvents();

            // Get Search Results
            //List<Business> BusinessList = clsRestClient.YelpSearch(SearchParameters);
            if (chk_CompactSearch.Checked == true)
            {
                BusinessList = clsRestClient.YelpSearch(SearchParameters);
            }
            else
            {
                BusinessList = clsRestClient.YelpFullSearch(SearchParameters);
            }

            tssl_RecordCount.Text = "Record Count = " + BusinessList.Count;

            //Show the records to the user
            string[] strItem = new string[8];

            foreach (Business business in BusinessList)
            {
                //Adding Values to ListView
                strItem[0] = business.Name;
                strItem[1] = business.Review_Count;
                strItem[2] = business.Price;
                strItem[3] = business.Rating;
                strItem[4] = business.Display_Phone;

                string strCategory = string.Empty;
                foreach (Category category in business.Categories)
                {
                    if (string.IsNullOrEmpty(strCategory))
                        strCategory = category.Title;
                    else
                        strCategory = strCategory + "," + category.Title;
                }
                strItem[5] = strCategory;

                double distanceInMeters = double.Parse(business.Distance) / 1609;
                strItem[6] = Math.Round(distanceInMeters, 1, MidpointRounding.ToEven).ToString();

                strItem[7] = string.Join(",", business.Location.Display_address);

                ListViewItem Item = new ListViewItem(strItem);
                listView_Result.Items.Add(Item);
            }

            tssl_Status.Text = "Ready...";
            Enable_Controls();
        }

        //Convert Date Time to Unix Time Stamp
        public static long DateTimeToUnixTimeStamp(DateTime datetime)
        {
            //SelectedDate = SelectedDate.ToUniversalTime();
            DateTime offSetDateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            long unixTimeStamp = (long) (datetime - offSetDateTime).TotalSeconds;
            return unixTimeStamp;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            //dtDateTime = dtDateTime.ToLocalTime();
            return dtDateTime;
        }

        //Export the value to the system
        private void ExportData()
        {
            if (BusinessList == null || (BusinessList.Count == 0))
            {
                string msgBox_Heading = "No Records to export";
                string msgBox_Message = "There are no records to export";
                MessageBox.Show(msgBox_Message, msgBox_Heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string OutPutFileName = GetExportFileName();

            if (string.IsNullOrEmpty(OutPutFileName) == true)
            {
                string msgBox_Heading = "No FileName Selected";
                string msgBox_Message = "Please select FileName to be export";
                MessageBox.Show(msgBox_Message, msgBox_Heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Disable_Controls();
            tssl_Status.Text = "Please wait while data being export...";
            Application.DoEvents();

            StringBuilder Records = new StringBuilder();
            Records.AppendLine("Name,Review Count,Price,Rating,Phone Number,Categories,Distance(Mi),Address");

            //String array for construct record
            string[] strItem = new string[8];

            foreach (Business business in BusinessList)
            {
                //Populate value to string array
                strItem[0] = business.Name;
                strItem[1] = business.Review_Count;
                strItem[2] = business.Price;
                strItem[3] = business.Rating;
                strItem[4] = business.Display_Phone;

                string strCategory = string.Empty;
                foreach (Category category in business.Categories)
                {
                    if (string.IsNullOrEmpty(strCategory))
                        strCategory = category.Title;
                    else
                        strCategory = strCategory + "," + category.Title;
                }
                strItem[5] = strCategory;

                double distanceInMeters = double.Parse(business.Distance) / 1609;
                strItem[6] = Math.Round(distanceInMeters, 1, MidpointRounding.ToEven).ToString();

                strItem[7] = string.Join(",", business.Location.Display_address);

                string JoinedString = "\"" + strItem[0] + "\"" + "," +
                                      strItem[1] + "," +
                                      strItem[2] + "," +
                                      strItem[3] + "," +
                                      strItem[4] + "," +
                                      "\"" + strItem[5] + "\"" + "," +
                                      strItem[6] + "," +
                                      "\"" + strItem[7] + "\"" + ",";

                Records.AppendLine(JoinedString);
            }

            WriteToFile(OutPutFileName, Records);

            tssl_Status.Text = "Ready...";
            Enable_Controls();
        }

        //Get Filename from user
        private static string GetExportFileName()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            saveFileDialog.Title = "Save a CSV File";
            saveFileDialog.ShowDialog();

            return saveFileDialog.FileName.Trim();
        }

        //Write String builder content to Filer
        private static void WriteToFile(string stringFileName, StringBuilder Records)
        {
            //stringFileName = @"C:\Users\dinakaran.durai\Desktop\OutText.csv";
            using (StreamWriter streamWriter = File.CreateText(stringFileName))
            {
                streamWriter.WriteLine(Records.ToString());
            }
        }

        //Enable All UI Controls in current Form
        private void Enable_Controls()
        {
            chk_Term.Enabled = true;
            if(chk_Term.Checked == true)
                txt_Term.Enabled = true;

            chk_Category.Enabled = true;
            if (chk_Category.Checked == true)
            {
                cmb_CategoryParent.Enabled = true;
                cmb_CategoriesChild.Enabled = true;
            }


            radio_Geo.Enabled = true;
            if (radio_Geo.Checked == true)
                txt_Geo.Enabled = true;

            radio_Gps.Enabled = true;
            if (radio_Gps.Checked == true)
            {
                txt_Gps_Lat.Enabled = true;
                txt_Gps_Long.Enabled = true;
            }

            chk_Price1.Enabled = true;
            chk_Price2.Enabled = true;
            chk_Price3.Enabled = true;
            chk_Price4.Enabled = true;

            radio_None.Enabled = true;
            radio_OpenNow.Enabled = true;

            radio_OpenAt.Enabled = true;
            if (radio_OpenAt.Checked == true)
            {
                dtp_OpenAtDate.Enabled = true;
                dtp_OpenAtTime.Enabled = true;
            }

            cmb_SortBy.Enabled = true;
            cmb_Distance.Enabled = true;
            chkbox_HotAndNew.Enabled = true;
            chk_CompactSearch.Enabled = true;

            btn_Search.Enabled = true;
            btn_Export.Enabled = true;
        }

        //Disable All UI Controls in current Form
        private void Disable_Controls()
        {
            chk_Term.Enabled = false;
            txt_Term.Enabled = false;

            chk_Category.Enabled = false;
            cmb_CategoryParent.Enabled = false;
            cmb_CategoriesChild.Enabled = false;

            radio_Geo.Enabled = false;
            txt_Geo.Enabled = false;

            radio_Gps.Enabled = false;
            txt_Gps_Lat.Enabled = false;
            txt_Gps_Long.Enabled = false;

            chk_Price1.Enabled = false;
            chk_Price2.Enabled = false;
            chk_Price3.Enabled = false;
            chk_Price4.Enabled = false;

            radio_None.Enabled = false;
            radio_OpenNow.Enabled = false;

            radio_OpenAt.Enabled = false;
            dtp_OpenAtDate.Enabled = false;
            dtp_OpenAtTime.Enabled = false;

            cmb_SortBy.Enabled = false;
            cmb_Distance.Enabled = false;
            chkbox_HotAndNew.Enabled = false;
            chk_CompactSearch.Enabled = false;

            btn_Search.Enabled = false;
            btn_Export.Enabled = false;
        }

    }
}
