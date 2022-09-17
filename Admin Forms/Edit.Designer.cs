namespace Identer.Admin_Forms
{
    partial class Edit
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
            this.femaleRb = new System.Windows.Forms.RadioButton();
            this.maleRb = new System.Windows.Forms.RadioButton();
            this.updateBtn = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.editedText = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // femaleRb
            // 
            this.femaleRb.AutoSize = true;
            this.femaleRb.Location = new System.Drawing.Point(577, 279);
            this.femaleRb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.femaleRb.Name = "femaleRb";
            this.femaleRb.Size = new System.Drawing.Size(75, 21);
            this.femaleRb.TabIndex = 14;
            this.femaleRb.TabStop = true;
            this.femaleRb.Text = "Female";
            this.femaleRb.UseVisualStyleBackColor = true;
            this.femaleRb.Visible = false;
            // 
            // maleRb
            // 
            this.maleRb.AutoSize = true;
            this.maleRb.Location = new System.Drawing.Point(357, 283);
            this.maleRb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maleRb.Name = "maleRb";
            this.maleRb.Size = new System.Drawing.Size(59, 21);
            this.maleRb.TabIndex = 13;
            this.maleRb.TabStop = true;
            this.maleRb.Text = "Male";
            this.maleRb.UseVisualStyleBackColor = true;
            this.maleRb.Visible = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(887, 449);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 28);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(357, 133);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(280, 24);
            this.comboBox.TabIndex = 10;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged_1);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(577, 308);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(100, 28);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "insert";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Visible = false;
            this.insertBtn.Click += new System.EventHandler(this.insert_Click);
            // 
            // editedText
            // 
            this.editedText.Location = new System.Drawing.Point(357, 311);
            this.editedText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editedText.Name = "editedText";
            this.editedText.Size = new System.Drawing.Size(280, 22);
            this.editedText.TabIndex = 8;
            this.editedText.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Identer.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(415, 192);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.femaleRb);
            this.Controls.Add(this.maleRb);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.editedText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton femaleRb;
        private System.Windows.Forms.RadioButton maleRb;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.TextBox editedText;
    }
}