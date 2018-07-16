namespace RestoranApp
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.comboBox_Maderator = new System.Windows.Forms.ComboBox();
            this.comboBox_Waiter = new System.Windows.Forms.ComboBox();
            this.button_Maderator = new System.Windows.Forms.Button();
            this.button_Waiter = new System.Windows.Forms.Button();
            this.button_OtherRoles = new System.Windows.Forms.Button();
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.label_img = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Maderator
            // 
            this.comboBox_Maderator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Maderator.FormattingEnabled = true;
            this.comboBox_Maderator.Location = new System.Drawing.Point(52, 211);
            this.comboBox_Maderator.Name = "comboBox_Maderator";
            this.comboBox_Maderator.Size = new System.Drawing.Size(263, 28);
            this.comboBox_Maderator.TabIndex = 0;
            this.comboBox_Maderator.SelectedValueChanged += new System.EventHandler(this.comboBox_Maderator_SelectedValueChanged);
            // 
            // comboBox_Waiter
            // 
            this.comboBox_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Waiter.FormattingEnabled = true;
            this.comboBox_Waiter.Location = new System.Drawing.Point(413, 211);
            this.comboBox_Waiter.Name = "comboBox_Waiter";
            this.comboBox_Waiter.Size = new System.Drawing.Size(263, 28);
            this.comboBox_Waiter.TabIndex = 1;
            this.comboBox_Waiter.SelectedValueChanged += new System.EventHandler(this.comboBox_Waiter_SelectedValueChanged);
            // 
            // button_Maderator
            // 
            this.button_Maderator.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Maderator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Maderator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Maderator.Location = new System.Drawing.Point(52, 254);
            this.button_Maderator.Name = "button_Maderator";
            this.button_Maderator.Size = new System.Drawing.Size(107, 35);
            this.button_Maderator.TabIndex = 2;
            this.button_Maderator.Text = "Edit";
            this.button_Maderator.UseVisualStyleBackColor = false;
            this.button_Maderator.Click += new System.EventHandler(this.button_Maderator_Click);
            // 
            // button_Waiter
            // 
            this.button_Waiter.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_Waiter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Waiter.Location = new System.Drawing.Point(413, 254);
            this.button_Waiter.Name = "button_Waiter";
            this.button_Waiter.Size = new System.Drawing.Size(107, 35);
            this.button_Waiter.TabIndex = 3;
            this.button_Waiter.Text = "Edit";
            this.button_Waiter.UseVisualStyleBackColor = false;
            this.button_Waiter.Click += new System.EventHandler(this.button_Waiter_Click);
            // 
            // button_OtherRoles
            // 
            this.button_OtherRoles.BackColor = System.Drawing.Color.Cornsilk;
            this.button_OtherRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_OtherRoles.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_OtherRoles.Location = new System.Drawing.Point(52, 51);
            this.button_OtherRoles.Name = "button_OtherRoles";
            this.button_OtherRoles.Size = new System.Drawing.Size(209, 100);
            this.button_OtherRoles.TabIndex = 4;
            this.button_OtherRoles.Text = "Enter Other Roles";
            this.button_OtherRoles.UseVisualStyleBackColor = false;
            this.button_OtherRoles.Click += new System.EventHandler(this.button_OtherRoles_Click);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "admin.png");
            // 
            // label_img
            // 
            this.label_img.BackColor = System.Drawing.Color.Transparent;
            this.label_img.ImageIndex = 0;
            this.label_img.ImageList = this.ImgList;
            this.label_img.Location = new System.Drawing.Point(477, 27);
            this.label_img.Name = "label_img";
            this.label_img.Size = new System.Drawing.Size(178, 140);
            this.label_img.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(48, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maderator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(409, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Waiter";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 341);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_img);
            this.Controls.Add(this.button_OtherRoles);
            this.Controls.Add(this.button_Waiter);
            this.Controls.Add(this.button_Maderator);
            this.Controls.Add(this.comboBox_Waiter);
            this.Controls.Add(this.comboBox_Maderator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Maderator;
        private System.Windows.Forms.ComboBox comboBox_Waiter;
        private System.Windows.Forms.Button button_Maderator;
        private System.Windows.Forms.Button button_Waiter;
        private System.Windows.Forms.Button button_OtherRoles;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Label label_img;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}