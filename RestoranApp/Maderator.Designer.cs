namespace RestoranApp
{
    partial class Maderator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maderator));
            this.comboBox_waiter = new System.Windows.Forms.ComboBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_otherRoles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_waiter
            // 
            this.comboBox_waiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_waiter.FormattingEnabled = true;
            this.comboBox_waiter.Location = new System.Drawing.Point(77, 64);
            this.comboBox_waiter.Name = "comboBox_waiter";
            this.comboBox_waiter.Size = new System.Drawing.Size(345, 26);
            this.comboBox_waiter.TabIndex = 1;
            this.comboBox_waiter.SelectedValueChanged += new System.EventHandler(this.comboBox_waiter_SelectedValueChanged);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.DarkCyan;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_edit.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_edit.Location = new System.Drawing.Point(77, 126);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(141, 32);
            this.button_edit.TabIndex = 2;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_otherRoles
            // 
            this.button_otherRoles.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button_otherRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_otherRoles.ForeColor = System.Drawing.Color.Cornsilk;
            this.button_otherRoles.Location = new System.Drawing.Point(280, 126);
            this.button_otherRoles.Name = "button_otherRoles";
            this.button_otherRoles.Size = new System.Drawing.Size(142, 32);
            this.button_otherRoles.TabIndex = 3;
            this.button_otherRoles.Text = "Enter Other Roles";
            this.button_otherRoles.UseVisualStyleBackColor = false;
            this.button_otherRoles.Click += new System.EventHandler(this.button_otherRoles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(77, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Waiters";
            // 
            // Maderator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_otherRoles);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.comboBox_waiter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Maderator";
            this.Text = "Maderator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Maderator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_waiter;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_otherRoles;
        private System.Windows.Forms.Label label1;
    }
}