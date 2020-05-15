namespace Information_service_of_a_wholesale_company
{
    partial class OuttimeThings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outtime_things_dgv = new System.Windows.Forms.DataGridView();
            this.do_akt = new System.Windows.Forms.Button();
            this.spisanie_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Inform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outtime_things_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // outtime_things_dgv
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outtime_things_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.outtime_things_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outtime_things_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outtime_things_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.outtime_things_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.outtime_things_dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.outtime_things_dgv.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.outtime_things_dgv.Location = new System.Drawing.Point(3, 71);
            this.outtime_things_dgv.MultiSelect = false;
            this.outtime_things_dgv.Name = "outtime_things_dgv";
            this.outtime_things_dgv.RowHeadersWidth = 62;
            this.outtime_things_dgv.Size = new System.Drawing.Size(1047, 338);
            this.outtime_things_dgv.TabIndex = 0;
            // 
            // do_akt
            // 
            this.do_akt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.do_akt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.do_akt.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.do_akt.Location = new System.Drawing.Point(884, 414);
            this.do_akt.Margin = new System.Windows.Forms.Padding(2);
            this.do_akt.Name = "do_akt";
            this.do_akt.Size = new System.Drawing.Size(158, 28);
            this.do_akt.TabIndex = 1;
            this.do_akt.Text = "Составить акт списания";
            this.do_akt.UseVisualStyleBackColor = false;
            this.do_akt.Click += new System.EventHandler(this.do_akt_Click);
            // 
            // spisanie_button
            // 
            this.spisanie_button.BackColor = System.Drawing.Color.DarkSlateGray;
            this.spisanie_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spisanie_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.spisanie_button.Location = new System.Drawing.Point(722, 414);
            this.spisanie_button.Margin = new System.Windows.Forms.Padding(2);
            this.spisanie_button.Name = "spisanie_button";
            this.spisanie_button.Size = new System.Drawing.Size(158, 28);
            this.spisanie_button.TabIndex = 2;
            this.spisanie_button.Text = "Списать товары";
            this.spisanie_button.UseVisualStyleBackColor = false;
            this.spisanie_button.Click += new System.EventHandler(this.spisanie_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Просроченные товары";
            // 
            // Inform
            // 
            this.Inform.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Inform.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inform.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Inform.Location = new System.Drawing.Point(560, 414);
            this.Inform.Margin = new System.Windows.Forms.Padding(2);
            this.Inform.Name = "Inform";
            this.Inform.Size = new System.Drawing.Size(158, 28);
            this.Inform.TabIndex = 4;
            this.Inform.Text = "Информация";
            this.Inform.UseVisualStyleBackColor = false;
            this.Inform.Click += new System.EventHandler(this.Inform_Click);
            // 
            // OuttimeThings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.Inform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spisanie_button);
            this.Controls.Add(this.do_akt);
            this.Controls.Add(this.outtime_things_dgv);
            this.Name = "OuttimeThings";
            this.Text = "Товары с истекшим сроком хранения";
            this.Load += new System.EventHandler(this.OuttimeThings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outtime_things_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView outtime_things_dgv;
        private System.Windows.Forms.Button do_akt;
        private System.Windows.Forms.Button spisanie_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Inform;
    }
}