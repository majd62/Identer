namespace Identer.User_Forms
{
    partial class PaymentMethod
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
            this.backBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cardNum1Txt = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cvvTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.ownerTxt = new System.Windows.Forms.TextBox();
            this.visaBtn = new System.Windows.Forms.Button();
            this.masterCardBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backBtn.Location = new System.Drawing.Point(299, 385);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(477, 272);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(87, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 2, 0, 0, 0, 0);
            // 
            // cardNum1Txt
            // 
            this.cardNum1Txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cardNum1Txt.Location = new System.Drawing.Point(299, 229);
            this.cardNum1Txt.MaxLength = 16;
            this.cardNum1Txt.Name = "cardNum1Txt";
            this.cardNum1Txt.Size = new System.Drawing.Size(265, 20);
            this.cardNum1Txt.TabIndex = 1;
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nextBtn.Location = new System.Drawing.Point(489, 385);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(654, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "CVV";
            // 
            // cvvTxt
            // 
            this.cvvTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cvvTxt.Location = new System.Drawing.Point(526, 323);
            this.cvvTxt.MaxLength = 3;
            this.cvvTxt.Name = "cvvTxt";
            this.cvvTxt.Size = new System.Drawing.Size(38, 20);
            this.cvvTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "תוקף הכרטיס";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(622, 232);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(69, 13);
            this.lbl3.TabIndex = 27;
            this.lbl3.Text = "מספר כרטיס";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(602, 180);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(89, 13);
            this.lbl1.TabIndex = 26;
            this.lbl1.Text = "שם בעל הכרטיס";
            // 
            // ownerTxt
            // 
            this.ownerTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ownerTxt.Location = new System.Drawing.Point(299, 177);
            this.ownerTxt.Name = "ownerTxt";
            this.ownerTxt.Size = new System.Drawing.Size(265, 20);
            this.ownerTxt.TabIndex = 0;
            // 
            // visaBtn
            // 
            this.visaBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visaBtn.BackgroundImage = global::Identer.Properties.Resources.download;
            this.visaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visaBtn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.visaBtn.FlatAppearance.BorderSize = 2;
            this.visaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visaBtn.Location = new System.Drawing.Point(299, 59);
            this.visaBtn.Name = "visaBtn";
            this.visaBtn.Size = new System.Drawing.Size(93, 84);
            this.visaBtn.TabIndex = 37;
            this.visaBtn.UseVisualStyleBackColor = true;
            this.visaBtn.Click += new System.EventHandler(this.visaBtn_Click);
            // 
            // masterCardBtn
            // 
            this.masterCardBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.masterCardBtn.BackgroundImage = global::Identer.Properties.Resources.download__1_;
            this.masterCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.masterCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masterCardBtn.Location = new System.Drawing.Point(450, 59);
            this.masterCardBtn.Name = "masterCardBtn";
            this.masterCardBtn.Size = new System.Drawing.Size(92, 84);
            this.masterCardBtn.TabIndex = 34;
            this.masterCardBtn.UseVisualStyleBackColor = true;
            this.masterCardBtn.Click += new System.EventHandler(this.masterCardBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 507);
            this.panel1.TabIndex = 38;
            this.panel1.Visible = false;
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 507);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.visaBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.masterCardBtn);
            this.Controls.Add(this.cardNum1Txt);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cvvTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.ownerTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethod";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button masterCardBtn;
        private System.Windows.Forms.TextBox cardNum1Txt;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cvvTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox ownerTxt;
        private System.Windows.Forms.Button visaBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Panel panel1;
    }
}