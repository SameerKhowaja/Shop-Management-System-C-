namespace Shop_System_Management
{
    partial class PlaceOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemsLeftBox = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.Label();
            this.quantityBox1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalItemsLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.checkConnection = new System.Windows.Forms.Label();
            this.products = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.deleteProduct = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsLeftBox
            // 
            this.ItemsLeftBox.AutoSize = true;
            this.ItemsLeftBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ItemsLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ItemsLeftBox.Location = new System.Drawing.Point(185, 360);
            this.ItemsLeftBox.Name = "ItemsLeftBox";
            this.ItemsLeftBox.Size = new System.Drawing.Size(31, 29);
            this.ItemsLeftBox.TabIndex = 72;
            this.ItemsLeftBox.Text = "...";
            // 
            // priceBox
            // 
            this.priceBox.AutoSize = true;
            this.priceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.priceBox.Location = new System.Drawing.Point(105, 313);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(31, 29);
            this.priceBox.TabIndex = 71;
            this.priceBox.Text = "...";
            // 
            // quantityBox1
            // 
            this.quantityBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox1.Location = new System.Drawing.Point(130, 407);
            this.quantityBox1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.quantityBox1.Name = "quantityBox1";
            this.quantityBox1.Size = new System.Drawing.Size(106, 35);
            this.quantityBox1.TabIndex = 69;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FloralWhite;
            this.button1.Location = new System.Drawing.Point(403, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 57);
            this.button1.TabIndex = 68;
            this.button1.Text = "CANCEL ORDER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCyan;
            this.label8.Location = new System.Drawing.Point(42, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Total Items Left";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listView1.Location = new System.Drawing.Point(403, 15);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(524, 439);
            this.listView1.TabIndex = 65;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Maiandra GD", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightCyan;
            this.label10.Location = new System.Drawing.Point(42, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 22);
            this.label10.TabIndex = 64;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCyan;
            this.label9.Location = new System.Drawing.Point(44, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 62;
            this.label9.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cornsilk;
            this.label6.Location = new System.Drawing.Point(47, 467);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Total Items";
            // 
            // TotalItemsLabel
            // 
            this.TotalItemsLabel.AutoSize = true;
            this.TotalItemsLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalItemsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.TotalItemsLabel.Location = new System.Drawing.Point(49, 486);
            this.TotalItemsLabel.Name = "TotalItemsLabel";
            this.TotalItemsLabel.Size = new System.Drawing.Size(59, 40);
            this.TotalItemsLabel.TabIndex = 60;
            this.TotalItemsLabel.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Cornsilk;
            this.label7.Location = new System.Drawing.Point(174, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 19);
            this.label7.TabIndex = 59;
            this.label7.Text = "Total Price";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.TotalPriceLabel.Location = new System.Drawing.Point(171, 486);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(143, 40);
            this.TotalPriceLabel.TabIndex = 58;
            this.TotalPriceLabel.Text = "000000";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FloralWhite;
            this.button2.Location = new System.Drawing.Point(673, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 57);
            this.button2.TabIndex = 57;
            this.button2.Text = "PLACE ORDER";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // checkConnection
            // 
            this.checkConnection.AutoSize = true;
            this.checkConnection.BackColor = System.Drawing.Color.Transparent;
            this.checkConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkConnection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkConnection.Location = new System.Drawing.Point(761, 548);
            this.checkConnection.Name = "checkConnection";
            this.checkConnection.Size = new System.Drawing.Size(177, 13);
            this.checkConnection.TabIndex = 55;
            this.checkConnection.Text = "Not Connected to Database...";
            // 
            // products
            // 
            this.products.AllowDrop = true;
            this.products.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.products.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.products.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products.FormattingEnabled = true;
            this.products.ItemHeight = 24;
            this.products.Items.AddRange(new object[] {
            "None"});
            this.products.Location = new System.Drawing.Point(37, 266);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(339, 32);
            this.products.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCyan;
            this.label5.Location = new System.Drawing.Point(39, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Products*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCyan;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Address";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(37, 142);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(295, 97);
            this.address.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCyan;
            this.label3.Location = new System.Drawing.Point(39, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mobile Number";
            // 
            // mobile
            // 
            this.mobile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(37, 88);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(295, 29);
            this.mobile.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(39, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Customer Name*";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(37, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(295, 29);
            this.name.TabIndex = 46;
            // 
            // deleteProduct
            // 
            this.deleteProduct.BackgroundImage = global::Shop_System_Management.Properties.Resources.delete_100px;
            this.deleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteProduct.Location = new System.Drawing.Point(300, 405);
            this.deleteProduct.Name = "deleteProduct";
            this.deleteProduct.Size = new System.Drawing.Size(47, 40);
            this.deleteProduct.TabIndex = 66;
            this.deleteProduct.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Shop_System_Management.Properties.Resources.synchronize_40px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(339, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 32);
            this.button3.TabIndex = 63;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Shop_System_Management.Properties.Resources.add_100px;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(247, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 40);
            this.button5.TabIndex = 56;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.ItemsLeftBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.quantityBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.deleteProduct);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalItemsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalPriceLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkConnection);
            this.Controls.Add(this.products);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(976, 536);
            ((System.ComponentModel.ISupportInitialize)(this.quantityBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsLeftBox;
        private System.Windows.Forms.Label priceBox;
        private System.Windows.Forms.NumericUpDown quantityBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deleteProduct;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label TotalItemsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label checkConnection;
        private System.Windows.Forms.ComboBox products;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
    }
}
