namespace Information_service_of_a_wholesale_company
{
    partial class DeliveryOfGoods
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.delivery_dgv = new System.Windows.Forms.DataGridView();
            this.InformationDelivery = new System.Windows.Forms.Button();
            this.pickuporder = new System.Windows.Forms.Button();
            this.number_of_order = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.number_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 56);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выдача товаров";
            // 
            // delivery_dgv
            // 
            this.delivery_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.delivery_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delivery_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.delivery_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.delivery_dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.delivery_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.delivery_dgv.Location = new System.Drawing.Point(2, 68);
            this.delivery_dgv.MultiSelect = false;
            this.delivery_dgv.Name = "delivery_dgv";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.delivery_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.delivery_dgv.Size = new System.Drawing.Size(797, 350);
            this.delivery_dgv.TabIndex = 3;
            // 
            // InformationDelivery
            // 
            this.InformationDelivery.BackColor = System.Drawing.Color.DarkOrange;
            this.InformationDelivery.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationDelivery.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InformationDelivery.Location = new System.Drawing.Point(11, 423);
            this.InformationDelivery.Margin = new System.Windows.Forms.Padding(2);
            this.InformationDelivery.Name = "InformationDelivery";
            this.InformationDelivery.Size = new System.Drawing.Size(158, 28);
            this.InformationDelivery.TabIndex = 5;
            this.InformationDelivery.Text = "Информация";
            this.InformationDelivery.UseVisualStyleBackColor = false;
            this.InformationDelivery.Click += new System.EventHandler(this.InformationDelivery_Click);
            // 
            // pickuporder
            // 
            this.pickuporder.BackColor = System.Drawing.Color.DarkOrange;
            this.pickuporder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickuporder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.pickuporder.Location = new System.Drawing.Point(631, 423);
            this.pickuporder.Margin = new System.Windows.Forms.Padding(2);
            this.pickuporder.Name = "pickuporder";
            this.pickuporder.Size = new System.Drawing.Size(158, 28);
            this.pickuporder.TabIndex = 6;
            this.pickuporder.Text = "Забрать заказ";
            this.pickuporder.UseVisualStyleBackColor = false;
            this.pickuporder.Click += new System.EventHandler(this.pickuporder_Click);
            // 
            // number_of_order
            // 
            this.number_of_order.BackColor = System.Drawing.Color.DarkOrange;
            this.number_of_order.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_of_order.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.number_of_order.Location = new System.Drawing.Point(491, 423);
            this.number_of_order.Margin = new System.Windows.Forms.Padding(2);
            this.number_of_order.Name = "number_of_order";
            this.number_of_order.Size = new System.Drawing.Size(136, 28);
            this.number_of_order.TabIndex = 7;
            this.number_of_order.Text = "Номер заказа";
            this.number_of_order.UseVisualStyleBackColor = false;
            this.number_of_order.Click += new System.EventHandler(this.number_of_order_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Заказ";
            // 
            // number_textbox
            // 
            this.number_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(0)))));
            this.number_textbox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.number_textbox.Location = new System.Drawing.Point(61, 44);
            this.number_textbox.Name = "number_textbox";
            this.number_textbox.ReadOnly = true;
            this.number_textbox.Size = new System.Drawing.Size(26, 23);
            this.number_textbox.TabIndex = 9;
            this.number_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeliveryOfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.BackgroundImage = global::Information_service_of_a_wholesale_company.Properties.Resources.ФонВыдачаТоваров;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 455);
            this.Controls.Add(this.number_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_of_order);
            this.Controls.Add(this.pickuporder);
            this.Controls.Add(this.InformationDelivery);
            this.Controls.Add(this.delivery_dgv);
            this.Controls.Add(this.label1);
            this.Name = "DeliveryOfGoods";
            this.Text = "Выдача товаров";
            ((System.ComponentModel.ISupportInitialize)(this.delivery_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView delivery_dgv;
        private System.Windows.Forms.Button InformationDelivery;
        private System.Windows.Forms.Button pickuporder;
        private System.Windows.Forms.Button number_of_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number_textbox;
    }
}