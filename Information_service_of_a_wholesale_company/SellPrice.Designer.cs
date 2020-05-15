namespace Information_service_of_a_wholesale_company
{
    partial class SellPrice
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
            this.product_sellprice_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sellprice_textbox = new System.Windows.Forms.Label();
            this.okey_sellprice_button = new System.Windows.Forms.Button();
            this.cancel_sellprice_button = new System.Windows.Forms.Button();
            this.price_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // product_sellprice_combobox
            // 
            this.product_sellprice_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_sellprice_combobox.FormattingEnabled = true;
            this.product_sellprice_combobox.Location = new System.Drawing.Point(13, 13);
            this.product_sellprice_combobox.Name = "product_sellprice_combobox";
            this.product_sellprice_combobox.Size = new System.Drawing.Size(121, 21);
            this.product_sellprice_combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Продукт / цена закупки";
            // 
            // sellprice_textbox
            // 
            this.sellprice_textbox.AutoSize = true;
            this.sellprice_textbox.Location = new System.Drawing.Point(140, 44);
            this.sellprice_textbox.Name = "sellprice_textbox";
            this.sellprice_textbox.Size = new System.Drawing.Size(80, 13);
            this.sellprice_textbox.TabIndex = 3;
            this.sellprice_textbox.Text = "Цена продажи";
            // 
            // okey_sellprice_button
            // 
            this.okey_sellprice_button.Location = new System.Drawing.Point(50, 85);
            this.okey_sellprice_button.Name = "okey_sellprice_button";
            this.okey_sellprice_button.Size = new System.Drawing.Size(75, 23);
            this.okey_sellprice_button.TabIndex = 4;
            this.okey_sellprice_button.Text = "OK";
            this.okey_sellprice_button.UseVisualStyleBackColor = true;
            this.okey_sellprice_button.Click += new System.EventHandler(this.okey_sellprice_button_Click);
            // 
            // cancel_sellprice_button
            // 
            this.cancel_sellprice_button.Location = new System.Drawing.Point(145, 85);
            this.cancel_sellprice_button.Name = "cancel_sellprice_button";
            this.cancel_sellprice_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_sellprice_button.TabIndex = 5;
            this.cancel_sellprice_button.Text = "Отмена";
            this.cancel_sellprice_button.UseVisualStyleBackColor = true;
            this.cancel_sellprice_button.Click += new System.EventHandler(this.cancel_sellprice_button_Click);
            // 
            // price_combobox
            // 
            this.price_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.price_combobox.FormattingEnabled = true;
            this.price_combobox.Location = new System.Drawing.Point(13, 41);
            this.price_combobox.Name = "price_combobox";
            this.price_combobox.Size = new System.Drawing.Size(121, 21);
            this.price_combobox.TabIndex = 6;
            // 
            // SellPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 115);
            this.Controls.Add(this.price_combobox);
            this.Controls.Add(this.cancel_sellprice_button);
            this.Controls.Add(this.okey_sellprice_button);
            this.Controls.Add(this.sellprice_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.product_sellprice_combobox);
            this.Name = "SellPrice";
            this.Text = "Цена продажи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox product_sellprice_combobox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label sellprice_textbox;
        private System.Windows.Forms.Button okey_sellprice_button;
        private System.Windows.Forms.Button cancel_sellprice_button;
        public System.Windows.Forms.ComboBox price_combobox;
    }
}