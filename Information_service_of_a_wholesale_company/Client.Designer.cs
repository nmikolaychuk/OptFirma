namespace Information_service_of_a_wholesale_company
{
    partial class Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.Client_TextBox = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите своё имя или название организации";
            // 
            // Client_TextBox
            // 
            this.Client_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Client_TextBox.Location = new System.Drawing.Point(17, 54);
            this.Client_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.Client_TextBox.Name = "Client_TextBox";
            this.Client_TextBox.Size = new System.Drawing.Size(470, 35);
            this.Client_TextBox.TabIndex = 24;
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_OK.Location = new System.Drawing.Point(237, 94);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(116, 35);
            this.button_OK.TabIndex = 25;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCancel.Location = new System.Drawing.Point(371, 94);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(116, 35);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 141);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.Client_TextBox);
            this.Controls.Add(this.label2);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Client_TextBox;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button buttonCancel;
    }
}