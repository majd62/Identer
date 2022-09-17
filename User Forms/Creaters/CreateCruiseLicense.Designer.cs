namespace Identer.User_Forms.Creaters
{
    partial class CreateCruiseLicense
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
            this.label3 = new System.Windows.Forms.Label();
            this.FileNameTxt = new System.Windows.Forms.TextBox();
            this.insertFileBtn = new System.Windows.Forms.Button();
            this.removeFile2 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.bdateTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.degreeComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idNumberTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.uploadPicBtn = new FontAwesome.Sharp.IconButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(668, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 107;
            this.label3.Text = "תמונה אישית";
            // 
            // FileNameTxt
            // 
            this.FileNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FileNameTxt.BackColor = System.Drawing.Color.White;
            this.FileNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileNameTxt.Enabled = false;
            this.FileNameTxt.Location = new System.Drawing.Point(473, 255);
            this.FileNameTxt.Name = "FileNameTxt";
            this.FileNameTxt.Size = new System.Drawing.Size(75, 13);
            this.FileNameTxt.TabIndex = 105;
            this.FileNameTxt.Visible = false;
            // 
            // insertFileBtn
            // 
            this.insertFileBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertFileBtn.Location = new System.Drawing.Point(372, 243);
            this.insertFileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.insertFileBtn.Name = "insertFileBtn";
            this.insertFileBtn.Size = new System.Drawing.Size(87, 29);
            this.insertFileBtn.TabIndex = 104;
            this.insertFileBtn.Text = "Insert";
            this.insertFileBtn.UseVisualStyleBackColor = true;
            this.insertFileBtn.Click += new System.EventHandler(this.insertFileBtn_Click);
            // 
            // removeFile2
            // 
            this.removeFile2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.removeFile2.AutoSize = true;
            this.removeFile2.BackColor = System.Drawing.Color.Transparent;
            this.removeFile2.LinkColor = System.Drawing.Color.Red;
            this.removeFile2.Location = new System.Drawing.Point(554, 253);
            this.removeFile2.Name = "removeFile2";
            this.removeFile2.Size = new System.Drawing.Size(14, 13);
            this.removeFile2.TabIndex = 103;
            this.removeFile2.TabStop = true;
            this.removeFile2.Text = "X";
            this.removeFile2.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(369, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "תאריך לידה";
            // 
            // bdateTP
            // 
            this.bdateTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bdateTP.CustomFormat = "dd-MM-yyyy";
            this.bdateTP.Enabled = false;
            this.bdateTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdateTP.Location = new System.Drawing.Point(372, 78);
            this.bdateTP.Margin = new System.Windows.Forms.Padding(2);
            this.bdateTP.Name = "bdateTP";
            this.bdateTP.Size = new System.Drawing.Size(133, 20);
            this.bdateTP.TabIndex = 101;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "אישור עיוני";
            // 
            // degreeComboBox
            // 
            this.degreeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.degreeComboBox.FormattingEnabled = true;
            this.degreeComboBox.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "20",
            "21",
            "30",
            "40",
            "50",
            "60"});
            this.degreeComboBox.Location = new System.Drawing.Point(372, 164);
            this.degreeComboBox.Name = "degreeComboBox";
            this.degreeComboBox.Size = new System.Drawing.Size(66, 21);
            this.degreeComboBox.TabIndex = 99;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 135);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "בחר דרגה";
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(783, 419);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(105, 37);
            this.nextBtn.TabIndex = 97;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "מספר תעודת זהות";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "שם משפחה";
            // 
            // addressTxt
            // 
            this.addressTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTxt.Enabled = false;
            this.addressTxt.Location = new System.Drawing.Point(84, 336);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(2);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(202, 20);
            this.addressTxt.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "כתובת";
            // 
            // idNumberTxt
            // 
            this.idNumberTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idNumberTxt.Enabled = false;
            this.idNumberTxt.Location = new System.Drawing.Point(84, 248);
            this.idNumberTxt.Margin = new System.Windows.Forms.Padding(2);
            this.idNumberTxt.Name = "idNumberTxt";
            this.idNumberTxt.Size = new System.Drawing.Size(202, 20);
            this.idNumberTxt.TabIndex = 92;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastNameTxt.Enabled = false;
            this.lastNameTxt.Location = new System.Drawing.Point(84, 164);
            this.lastNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(202, 20);
            this.lastNameTxt.TabIndex = 91;
            // 
            // nameTb
            // 
            this.nameTb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTb.Enabled = false;
            this.nameTb.Location = new System.Drawing.Point(84, 78);
            this.nameTb.Margin = new System.Windows.Forms.Padding(2);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(202, 20);
            this.nameTb.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "שם פרטי";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Camera;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButton1.IconSize = 16;
            this.iconButton1.Location = new System.Drawing.Point(728, 229);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 109;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // uploadPicBtn
            // 
            this.uploadPicBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uploadPicBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.uploadPicBtn.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.uploadPicBtn.IconColor = System.Drawing.Color.Black;
            this.uploadPicBtn.IconSize = 16;
            this.uploadPicBtn.Location = new System.Drawing.Point(647, 229);
            this.uploadPicBtn.Name = "uploadPicBtn";
            this.uploadPicBtn.Rotation = 0D;
            this.uploadPicBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadPicBtn.TabIndex = 108;
            this.uploadPicBtn.Text = "upload";
            this.uploadPicBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.uploadPicBtn.UseVisualStyleBackColor = true;
            this.uploadPicBtn.Click += new System.EventHandler(this.uploadPicBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Image = global::Identer.Properties.Resources.images;
            this.pictureBox.Location = new System.Drawing.Point(647, 78);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(122, 138);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 106;
            this.pictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 507);
            this.panel1.TabIndex = 110;
            this.panel1.Visible = false;
            // 
            // CreateCruiseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.uploadPicBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.FileNameTxt);
            this.Controls.Add(this.insertFileBtn);
            this.Controls.Add(this.removeFile2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bdateTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.degreeComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idNumberTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(968, 507);
            this.Name = "CreateCruiseLicense";
            this.Text = "CreateCruiseLicense";
            this.Load += new System.EventHandler(this.CreateCruiseLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton uploadPicBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox FileNameTxt;
        private System.Windows.Forms.Button insertFileBtn;
        private System.Windows.Forms.LinkLabel removeFile2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker bdateTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox degreeComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idNumberTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Panel panel1;
    }
}