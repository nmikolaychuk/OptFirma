namespace Information_service_of_a_wholesale_company
{
    partial class Warehouse
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_warehouse = new System.Windows.Forms.TabPage();
            this.things_outtime_button = new System.Windows.Forms.Button();
            this.delete_things_button = new System.Windows.Forms.Button();
            this.edit_things_button = new System.Windows.Forms.Button();
            this.add_things_button = new System.Windows.Forms.Button();
            this.warehouse_dgv = new System.Windows.Forms.DataGridView();
            this.tab_documents = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spisanie_dgv = new System.Windows.Forms.DataGridView();
            this.nakladnie_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NewDannie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_warehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dgv)).BeginInit();
            this.tab_documents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spisanie_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnie_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_warehouse);
            this.tabControl1.Controls.Add(this.tab_documents);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(2, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_warehouse
            // 
            this.tab_warehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_warehouse.Controls.Add(this.things_outtime_button);
            this.tab_warehouse.Controls.Add(this.delete_things_button);
            this.tab_warehouse.Controls.Add(this.edit_things_button);
            this.tab_warehouse.Controls.Add(this.add_things_button);
            this.tab_warehouse.Controls.Add(this.warehouse_dgv);
            this.tab_warehouse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_warehouse.Location = new System.Drawing.Point(4, 22);
            this.tab_warehouse.Name = "tab_warehouse";
            this.tab_warehouse.Padding = new System.Windows.Forms.Padding(3);
            this.tab_warehouse.Size = new System.Drawing.Size(1241, 495);
            this.tab_warehouse.TabIndex = 0;
            this.tab_warehouse.Text = "Склад";
            // 
            // things_outtime_button
            // 
            this.things_outtime_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.things_outtime_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.things_outtime_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.things_outtime_button.Location = new System.Drawing.Point(982, 459);
            this.things_outtime_button.Name = "things_outtime_button";
            this.things_outtime_button.Size = new System.Drawing.Size(250, 30);
            this.things_outtime_button.TabIndex = 4;
            this.things_outtime_button.Text = "Товары с истёкшим сроком хранения";
            this.things_outtime_button.UseVisualStyleBackColor = false;
            this.things_outtime_button.Click += new System.EventHandler(this.things_outtime_button_Click);
            // 
            // delete_things_button
            // 
            this.delete_things_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delete_things_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_things_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.delete_things_button.Location = new System.Drawing.Point(814, 459);
            this.delete_things_button.Name = "delete_things_button";
            this.delete_things_button.Size = new System.Drawing.Size(162, 30);
            this.delete_things_button.TabIndex = 3;
            this.delete_things_button.Text = "Обновить данные";
            this.delete_things_button.UseVisualStyleBackColor = false;
            this.delete_things_button.Click += new System.EventHandler(this.delete_things_button_Click);
            // 
            // edit_things_button
            // 
            this.edit_things_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.edit_things_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_things_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.edit_things_button.Location = new System.Drawing.Point(195, 459);
            this.edit_things_button.Name = "edit_things_button";
            this.edit_things_button.Size = new System.Drawing.Size(224, 30);
            this.edit_things_button.TabIndex = 2;
            this.edit_things_button.Text = "Редактирование товара";
            this.edit_things_button.UseVisualStyleBackColor = false;
            this.edit_things_button.Click += new System.EventHandler(this.edit_things_button_Click);
            // 
            // add_things_button
            // 
            this.add_things_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add_things_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_things_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.add_things_button.Location = new System.Drawing.Point(6, 459);
            this.add_things_button.Name = "add_things_button";
            this.add_things_button.Size = new System.Drawing.Size(183, 30);
            this.add_things_button.TabIndex = 1;
            this.add_things_button.Text = "Добавление товара";
            this.add_things_button.UseVisualStyleBackColor = false;
            this.add_things_button.Click += new System.EventHandler(this.add_things_button_Click);
            // 
            // warehouse_dgv
            // 
            this.warehouse_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.warehouse_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warehouse_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.warehouse_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.warehouse_dgv.Location = new System.Drawing.Point(3, 3);
            this.warehouse_dgv.MultiSelect = false;
            this.warehouse_dgv.Name = "warehouse_dgv";
            this.warehouse_dgv.Size = new System.Drawing.Size(1235, 450);
            this.warehouse_dgv.TabIndex = 0;
            // 
            // tab_documents
            // 
            this.tab_documents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tab_documents.Controls.Add(this.NewDannie);
            this.tab_documents.Controls.Add(this.label3);
            this.tab_documents.Controls.Add(this.label2);
            this.tab_documents.Controls.Add(this.spisanie_dgv);
            this.tab_documents.Controls.Add(this.nakladnie_dgv);
            this.tab_documents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tab_documents.Location = new System.Drawing.Point(4, 22);
            this.tab_documents.Name = "tab_documents";
            this.tab_documents.Padding = new System.Windows.Forms.Padding(3);
            this.tab_documents.Size = new System.Drawing.Size(1241, 495);
            this.tab_documents.TabIndex = 1;
            this.tab_documents.Text = "Документы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(833, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Акты списания";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(236, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Накладные";
            // 
            // spisanie_dgv
            // 
            this.spisanie_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spisanie_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spisanie_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spisanie_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.spisanie_dgv.Location = new System.Drawing.Point(621, 41);
            this.spisanie_dgv.Name = "spisanie_dgv";
            this.spisanie_dgv.Size = new System.Drawing.Size(617, 408);
            this.spisanie_dgv.TabIndex = 1;
            // 
            // nakladnie_dgv
            // 
            this.nakladnie_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.nakladnie_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nakladnie_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nakladnie_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.nakladnie_dgv.Location = new System.Drawing.Point(3, 41);
            this.nakladnie_dgv.Name = "nakladnie_dgv";
            this.nakladnie_dgv.Size = new System.Drawing.Size(617, 408);
            this.nakladnie_dgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(537, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Склад";
            // 
            // NewDannie
            // 
            this.NewDannie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewDannie.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewDannie.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NewDannie.Location = new System.Drawing.Point(541, 459);
            this.NewDannie.Name = "NewDannie";
            this.NewDannie.Size = new System.Drawing.Size(162, 30);
            this.NewDannie.TabIndex = 4;
            this.NewDannie.Text = "Обновить данные";
            this.NewDannie.UseVisualStyleBackColor = false;
            this.NewDannie.Click += new System.EventHandler(this.NewDannie_Click);
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_warehouse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_dgv)).EndInit();
            this.tab_documents.ResumeLayout(false);
            this.tab_documents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spisanie_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nakladnie_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tab_warehouse;
        private System.Windows.Forms.TabPage tab_documents;
        private System.Windows.Forms.Button add_things_button;
        public System.Windows.Forms.DataGridView warehouse_dgv;
        private System.Windows.Forms.Button delete_things_button;
        private System.Windows.Forms.Button edit_things_button;
        private System.Windows.Forms.Button things_outtime_button;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView spisanie_dgv;
        public System.Windows.Forms.DataGridView nakladnie_dgv;
        private System.Windows.Forms.Button NewDannie;
    }
}