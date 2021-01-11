namespace YelpHelp
{
    partial class frmYelpHelp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYelpHelp));
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.chk_Category = new System.Windows.Forms.CheckBox();
            this.chk_Term = new System.Windows.Forms.CheckBox();
            this.cmb_CategoriesChild = new System.Windows.Forms.ComboBox();
            this.cmb_CategoryParent = new System.Windows.Forms.ComboBox();
            this.txt_Term = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Gps_Long = new System.Windows.Forms.TextBox();
            this.txt_Gps_Lat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Geo = new System.Windows.Forms.TextBox();
            this.radio_Gps = new System.Windows.Forms.RadioButton();
            this.radio_Geo = new System.Windows.Forms.RadioButton();
            this.toolTip_Main = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_Price4 = new System.Windows.Forms.CheckBox();
            this.chk_Price3 = new System.Windows.Forms.CheckBox();
            this.chk_Price2 = new System.Windows.Forms.CheckBox();
            this.chk_Price1 = new System.Windows.Forms.CheckBox();
            this.cmb_SortBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Distance = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_OpenAtTime = new System.Windows.Forms.DateTimePicker();
            this.dtp_OpenAtDate = new System.Windows.Forms.DateTimePicker();
            this.radio_OpenAt = new System.Windows.Forms.RadioButton();
            this.radio_OpenNow = new System.Windows.Forms.RadioButton();
            this.radio_None = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.listView_Result = new System.Windows.Forms.ListView();
            this.Hdr_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_ReviewCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Categories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Distance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hdr_Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.chkbox_HotAndNew = new System.Windows.Forms.CheckBox();
            this.chk_CompactSearch = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_RecordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBoxSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.chk_Category);
            this.grpBoxSearch.Controls.Add(this.chk_Term);
            this.grpBoxSearch.Controls.Add(this.cmb_CategoriesChild);
            this.grpBoxSearch.Controls.Add(this.cmb_CategoryParent);
            this.grpBoxSearch.Controls.Add(this.txt_Term);
            this.grpBoxSearch.Location = new System.Drawing.Point(13, 16);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(265, 169);
            this.grpBoxSearch.TabIndex = 0;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "SearchTo";
            // 
            // chk_Category
            // 
            this.chk_Category.AutoSize = true;
            this.chk_Category.Location = new System.Drawing.Point(7, 85);
            this.chk_Category.Name = "chk_Category";
            this.chk_Category.Size = new System.Drawing.Size(105, 17);
            this.chk_Category.TabIndex = 5;
            this.chk_Category.Text = "Search Category";
            this.chk_Category.UseVisualStyleBackColor = true;
            this.chk_Category.CheckedChanged += new System.EventHandler(this.chk_Category_CheckedChanged);
            // 
            // chk_Term
            // 
            this.chk_Term.AutoSize = true;
            this.chk_Term.Location = new System.Drawing.Point(5, 20);
            this.chk_Term.Name = "chk_Term";
            this.chk_Term.Size = new System.Drawing.Size(87, 17);
            this.chk_Term.TabIndex = 4;
            this.chk_Term.Text = "Search Term";
            this.chk_Term.UseVisualStyleBackColor = true;
            this.chk_Term.CheckedChanged += new System.EventHandler(this.chk_Term_CheckedChanged);
            // 
            // cmb_CategoriesChild
            // 
            this.cmb_CategoriesChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CategoriesChild.FormattingEnabled = true;
            this.cmb_CategoriesChild.Location = new System.Drawing.Point(7, 138);
            this.cmb_CategoriesChild.Name = "cmb_CategoriesChild";
            this.cmb_CategoriesChild.Size = new System.Drawing.Size(248, 24);
            this.cmb_CategoriesChild.TabIndex = 4;
            // 
            // cmb_CategoryParent
            // 
            this.cmb_CategoryParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_CategoryParent.FormattingEnabled = true;
            this.cmb_CategoryParent.Location = new System.Drawing.Point(7, 108);
            this.cmb_CategoryParent.Name = "cmb_CategoryParent";
            this.cmb_CategoryParent.Size = new System.Drawing.Size(248, 24);
            this.cmb_CategoryParent.TabIndex = 3;
            this.cmb_CategoryParent.SelectedIndexChanged += new System.EventHandler(this.cmb_CategoryParent_SelectedIndexChanged);
            // 
            // txt_Term
            // 
            this.txt_Term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Term.Location = new System.Drawing.Point(6, 42);
            this.txt_Term.Name = "txt_Term";
            this.txt_Term.Size = new System.Drawing.Size(248, 22);
            this.txt_Term.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Gps_Long);
            this.groupBox1.Controls.Add(this.txt_Gps_Lat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Geo);
            this.groupBox1.Controls.Add(this.radio_Gps);
            this.groupBox1.Controls.Add(this.radio_Geo);
            this.groupBox1.Location = new System.Drawing.Point(289, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // txt_Gps_Long
            // 
            this.txt_Gps_Long.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gps_Long.Location = new System.Drawing.Point(163, 126);
            this.txt_Gps_Long.Name = "txt_Gps_Long";
            this.txt_Gps_Long.Size = new System.Drawing.Size(82, 22);
            this.txt_Gps_Long.TabIndex = 8;
            // 
            // txt_Gps_Lat
            // 
            this.txt_Gps_Lat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Gps_Lat.Location = new System.Drawing.Point(13, 126);
            this.txt_Gps_Lat.Name = "txt_Gps_Lat";
            this.txt_Gps_Lat.Size = new System.Drawing.Size(82, 22);
            this.txt_Gps_Lat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longtitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lattitude";
            // 
            // txt_Geo
            // 
            this.txt_Geo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Geo.Location = new System.Drawing.Point(13, 42);
            this.txt_Geo.Name = "txt_Geo";
            this.txt_Geo.Size = new System.Drawing.Size(248, 22);
            this.txt_Geo.TabIndex = 2;
            // 
            // radio_Gps
            // 
            this.radio_Gps.AutoSize = true;
            this.radio_Gps.Location = new System.Drawing.Point(11, 84);
            this.radio_Gps.Name = "radio_Gps";
            this.radio_Gps.Size = new System.Drawing.Size(106, 17);
            this.radio_Gps.TabIndex = 1;
            this.radio_Gps.Text = "GPS Coordinates";
            this.radio_Gps.UseVisualStyleBackColor = true;
            this.radio_Gps.CheckedChanged += new System.EventHandler(this.radio_Gps_CheckedChanged);
            // 
            // radio_Geo
            // 
            this.radio_Geo.AutoSize = true;
            this.radio_Geo.Location = new System.Drawing.Point(12, 19);
            this.radio_Geo.Name = "radio_Geo";
            this.radio_Geo.Size = new System.Drawing.Size(113, 17);
            this.radio_Geo.TabIndex = 0;
            this.radio_Geo.Text = "Geographical Area";
            this.toolTip_Main.SetToolTip(this.radio_Geo, resources.GetString("radio_Geo.ToolTip"));
            this.radio_Geo.UseVisualStyleBackColor = true;
            this.radio_Geo.CheckedChanged += new System.EventHandler(this.radio_Geo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_Price4);
            this.groupBox2.Controls.Add(this.chk_Price3);
            this.groupBox2.Controls.Add(this.chk_Price2);
            this.groupBox2.Controls.Add(this.chk_Price1);
            this.groupBox2.Location = new System.Drawing.Point(572, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 64);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // chk_Price4
            // 
            this.chk_Price4.AutoSize = true;
            this.chk_Price4.Location = new System.Drawing.Point(148, 24);
            this.chk_Price4.Name = "chk_Price4";
            this.chk_Price4.Size = new System.Drawing.Size(50, 17);
            this.chk_Price4.TabIndex = 3;
            this.chk_Price4.Text = "$$$$";
            this.chk_Price4.UseVisualStyleBackColor = true;
            // 
            // chk_Price3
            // 
            this.chk_Price3.AutoSize = true;
            this.chk_Price3.Location = new System.Drawing.Point(98, 24);
            this.chk_Price3.Name = "chk_Price3";
            this.chk_Price3.Size = new System.Drawing.Size(44, 17);
            this.chk_Price3.TabIndex = 2;
            this.chk_Price3.Text = "$$$";
            this.chk_Price3.UseVisualStyleBackColor = true;
            // 
            // chk_Price2
            // 
            this.chk_Price2.AutoSize = true;
            this.chk_Price2.Location = new System.Drawing.Point(54, 24);
            this.chk_Price2.Name = "chk_Price2";
            this.chk_Price2.Size = new System.Drawing.Size(38, 17);
            this.chk_Price2.TabIndex = 1;
            this.chk_Price2.Text = "$$";
            this.chk_Price2.UseVisualStyleBackColor = true;
            // 
            // chk_Price1
            // 
            this.chk_Price1.AutoSize = true;
            this.chk_Price1.Location = new System.Drawing.Point(16, 24);
            this.chk_Price1.Name = "chk_Price1";
            this.chk_Price1.Size = new System.Drawing.Size(32, 17);
            this.chk_Price1.TabIndex = 0;
            this.chk_Price1.Text = "$";
            this.chk_Price1.UseVisualStyleBackColor = true;
            // 
            // cmb_SortBy
            // 
            this.cmb_SortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SortBy.FormattingEnabled = true;
            this.cmb_SortBy.Location = new System.Drawing.Point(13, 223);
            this.cmb_SortBy.Name = "cmb_SortBy";
            this.cmb_SortBy.Size = new System.Drawing.Size(217, 24);
            this.cmb_SortBy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "SortBy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Distance";
            // 
            // cmb_Distance
            // 
            this.cmb_Distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Distance.FormattingEnabled = true;
            this.cmb_Distance.Location = new System.Drawing.Point(289, 223);
            this.cmb_Distance.Name = "cmb_Distance";
            this.cmb_Distance.Size = new System.Drawing.Size(217, 24);
            this.cmb_Distance.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_OpenAtTime);
            this.groupBox3.Controls.Add(this.dtp_OpenAtDate);
            this.groupBox3.Controls.Add(this.radio_OpenAt);
            this.groupBox3.Controls.Add(this.radio_OpenNow);
            this.groupBox3.Controls.Add(this.radio_None);
            this.groupBox3.Location = new System.Drawing.Point(572, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 101);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SearchTo";
            // 
            // dtp_OpenAtTime
            // 
            this.dtp_OpenAtTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_OpenAtTime.CustomFormat = "hh:mm tt";
            this.dtp_OpenAtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_OpenAtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_OpenAtTime.Location = new System.Drawing.Point(127, 72);
            this.dtp_OpenAtTime.Name = "dtp_OpenAtTime";
            this.dtp_OpenAtTime.ShowUpDown = true;
            this.dtp_OpenAtTime.Size = new System.Drawing.Size(79, 22);
            this.dtp_OpenAtTime.TabIndex = 50;
            // 
            // dtp_OpenAtDate
            // 
            this.dtp_OpenAtDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_OpenAtDate.CustomFormat = "MM/dd/yyyy";
            this.dtp_OpenAtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_OpenAtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_OpenAtDate.Location = new System.Drawing.Point(11, 72);
            this.dtp_OpenAtDate.Name = "dtp_OpenAtDate";
            this.dtp_OpenAtDate.Size = new System.Drawing.Size(102, 22);
            this.dtp_OpenAtDate.TabIndex = 49;
            // 
            // radio_OpenAt
            // 
            this.radio_OpenAt.AutoSize = true;
            this.radio_OpenAt.Location = new System.Drawing.Point(11, 47);
            this.radio_OpenAt.Name = "radio_OpenAt";
            this.radio_OpenAt.Size = new System.Drawing.Size(196, 17);
            this.radio_OpenAt.TabIndex = 11;
            this.radio_OpenAt.Text = "Open At (Works only for today Date)";
            this.radio_OpenAt.UseVisualStyleBackColor = true;
            this.radio_OpenAt.CheckedChanged += new System.EventHandler(this.radio_OpenAt_CheckedChanged);
            // 
            // radio_OpenNow
            // 
            this.radio_OpenNow.AutoSize = true;
            this.radio_OpenNow.Location = new System.Drawing.Point(98, 19);
            this.radio_OpenNow.Name = "radio_OpenNow";
            this.radio_OpenNow.Size = new System.Drawing.Size(76, 17);
            this.radio_OpenNow.TabIndex = 10;
            this.radio_OpenNow.Text = "Open Now";
            this.radio_OpenNow.UseVisualStyleBackColor = true;
            this.radio_OpenNow.CheckedChanged += new System.EventHandler(this.radio_OpenNow_CheckedChanged);
            // 
            // radio_None
            // 
            this.radio_None.AutoSize = true;
            this.radio_None.Location = new System.Drawing.Point(11, 19);
            this.radio_None.Name = "radio_None";
            this.radio_None.Size = new System.Drawing.Size(51, 17);
            this.radio_None.TabIndex = 9;
            this.radio_None.Text = "None";
            this.radio_None.UseVisualStyleBackColor = true;
            this.radio_None.CheckedChanged += new System.EventHandler(this.radio_None_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Attributes";
            // 
            // listView_Result
            // 
            this.listView_Result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Hdr_Name,
            this.Hdr_ReviewCount,
            this.Hdr_Price,
            this.Hdr_Rating,
            this.Hdr_Phone,
            this.Hdr_Categories,
            this.Hdr_Distance,
            this.Hdr_Address});
            this.listView_Result.FullRowSelect = true;
            this.listView_Result.GridLines = true;
            this.listView_Result.HideSelection = false;
            this.listView_Result.Location = new System.Drawing.Point(13, 274);
            this.listView_Result.Name = "listView_Result";
            this.listView_Result.Size = new System.Drawing.Size(796, 224);
            this.listView_Result.TabIndex = 16;
            this.listView_Result.UseCompatibleStateImageBehavior = false;
            this.listView_Result.View = System.Windows.Forms.View.Details;
            // 
            // Hdr_Name
            // 
            this.Hdr_Name.Text = "Name";
            this.Hdr_Name.Width = 180;
            // 
            // Hdr_ReviewCount
            // 
            this.Hdr_ReviewCount.Text = "Review Count";
            this.Hdr_ReviewCount.Width = 80;
            // 
            // Hdr_Price
            // 
            this.Hdr_Price.Text = "Price";
            this.Hdr_Price.Width = 50;
            // 
            // Hdr_Rating
            // 
            this.Hdr_Rating.Text = "Rating";
            this.Hdr_Rating.Width = 50;
            // 
            // Hdr_Phone
            // 
            this.Hdr_Phone.Text = "Phone";
            this.Hdr_Phone.Width = 100;
            // 
            // Hdr_Categories
            // 
            this.Hdr_Categories.Text = "Categories";
            this.Hdr_Categories.Width = 175;
            // 
            // Hdr_Distance
            // 
            this.Hdr_Distance.Text = "Distance (mi)";
            this.Hdr_Distance.Width = 75;
            // 
            // Hdr_Address
            // 
            this.Hdr_Address.Text = "Address";
            this.Hdr_Address.Width = 175;
            // 
            // btn_Export
            // 
            this.btn_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Export.Location = new System.Drawing.Point(529, 512);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(121, 31);
            this.btn_Export.TabIndex = 17;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(157, 512);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(121, 31);
            this.btn_Search.TabIndex = 18;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // chkbox_HotAndNew
            // 
            this.chkbox_HotAndNew.AutoSize = true;
            this.chkbox_HotAndNew.Location = new System.Drawing.Point(561, 227);
            this.chkbox_HotAndNew.Name = "chkbox_HotAndNew";
            this.chkbox_HotAndNew.Size = new System.Drawing.Size(89, 17);
            this.chkbox_HotAndNew.TabIndex = 19;
            this.chkbox_HotAndNew.Text = "Hot and New";
            this.chkbox_HotAndNew.UseVisualStyleBackColor = true;
            // 
            // chk_CompactSearch
            // 
            this.chk_CompactSearch.AutoSize = true;
            this.chk_CompactSearch.Location = new System.Drawing.Point(13, 520);
            this.chk_CompactSearch.Name = "chk_CompactSearch";
            this.chk_CompactSearch.Size = new System.Drawing.Size(102, 17);
            this.chk_CompactSearch.TabIndex = 6;
            this.chk_CompactSearch.Text = "CompactSearch";
            this.chk_CompactSearch.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.tssl_RecordCount,
            this.toolStripStatusLabel4,
            this.tssl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip_Main";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(105, 17);
            this.toolStripStatusLabel2.Text = "Max Result = 500  |";
            // 
            // tssl_RecordCount
            // 
            this.tssl_RecordCount.Name = "tssl_RecordCount";
            this.tssl_RecordCount.Size = new System.Drawing.Size(100, 17);
            this.tssl_RecordCount.Text = "Record Count = 0";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // tssl_Status
            // 
            this.tssl_Status.Name = "tssl_Status";
            this.tssl_Status.Size = new System.Drawing.Size(48, 17);
            this.tssl_Status.Text = "Ready...";
            // 
            // frmYelpHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chk_CompactSearch);
            this.Controls.Add(this.chkbox_HotAndNew);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.listView_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Distance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_SortBy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmYelpHelp";
            this.Text = "YelpHelp";
            this.Load += new System.EventHandler(this.frmYelpHelp_Load);
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.TextBox txt_Term;
        private System.Windows.Forms.ComboBox cmb_CategoryParent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Geo;
        private System.Windows.Forms.RadioButton radio_Gps;
        private System.Windows.Forms.RadioButton radio_Geo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Gps_Long;
        private System.Windows.Forms.TextBox txt_Gps_Lat;
        private System.Windows.Forms.ToolTip toolTip_Main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_Price4;
        private System.Windows.Forms.CheckBox chk_Price3;
        private System.Windows.Forms.CheckBox chk_Price2;
        private System.Windows.Forms.CheckBox chk_Price1;
        private System.Windows.Forms.ComboBox cmb_SortBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Distance;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radio_OpenNow;
        private System.Windows.Forms.RadioButton radio_None;
        private System.Windows.Forms.RadioButton radio_OpenAt;
        private System.Windows.Forms.ListView listView_Result;
        private System.Windows.Forms.ColumnHeader Hdr_Name;
        private System.Windows.Forms.ColumnHeader Hdr_ReviewCount;
        private System.Windows.Forms.ColumnHeader Hdr_Price;
        private System.Windows.Forms.ColumnHeader Hdr_Rating;
        private System.Windows.Forms.ColumnHeader Hdr_Phone;
        private System.Windows.Forms.ColumnHeader Hdr_Categories;
        private System.Windows.Forms.ColumnHeader Hdr_Distance;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_CategoriesChild;
        private System.Windows.Forms.CheckBox chkbox_HotAndNew;
        private System.Windows.Forms.CheckBox chk_Term;
        private System.Windows.Forms.CheckBox chk_Category;
        private System.Windows.Forms.DateTimePicker dtp_OpenAtTime;
        private System.Windows.Forms.DateTimePicker dtp_OpenAtDate;
        private System.Windows.Forms.ColumnHeader Hdr_Address;
        private System.Windows.Forms.CheckBox chk_CompactSearch;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_RecordCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
    }
}

