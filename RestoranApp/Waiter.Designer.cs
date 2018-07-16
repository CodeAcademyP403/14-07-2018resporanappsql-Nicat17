namespace RestoranApp
{
    partial class Waiter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waiter));
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.comboBox_eaten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_order = new System.Windows.Forms.Button();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_otherRoles = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_allPrice = new System.Windows.Forms.Label();
            this.listView_row = new System.Windows.Forms.ListView();
            this.Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_price
            // 
            this.textBox_price.Enabled = false;
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_price.Location = new System.Drawing.Point(43, 202);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(301, 21);
            this.textBox_price.TabIndex = 0;
            // 
            // textBox_count
            // 
            this.textBox_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_count.Location = new System.Drawing.Point(43, 274);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(301, 21);
            this.textBox_count.TabIndex = 1;
            this.textBox_count.Text = "1";
            this.textBox_count.Enter += new System.EventHandler(this.textBox_count_Enter);
            this.textBox_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_count_KeyPress);
            this.textBox_count.Leave += new System.EventHandler(this.textBox_count_Leave);
            // 
            // comboBox_category
            // 
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.Location = new System.Drawing.Point(43, 53);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(301, 23);
            this.comboBox_category.TabIndex = 2;
            this.comboBox_category.SelectedValueChanged += new System.EventHandler(this.comboBox_category_SelectedValueChanged);
            // 
            // comboBox_eaten
            // 
            this.comboBox_eaten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eaten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_eaten.FormattingEnabled = true;
            this.comboBox_eaten.Location = new System.Drawing.Point(43, 131);
            this.comboBox_eaten.Name = "comboBox_eaten";
            this.comboBox_eaten.Size = new System.Drawing.Size(301, 23);
            this.comboBox_eaten.TabIndex = 3;
            this.comboBox_eaten.SelectedValueChanged += new System.EventHandler(this.comboBox_eaten_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(40, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Eaten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(40, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label4.Location = new System.Drawing.Point(40, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_order.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_order.Location = new System.Drawing.Point(43, 326);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(98, 37);
            this.button_order.TabIndex = 8;
            this.button_order.Text = "Order";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkKhaki;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_refresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_refresh.Location = new System.Drawing.Point(390, 325);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(102, 37);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_otherRoles
            // 
            this.button_otherRoles.BackColor = System.Drawing.Color.DarkOrange;
            this.button_otherRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_otherRoles.ForeColor = System.Drawing.SystemColors.Control;
            this.button_otherRoles.Location = new System.Drawing.Point(888, 322);
            this.button_otherRoles.Name = "button_otherRoles";
            this.button_otherRoles.Size = new System.Drawing.Size(142, 40);
            this.button_otherRoles.TabIndex = 16;
            this.button_otherRoles.Text = "Enter Other Roles";
            this.button_otherRoles.UseVisualStyleBackColor = false;
            this.button_otherRoles.Click += new System.EventHandler(this.button_otherRoles_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(648, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "All Price:";
            // 
            // label_allPrice
            // 
            this.label_allPrice.AutoSize = true;
            this.label_allPrice.BackColor = System.Drawing.Color.Transparent;
            this.label_allPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_allPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_allPrice.Location = new System.Drawing.Point(737, 331);
            this.label_allPrice.Name = "label_allPrice";
            this.label_allPrice.Size = new System.Drawing.Size(21, 24);
            this.label_allPrice.TabIndex = 18;
            this.label_allPrice.Text = "0";
            // 
            // listView_row
            // 
            this.listView_row.BackColor = System.Drawing.Color.Wheat;
            this.listView_row.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Num,
            this.name,
            this.category,
            this.price,
            this.count,
            this.totalPrice});
            this.listView_row.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listView_row.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView_row.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.listView_row.FullRowSelect = true;
            this.listView_row.GridLines = true;
            this.listView_row.Location = new System.Drawing.Point(390, 53);
            this.listView_row.Name = "listView_row";
            this.listView_row.Size = new System.Drawing.Size(640, 241);
            this.listView_row.TabIndex = 19;
            this.listView_row.UseCompatibleStateImageBehavior = false;
            this.listView_row.View = System.Windows.Forms.View.Details;
            // 
            // Num
            // 
            this.Num.Text = "N";
            this.Num.Width = 51;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 115;
            // 
            // category
            // 
            this.category.Text = "Category";
            this.category.Width = 112;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 120;
            // 
            // count
            // 
            this.count.Text = "Count";
            this.count.Width = 123;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Total Price";
            this.totalPrice.Width = 115;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_delete.Location = new System.Drawing.Point(515, 325);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(97, 37);
            this.button_delete.TabIndex = 20;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 388);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.listView_row);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_allPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_otherRoles);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_eaten);
            this.Controls.Add(this.comboBox_category);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_price);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Waiter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Waiter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Waiter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.ComboBox comboBox_eaten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Button button_otherRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_allPrice;
        private System.Windows.Forms.ListView listView_row;
        private System.Windows.Forms.ColumnHeader Num;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader totalPrice;
        private System.Windows.Forms.Button button_delete;
    }
}