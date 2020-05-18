namespace Information_service_of_a_wholesale_company
{
    partial class NumberOfOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberoforder_textbox = new System.Windows.Forms.TextBox();
            this.okey_number_button = new System.Windows.Forms.Button();
            this.cancel_number_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите номер вашего заказа:";
            // 
            // numberoforder_textbox
            // 
            this.numberoforder_textbox.BackColor = System.Drawing.Color.White;
            this.numberoforder_textbox.Location = new System.Drawing.Point(12, 44);
            this.numberoforder_textbox.Name = "numberoforder_textbox";
            this.numberoforder_textbox.Size = new System.Drawing.Size(344, 20);
            this.numberoforder_textbox.TabIndex = 4;
            // 
            // okey_number_button
            // 
            this.okey_number_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.okey_number_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okey_number_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okey_number_button.Location = new System.Drawing.Point(175, 75);
            this.okey_number_button.Margin = new System.Windows.Forms.Padding(2);
            this.okey_number_button.Name = "okey_number_button";
            this.okey_number_button.Size = new System.Drawing.Size(89, 28);
            this.okey_number_button.TabIndex = 8;
            this.okey_number_button.Text = "OK";
            this.okey_number_button.UseVisualStyleBackColor = false;
            this.okey_number_button.Click += new System.EventHandler(this.okey_number_button_Click);
            // 
            // cancel_number_button
            // 
            this.cancel_number_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.cancel_number_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_number_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancel_number_button.Location = new System.Drawing.Point(268, 75);
            this.cancel_number_button.Margin = new System.Windows.Forms.Padding(2);
            this.cancel_number_button.Name = "cancel_number_button";
            this.cancel_number_button.Size = new System.Drawing.Size(89, 28);
            this.cancel_number_button.TabIndex = 9;
            this.cancel_number_button.Text = "Отмена";
            this.cancel_number_button.UseVisualStyleBackColor = false;
            this.cancel_number_button.Click += new System.EventHandler(this.cancel_number_button_Click);
            // 
            // NumberOfOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Information_service_of_a_wholesale_company.Properties.Resources.ФонВыдачаТоваров;
            this.ClientSize = new System.Drawing.Size(368, 110);
            this.Controls.Add(this.cancel_number_button);
            this.Controls.Add(this.okey_number_button);
            this.Controls.Add(this.numberoforder_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumberOfOrder";
            this.Text = "Номер заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox numberoforder_textbox;
        public System.Windows.Forms.Button okey_number_button;
        public System.Windows.Forms.Button cancel_number_button;
    }
}