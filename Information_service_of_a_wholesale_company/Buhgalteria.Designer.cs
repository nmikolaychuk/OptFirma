namespace Information_service_of_a_wholesale_company
{
    partial class Buhgalteria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buhgalteria_dgv = new System.Windows.Forms.DataGridView();
            this.sellprice_button = new System.Windows.Forms.Button();
            this.find_product_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buhgalteria_tabcontrol = new System.Windows.Forms.TabControl();
            this.tab_sellprice = new System.Windows.Forms.TabPage();
            this.info_button = new System.Windows.Forms.Button();
            this.tab_profit = new System.Windows.Forms.TabPage();
            this.calcprofit_button = new System.Windows.Forms.Button();
            this.profit_itog_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showsells_button = new System.Windows.Forms.Button();
            this.sellto_timepicker = new System.Windows.Forms.DateTimePicker();
            this.sellfrom_timepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profit_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.InfNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buhgalteria_dgv)).BeginInit();
            this.buhgalteria_tabcontrol.SuspendLayout();
            this.tab_sellprice.SuspendLayout();
            this.tab_profit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profit_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // buhgalteria_dgv
            // 
            this.buhgalteria_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.buhgalteria_dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.buhgalteria_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.buhgalteria_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buhgalteria_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.buhgalteria_dgv.Location = new System.Drawing.Point(3, 3);
            this.buhgalteria_dgv.Name = "buhgalteria_dgv";
            this.buhgalteria_dgv.Size = new System.Drawing.Size(904, 296);
            this.buhgalteria_dgv.TabIndex = 0;
            // 
            // sellprice_button
            // 
            this.sellprice_button.BackColor = System.Drawing.Color.SteelBlue;
            this.sellprice_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellprice_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.sellprice_button.Location = new System.Drawing.Point(746, 302);
            this.sellprice_button.Name = "sellprice_button";
            this.sellprice_button.Size = new System.Drawing.Size(156, 30);
            this.sellprice_button.TabIndex = 1;
            this.sellprice_button.Text = "Установить цену продажи";
            this.sellprice_button.UseVisualStyleBackColor = false;
            this.sellprice_button.Click += new System.EventHandler(this.sellprice_button_Click);
            // 
            // find_product_textbox
            // 
            this.find_product_textbox.BackColor = System.Drawing.Color.SteelBlue;
            this.find_product_textbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find_product_textbox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.find_product_textbox.Location = new System.Drawing.Point(6, 305);
            this.find_product_textbox.Name = "find_product_textbox";
            this.find_product_textbox.Size = new System.Drawing.Size(100, 27);
            this.find_product_textbox.TabIndex = 2;
            this.find_product_textbox.TextChanged += new System.EventHandler(this.find_product_textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(112, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск товара";
            // 
            // buhgalteria_tabcontrol
            // 
            this.buhgalteria_tabcontrol.Controls.Add(this.tab_sellprice);
            this.buhgalteria_tabcontrol.Controls.Add(this.tab_profit);
            this.buhgalteria_tabcontrol.HotTrack = true;
            this.buhgalteria_tabcontrol.Location = new System.Drawing.Point(-1, 68);
            this.buhgalteria_tabcontrol.Name = "buhgalteria_tabcontrol";
            this.buhgalteria_tabcontrol.SelectedIndex = 0;
            this.buhgalteria_tabcontrol.Size = new System.Drawing.Size(918, 362);
            this.buhgalteria_tabcontrol.TabIndex = 4;
            // 
            // tab_sellprice
            // 
            this.tab_sellprice.BackColor = System.Drawing.Color.SteelBlue;
            this.tab_sellprice.Controls.Add(this.InfNew);
            this.tab_sellprice.Controls.Add(this.info_button);
            this.tab_sellprice.Controls.Add(this.buhgalteria_dgv);
            this.tab_sellprice.Controls.Add(this.sellprice_button);
            this.tab_sellprice.Controls.Add(this.label1);
            this.tab_sellprice.Controls.Add(this.find_product_textbox);
            this.tab_sellprice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_sellprice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tab_sellprice.Location = new System.Drawing.Point(4, 22);
            this.tab_sellprice.Name = "tab_sellprice";
            this.tab_sellprice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sellprice.Size = new System.Drawing.Size(910, 336);
            this.tab_sellprice.TabIndex = 0;
            this.tab_sellprice.Text = "Назначение продажной цены";
            // 
            // info_button
            // 
            this.info_button.BackColor = System.Drawing.Color.SteelBlue;
            this.info_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.info_button.Location = new System.Drawing.Point(608, 302);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(132, 30);
            this.info_button.TabIndex = 4;
            this.info_button.Text = "Информация";
            this.info_button.UseVisualStyleBackColor = false;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // tab_profit
            // 
            this.tab_profit.BackColor = System.Drawing.Color.SteelBlue;
            this.tab_profit.Controls.Add(this.calcprofit_button);
            this.tab_profit.Controls.Add(this.profit_itog_textbox);
            this.tab_profit.Controls.Add(this.label6);
            this.tab_profit.Controls.Add(this.showsells_button);
            this.tab_profit.Controls.Add(this.sellto_timepicker);
            this.tab_profit.Controls.Add(this.sellfrom_timepicker);
            this.tab_profit.Controls.Add(this.label5);
            this.tab_profit.Controls.Add(this.label4);
            this.tab_profit.Controls.Add(this.label3);
            this.tab_profit.Controls.Add(this.profit_dgv);
            this.tab_profit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_profit.Location = new System.Drawing.Point(4, 22);
            this.tab_profit.Name = "tab_profit";
            this.tab_profit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_profit.Size = new System.Drawing.Size(910, 336);
            this.tab_profit.TabIndex = 1;
            this.tab_profit.Text = "Расчет прибыли за период";
            // 
            // calcprofit_button
            // 
            this.calcprofit_button.BackColor = System.Drawing.Color.SteelBlue;
            this.calcprofit_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.calcprofit_button.Location = new System.Drawing.Point(713, 263);
            this.calcprofit_button.Name = "calcprofit_button";
            this.calcprofit_button.Size = new System.Drawing.Size(189, 30);
            this.calcprofit_button.TabIndex = 9;
            this.calcprofit_button.Text = "Подсчитать прибыль";
            this.calcprofit_button.UseVisualStyleBackColor = false;
            this.calcprofit_button.Click += new System.EventHandler(this.calcprofit_button_Click);
            // 
            // profit_itog_textbox
            // 
            this.profit_itog_textbox.Location = new System.Drawing.Point(782, 300);
            this.profit_itog_textbox.Name = "profit_itog_textbox";
            this.profit_itog_textbox.ReadOnly = true;
            this.profit_itog_textbox.Size = new System.Drawing.Size(100, 27);
            this.profit_itog_textbox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(718, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Итого:";
            // 
            // showsells_button
            // 
            this.showsells_button.BackColor = System.Drawing.Color.SteelBlue;
            this.showsells_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showsells_button.Location = new System.Drawing.Point(375, 300);
            this.showsells_button.Name = "showsells_button";
            this.showsells_button.Size = new System.Drawing.Size(170, 30);
            this.showsells_button.TabIndex = 6;
            this.showsells_button.Text = "Показать продажи";
            this.showsells_button.UseVisualStyleBackColor = false;
            this.showsells_button.Click += new System.EventHandler(this.showsells_button_Click);
            // 
            // sellto_timepicker
            // 
            this.sellto_timepicker.Location = new System.Drawing.Point(237, 302);
            this.sellto_timepicker.Name = "sellto_timepicker";
            this.sellto_timepicker.Size = new System.Drawing.Size(132, 27);
            this.sellto_timepicker.TabIndex = 5;
            // 
            // sellfrom_timepicker
            // 
            this.sellfrom_timepicker.Location = new System.Drawing.Point(58, 302);
            this.sellfrom_timepicker.Name = "sellfrom_timepicker";
            this.sellfrom_timepicker.Size = new System.Drawing.Size(132, 27);
            this.sellfrom_timepicker.TabIndex = 4;
            this.sellfrom_timepicker.Value = new System.DateTime(2020, 1, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(196, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "До:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(18, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(196, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Временной отрезок";
            // 
            // profit_dgv
            // 
            this.profit_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.profit_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profit_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profit_dgv.Location = new System.Drawing.Point(3, 3);
            this.profit_dgv.Name = "profit_dgv";
            this.profit_dgv.Size = new System.Drawing.Size(904, 253);
            this.profit_dgv.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "Бухгалтерия";
            // 
            // InfNew
            // 
            this.InfNew.BackColor = System.Drawing.Color.SteelBlue;
            this.InfNew.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InfNew.Location = new System.Drawing.Point(439, 302);
            this.InfNew.Name = "InfNew";
            this.InfNew.Size = new System.Drawing.Size(163, 30);
            this.InfNew.TabIndex = 5;
            this.InfNew.Text = "Обновить данные";
            this.InfNew.UseVisualStyleBackColor = false;
            // 
            // Buhgalteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buhgalteria_tabcontrol);
            this.Name = "Buhgalteria";
            this.Text = "Бухгалтерия";
            this.Load += new System.EventHandler(this.Buhgalteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buhgalteria_dgv)).EndInit();
            this.buhgalteria_tabcontrol.ResumeLayout(false);
            this.tab_sellprice.ResumeLayout(false);
            this.tab_sellprice.PerformLayout();
            this.tab_profit.ResumeLayout(false);
            this.tab_profit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profit_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView buhgalteria_dgv;
        public System.Windows.Forms.Button sellprice_button;
        public System.Windows.Forms.TextBox find_product_textbox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl buhgalteria_tabcontrol;
        public System.Windows.Forms.TabPage tab_sellprice;
        public System.Windows.Forms.TabPage tab_profit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button info_button;
        public System.Windows.Forms.DataGridView profit_dgv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button showsells_button;
        public System.Windows.Forms.DateTimePicker sellfrom_timepicker;
        public System.Windows.Forms.DateTimePicker sellto_timepicker;
        public System.Windows.Forms.TextBox profit_itog_textbox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button calcprofit_button;
        private System.Windows.Forms.Button InfNew;
    }
}