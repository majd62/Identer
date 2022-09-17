namespace Identer.User_Forms
{
    partial class UserMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.aboutBtn = new FontAwesome.Sharp.IconButton();
            this.weaponBtn = new FontAwesome.Sharp.IconButton();
            this.carBtn = new FontAwesome.Sharp.IconButton();
            this.CruiseBtn = new FontAwesome.Sharp.IconButton();
            this.drivingBtn = new FontAwesome.Sharp.IconButton();
            this.idBtn = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize1 = new FontAwesome.Sharp.IconButton();
            this.btnMaximize1 = new FontAwesome.Sharp.IconButton();
            this.btnExit1 = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.inProgressPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.aboutBtn);
            this.panel1.Controls.Add(this.weaponBtn);
            this.panel1.Controls.Add(this.carBtn);
            this.panel1.Controls.Add(this.CruiseBtn);
            this.panel1.Controls.Add(this.drivingBtn);
            this.panel1.Controls.Add(this.idBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 706);
            this.panel1.TabIndex = 0;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.logoutBtn.IconColor = System.Drawing.Color.Black;
            this.logoutBtn.IconSize = 32;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.Location = new System.Drawing.Point(0, 558);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.logoutBtn.Rotation = 0D;
            this.logoutBtn.Size = new System.Drawing.Size(200, 68);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Log-Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.aboutBtn.IconColor = System.Drawing.Color.Black;
            this.aboutBtn.IconSize = 32;
            this.aboutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.Location = new System.Drawing.Point(0, 490);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.aboutBtn.Rotation = 0D;
            this.aboutBtn.Size = new System.Drawing.Size(200, 68);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About";
            this.aboutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // weaponBtn
            // 
            this.weaponBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.weaponBtn.FlatAppearance.BorderSize = 0;
            this.weaponBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weaponBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.weaponBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.weaponBtn.IconColor = System.Drawing.Color.Black;
            this.weaponBtn.IconSize = 32;
            this.weaponBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weaponBtn.Location = new System.Drawing.Point(0, 422);
            this.weaponBtn.Name = "weaponBtn";
            this.weaponBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.weaponBtn.Rotation = 0D;
            this.weaponBtn.Size = new System.Drawing.Size(200, 68);
            this.weaponBtn.TabIndex = 5;
            this.weaponBtn.Text = "Weapon License";
            this.weaponBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.weaponBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.weaponBtn.UseVisualStyleBackColor = true;
            this.weaponBtn.Click += new System.EventHandler(this.weaponBtn_Click);
            // 
            // carBtn
            // 
            this.carBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.carBtn.FlatAppearance.BorderSize = 0;
            this.carBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.carBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carBtn.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.carBtn.IconColor = System.Drawing.Color.Black;
            this.carBtn.IconSize = 32;
            this.carBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carBtn.Location = new System.Drawing.Point(0, 354);
            this.carBtn.Name = "carBtn";
            this.carBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.carBtn.Rotation = 0D;
            this.carBtn.Size = new System.Drawing.Size(200, 68);
            this.carBtn.TabIndex = 4;
            this.carBtn.Text = "Car License";
            this.carBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.carBtn.UseVisualStyleBackColor = true;
            this.carBtn.Click += new System.EventHandler(this.carBtn_Click);
            // 
            // CruiseBtn
            // 
            this.CruiseBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CruiseBtn.FlatAppearance.BorderSize = 0;
            this.CruiseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CruiseBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CruiseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CruiseBtn.IconChar = FontAwesome.Sharp.IconChar.Ship;
            this.CruiseBtn.IconColor = System.Drawing.Color.Black;
            this.CruiseBtn.IconSize = 32;
            this.CruiseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CruiseBtn.Location = new System.Drawing.Point(0, 286);
            this.CruiseBtn.Name = "CruiseBtn";
            this.CruiseBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CruiseBtn.Rotation = 0D;
            this.CruiseBtn.Size = new System.Drawing.Size(200, 68);
            this.CruiseBtn.TabIndex = 3;
            this.CruiseBtn.Text = "Cruise License";
            this.CruiseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CruiseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CruiseBtn.UseVisualStyleBackColor = true;
            this.CruiseBtn.Click += new System.EventHandler(this.CruiseBtn_Click);
            // 
            // drivingBtn
            // 
            this.drivingBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.drivingBtn.FlatAppearance.BorderSize = 0;
            this.drivingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drivingBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.drivingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drivingBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.drivingBtn.IconColor = System.Drawing.Color.Black;
            this.drivingBtn.IconSize = 32;
            this.drivingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivingBtn.Location = new System.Drawing.Point(0, 218);
            this.drivingBtn.Name = "drivingBtn";
            this.drivingBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.drivingBtn.Rotation = 0D;
            this.drivingBtn.Size = new System.Drawing.Size(200, 68);
            this.drivingBtn.TabIndex = 2;
            this.drivingBtn.Text = "Driving License";
            this.drivingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.drivingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.drivingBtn.UseVisualStyleBackColor = true;
            this.drivingBtn.Click += new System.EventHandler(this.drivingBtn_Click);
            // 
            // idBtn
            // 
            this.idBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.idBtn.FlatAppearance.BorderSize = 0;
            this.idBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.idBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBtn.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.idBtn.IconColor = System.Drawing.Color.Black;
            this.idBtn.IconSize = 32;
            this.idBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtn.Location = new System.Drawing.Point(0, 150);
            this.idBtn.Name = "idBtn";
            this.idBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.idBtn.Rotation = 0D;
            this.idBtn.Size = new System.Drawing.Size(200, 68);
            this.idBtn.TabIndex = 1;
            this.idBtn.Text = "Identity Card";
            this.idBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.idBtn.UseVisualStyleBackColor = true;
            this.idBtn.Click += new System.EventHandler(this.idBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 150);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Identer.Properties.Resources.logo3_TRANS;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(139)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize1);
            this.panelTitleBar.Controls.Add(this.btnMaximize1);
            this.panelTitleBar.Controls.Add(this.btnExit1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(984, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.btnMinimize1.Location = new System.Drawing.Point(900, 9);
            this.btnMinimize1.Name = "btnMinimize1";
            this.btnMinimize1.Rotation = 0D;
            this.btnMinimize1.Size = new System.Drawing.Size(22, 23);
            this.btnMinimize1.TabIndex = 10;
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
            this.btnMaximize1.Location = new System.Drawing.Point(928, 12);
            this.btnMaximize1.Name = "btnMaximize1";
            this.btnMaximize1.Rotation = 0D;
            this.btnMaximize1.Size = new System.Drawing.Size(22, 23);
            this.btnMaximize1.TabIndex = 9;
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
            this.btnExit1.Location = new System.Drawing.Point(956, 12);
            this.btnExit1.Name = "btnExit1";
            this.btnExit1.Rotation = 0D;
            this.btnExit1.Size = new System.Drawing.Size(16, 23);
            this.btnExit1.TabIndex = 8;
            this.btnExit1.UseVisualStyleBackColor = true;
            this.btnExit1.Click += new System.EventHandler(this.btnExit1_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(74, 46);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(120)))), ((int)(((byte)(139)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(36, 37);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDesktop.Controls.Add(this.welcomelbl);
            this.panelDesktop.Controls.Add(this.logoPic);
            this.panelDesktop.Controls.Add(this.inProgressPic);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 100);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 606);
            this.panelDesktop.TabIndex = 2;
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(76)))), ((int)(((byte)(208)))));
            this.welcomelbl.Location = new System.Drawing.Point(396, 322);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(169, 31);
            this.welcomelbl.TabIndex = 2;
            this.welcomelbl.Text = "WELCOME!";
            // 
            // logoPic
            // 
            this.logoPic.Image = global::Identer.Properties.Resources.logo3_TRANS;
            this.logoPic.Location = new System.Drawing.Point(262, 8);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(422, 278);
            this.logoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPic.TabIndex = 1;
            this.logoPic.TabStop = false;
            // 
            // inProgressPic
            // 
            this.inProgressPic.Image = global::Identer.Properties.Resources.IN_PROGRESS;
            this.inProgressPic.Location = new System.Drawing.Point(78, 64);
            this.inProgressPic.Name = "inProgressPic";
            this.inProgressPic.Size = new System.Drawing.Size(856, 462);
            this.inProgressPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inProgressPic.TabIndex = 0;
            this.inProgressPic.TabStop = false;
            this.inProgressPic.Visible = false;
            // 
            // UserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 706);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1200, 669);
            this.Name = "UserMain";
            this.Text = "UserMain";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProgressPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton aboutBtn;
        private FontAwesome.Sharp.IconButton weaponBtn;
        private FontAwesome.Sharp.IconButton carBtn;
        private FontAwesome.Sharp.IconButton CruiseBtn;
        private FontAwesome.Sharp.IconButton drivingBtn;
        private FontAwesome.Sharp.IconButton idBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconButton btnMinimize1;
        private FontAwesome.Sharp.IconButton btnMaximize1;
        private FontAwesome.Sharp.IconButton btnExit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox inProgressPic;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.PictureBox logoPic;
    }
}