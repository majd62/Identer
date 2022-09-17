namespace Identer.Admin_Forms
{
    partial class AdminMenu
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.requestsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize1 = new FontAwesome.Sharp.IconButton();
            this.btnMaximize1 = new FontAwesome.Sharp.IconButton();
            this.btnExit1 = new FontAwesome.Sharp.IconButton();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.requestsBtn = new FontAwesome.Sharp.IconButton();
            this.usersBtn = new FontAwesome.Sharp.IconButton();
            this.dashboardBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idRequestCounter = new System.Windows.Forms.Label();
            this.idAcceptedCounter = new System.Windows.Forms.Label();
            this.dlAcceptedCounter = new System.Windows.Forms.Label();
            this.dlRequestCounter = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.wlAcceptedCounter = new System.Windows.Forms.Label();
            this.wlRequestCounter = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.blAcceptedCounter = new System.Windows.Forms.Label();
            this.blRequestCounter = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.clAcceptedCounter = new System.Windows.Forms.Label();
            this.clRequestCounter = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestsChart)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Controls.Add(this.requestsBtn);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 706);
            this.panel1.TabIndex = 0;
          
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 155);
            this.panel3.TabIndex = 0;
        
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.LightGray;
            this.panelTitleBar.Controls.Add(this.btnMinimize1);
            this.panelTitleBar.Controls.Add(this.btnMaximize1);
            this.panelTitleBar.Controls.Add(this.btnExit1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1230, 100);
            this.panelTitleBar.TabIndex = 1;
            
            this.panelTitleBar.DoubleClick += new System.EventHandler(this.panelTitleBar_DoubleClick);
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 54);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(88, 20);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Dashboard";
           
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.requestsChart);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1230, 606);
            this.panelDesktop.TabIndex = 2;
            
            // 
            // requestsChart
            // 
            this.requestsChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requestsChart.BackColor = System.Drawing.Color.Transparent;
            this.requestsChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.requestsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.requestsChart.Legends.Add(legend1);
            this.requestsChart.Location = new System.Drawing.Point(243, 226);
            this.requestsChart.Name = "requestsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Requests";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Accepted";
            this.requestsChart.Series.Add(series1);
            this.requestsChart.Series.Add(series2);
            this.requestsChart.Size = new System.Drawing.Size(753, 377);
            this.requestsChart.TabIndex = 2;
            this.requestsChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Statistics";
            this.requestsChart.Titles.Add(title1);
            
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 216);
            this.panel2.TabIndex = 3;
            
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackgroundImage = global::Identer.Properties.Resources.carBack;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.clAcceptedCounter);
            this.panel8.Controls.Add(this.clRequestCounter);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.label18);
            this.panel8.Location = new System.Drawing.Point(977, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 148);
            this.panel8.TabIndex = 4;
           
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackgroundImage = global::Identer.Properties.Resources.boatBack;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.blAcceptedCounter);
            this.panel6.Controls.Add(this.blRequestCounter);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Location = new System.Drawing.Point(733, 28);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 148);
            this.panel6.TabIndex = 3;
          
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackgroundImage = global::Identer.Properties.Resources.weaponBack;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.wlAcceptedCounter);
            this.panel5.Controls.Add(this.wlRequestCounter);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(493, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 148);
            this.panel5.TabIndex = 4;
            
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackgroundImage = global::Identer.Properties.Resources.driveBack;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.dlAcceptedCounter);
            this.panel4.Controls.Add(this.dlRequestCounter);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(254, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 148);
            this.panel4.TabIndex = 5;
   
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackgroundImage = global::Identer.Properties.Resources.idBack;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.idAcceptedCounter);
            this.panel7.Controls.Add(this.idRequestCounter);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(16, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 148);
            this.panel7.TabIndex = 2;
         
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(115, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "confirmed";
          
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(115, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requests";
            
            // 
            // btnMinimize1
            // 
            this.btnMinimize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize1.FlatAppearance.BorderSize = 0;
            this.btnMinimize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize1.IconColor = System.Drawing.Color.Black;
            this.btnMinimize1.IconSize = 16;
            this.btnMinimize1.Location = new System.Drawing.Point(1151, 2);
            this.btnMinimize1.Name = "btnMinimize1";
            this.btnMinimize1.Rotation = 0D;
            this.btnMinimize1.Size = new System.Drawing.Size(22, 23);
            this.btnMinimize1.TabIndex = 13;
            this.btnMinimize1.UseVisualStyleBackColor = true;
            this.btnMinimize1.Click += new System.EventHandler(this.btnMinimize1_Click);
            // 
            // btnMaximize1
            // 
            this.btnMaximize1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize1.FlatAppearance.BorderSize = 0;
            this.btnMaximize1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize1.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btnMaximize1.IconColor = System.Drawing.Color.Black;
            this.btnMaximize1.IconSize = 16;
            this.btnMaximize1.Location = new System.Drawing.Point(1179, 5);
            this.btnMaximize1.Name = "btnMaximize1";
            this.btnMaximize1.Rotation = 0D;
            this.btnMaximize1.Size = new System.Drawing.Size(22, 23);
            this.btnMaximize1.TabIndex = 12;
            this.btnMaximize1.UseVisualStyleBackColor = true;
            this.btnMaximize1.Click += new System.EventHandler(this.btnMaximize1_Click);
            // 
            // btnExit1
            // 
            this.btnExit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit1.FlatAppearance.BorderSize = 0;
            this.btnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit1.IconColor = System.Drawing.Color.Black;
            this.btnExit1.IconSize = 16;
            this.btnExit1.Location = new System.Drawing.Point(1207, 5);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Rotation = 0D;
            this.btnExit1.Size = new System.Drawing.Size(16, 23);
            this.btnExit1.TabIndex = 11;
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 42);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
     
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.Black;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 519);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.logoutBtn.Rotation = 0D;
            this.logoutBtn.Size = new System.Drawing.Size(200, 91);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Log-Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.settingsBtn.IconColor = System.Drawing.Color.Black;
            this.settingsBtn.IconSize = 32;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(0, 428);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.settingsBtn.Rotation = 0D;
            this.settingsBtn.Size = new System.Drawing.Size(200, 91);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // requestsBtn
            // 
            this.requestsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.requestsBtn.FlatAppearance.BorderSize = 0;
            this.requestsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.requestsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestsBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.requestsBtn.IconColor = System.Drawing.Color.Black;
            this.requestsBtn.IconSize = 32;
            this.requestsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestsBtn.Location = new System.Drawing.Point(0, 337);
            this.requestsBtn.Name = "requestsBtn";
            this.requestsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.requestsBtn.Rotation = 0D;
            this.requestsBtn.Size = new System.Drawing.Size(200, 91);
            this.requestsBtn.TabIndex = 3;
            this.requestsBtn.Text = "Requests";
            this.requestsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.requestsBtn.UseVisualStyleBackColor = true;
            this.requestsBtn.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.usersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.usersBtn.IconColor = System.Drawing.Color.Black;
            this.usersBtn.IconSize = 32;
            this.usersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.Location = new System.Drawing.Point(0, 246);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.usersBtn.Rotation = 0D;
            this.usersBtn.Size = new System.Drawing.Size(200, 91);
            this.usersBtn.TabIndex = 2;
            this.usersBtn.Text = "Users";
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dashboardBtn.IconColor = System.Drawing.Color.Black;
            this.dashboardBtn.IconSize = 32;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 155);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardBtn.Rotation = 0D;
            this.dashboardBtn.Size = new System.Drawing.Size(200, 91);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // idRequestCounter
            // 
            this.idRequestCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idRequestCounter.AutoSize = true;
            this.idRequestCounter.BackColor = System.Drawing.Color.Transparent;
            this.idRequestCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idRequestCounter.Location = new System.Drawing.Point(121, 42);
            this.idRequestCounter.Name = "idRequestCounter";
            this.idRequestCounter.Size = new System.Drawing.Size(67, 20);
            this.idRequestCounter.TabIndex = 2;
            this.idRequestCounter.Text = "label11";
            
            // 
            // idAcceptedCounter
            // 
            this.idAcceptedCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idAcceptedCounter.AutoSize = true;
            this.idAcceptedCounter.BackColor = System.Drawing.Color.Transparent;
            this.idAcceptedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAcceptedCounter.Location = new System.Drawing.Point(121, 98);
            this.idAcceptedCounter.Name = "idAcceptedCounter";
            this.idAcceptedCounter.Size = new System.Drawing.Size(67, 20);
            this.idAcceptedCounter.TabIndex = 3;
            this.idAcceptedCounter.Text = "label12";
            
            // 
            // dlAcceptedCounter
            // 
            this.dlAcceptedCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dlAcceptedCounter.AutoSize = true;
            this.dlAcceptedCounter.BackColor = System.Drawing.Color.Transparent;
            this.dlAcceptedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlAcceptedCounter.Location = new System.Drawing.Point(124, 98);
            this.dlAcceptedCounter.Name = "dlAcceptedCounter";
            this.dlAcceptedCounter.Size = new System.Drawing.Size(67, 20);
            this.dlAcceptedCounter.TabIndex = 7;
            this.dlAcceptedCounter.Text = "label12";
            
            // 
            // dlRequestCounter
            // 
            this.dlRequestCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dlRequestCounter.AutoSize = true;
            this.dlRequestCounter.BackColor = System.Drawing.Color.Transparent;
            this.dlRequestCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlRequestCounter.Location = new System.Drawing.Point(124, 42);
            this.dlRequestCounter.Name = "dlRequestCounter";
            this.dlRequestCounter.Size = new System.Drawing.Size(67, 20);
            this.dlRequestCounter.TabIndex = 6;
            this.dlRequestCounter.Text = "label11";
          
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.label11.Location = new System.Drawing.Point(118, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "confirmed";
   
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(118, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Requests";

            // 
            // wlAcceptedCounter
            // 
            this.wlAcceptedCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wlAcceptedCounter.AutoSize = true;
            this.wlAcceptedCounter.BackColor = System.Drawing.Color.Transparent;
            this.wlAcceptedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlAcceptedCounter.Location = new System.Drawing.Point(126, 98);
            this.wlAcceptedCounter.Name = "wlAcceptedCounter";
            this.wlAcceptedCounter.Size = new System.Drawing.Size(67, 20);
            this.wlAcceptedCounter.TabIndex = 7;
            this.wlAcceptedCounter.Text = "label12";
       
            // 
            // wlRequestCounter
            // 
            this.wlRequestCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wlRequestCounter.AutoSize = true;
            this.wlRequestCounter.BackColor = System.Drawing.Color.Transparent;
            this.wlRequestCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wlRequestCounter.Location = new System.Drawing.Point(126, 42);
            this.wlRequestCounter.Name = "wlRequestCounter";
            this.wlRequestCounter.Size = new System.Drawing.Size(67, 20);
            this.wlRequestCounter.TabIndex = 6;
            this.wlRequestCounter.Text = "label11";
         
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.label13.Location = new System.Drawing.Point(120, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "confirmed";
      
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label14.Location = new System.Drawing.Point(120, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Requests";
           
            // 
            // blAcceptedCounter
            // 
            this.blAcceptedCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blAcceptedCounter.AutoSize = true;
            this.blAcceptedCounter.BackColor = System.Drawing.Color.Transparent;
            this.blAcceptedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blAcceptedCounter.Location = new System.Drawing.Point(143, 98);
            this.blAcceptedCounter.Name = "blAcceptedCounter";
            this.blAcceptedCounter.Size = new System.Drawing.Size(67, 20);
            this.blAcceptedCounter.TabIndex = 7;
            this.blAcceptedCounter.Text = "label12";
           
            // 
            // blRequestCounter
            // 
            this.blRequestCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blRequestCounter.AutoSize = true;
            this.blRequestCounter.BackColor = System.Drawing.Color.Transparent;
            this.blRequestCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blRequestCounter.Location = new System.Drawing.Point(143, 42);
            this.blRequestCounter.Name = "blRequestCounter";
            this.blRequestCounter.Size = new System.Drawing.Size(67, 20);
            this.blRequestCounter.TabIndex = 6;
            this.blRequestCounter.Text = "label11";
          
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.label15.Location = new System.Drawing.Point(137, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "confirmed";
        
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label16.Location = new System.Drawing.Point(137, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Requests";
         
            // 
            // clAcceptedCounter
            // 
            this.clAcceptedCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clAcceptedCounter.AutoSize = true;
            this.clAcceptedCounter.BackColor = System.Drawing.Color.Transparent;
            this.clAcceptedCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clAcceptedCounter.Location = new System.Drawing.Point(131, 98);
            this.clAcceptedCounter.Name = "clAcceptedCounter";
            this.clAcceptedCounter.Size = new System.Drawing.Size(67, 20);
            this.clAcceptedCounter.TabIndex = 7;
            this.clAcceptedCounter.Text = "label12";
            
            // 
            // clRequestCounter
            // 
            this.clRequestCounter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clRequestCounter.AutoSize = true;
            this.clRequestCounter.BackColor = System.Drawing.Color.Transparent;
            this.clRequestCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clRequestCounter.Location = new System.Drawing.Point(131, 42);
            this.clRequestCounter.Name = "clRequestCounter";
            this.clRequestCounter.Size = new System.Drawing.Size(67, 20);
            this.clRequestCounter.TabIndex = 6;
            this.clRequestCounter.Text = "label11";
         
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(180)))), ((int)(((byte)(65)))));
            this.label17.Location = new System.Drawing.Point(125, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "confirmed";
          
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label18.Location = new System.Drawing.Point(125, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Requests";
         
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 706);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1446, 745);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestsChart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton settingsBtn;
        private FontAwesome.Sharp.IconButton requestsBtn;
        private FontAwesome.Sharp.IconButton usersBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnMinimize1;
        private FontAwesome.Sharp.IconButton btnMaximize1;
        private FontAwesome.Sharp.IconButton btnExit1;
        public FontAwesome.Sharp.IconButton dashboardBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart requestsChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clAcceptedCounter;
        private System.Windows.Forms.Label clRequestCounter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label blAcceptedCounter;
        private System.Windows.Forms.Label blRequestCounter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label wlAcceptedCounter;
        private System.Windows.Forms.Label wlRequestCounter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label dlAcceptedCounter;
        private System.Windows.Forms.Label dlRequestCounter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label idAcceptedCounter;
        private System.Windows.Forms.Label idRequestCounter;
    }
}