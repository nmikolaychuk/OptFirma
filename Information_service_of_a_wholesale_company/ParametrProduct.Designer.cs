namespace Information_service_of_a_wholesale_company
{
    partial class ParametrProduct
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
            this.name_product = new System.Windows.Forms.TextBox();
            this.textBox_kol = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_product
            // 
            this.name_product.Location = new System.Drawing.Point(12, 12);
            this.name_product.Name = "name_product";
            this.name_product.Size = new System.Drawing.Size(273, 26);
            this.name_product.TabIndex = 1;
            // 
            // textBox_kol
            // 
            this.textBox_kol.Location = new System.Drawing.Point(12, 44);
            this.textBox_kol.Name = "textBox_kol";
            this.textBox_kol.Size = new System.Drawing.Size(273, 26);
            this.textBox_kol.TabIndex = 2;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 76);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(175, 33);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество";
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(193, 76);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(175, 33);
            this.button_cansel.TabIndex = 8;
            this.button_cansel.Text = "Отмена";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // ParametrProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 121);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_kol);
            this.Controls.Add(this.name_product);
            this.Name = "ParametrProduct";
            this.Text = "ParametrProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox name_product;
        public System.Windows.Forms.TextBox textBox_kol;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_cansel;
    }
}