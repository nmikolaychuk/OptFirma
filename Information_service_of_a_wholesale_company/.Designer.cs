namespace Information_service_of_a_wholesale_company
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_Position
            // 
            this.comboBox_Position.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Position.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Position.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Location = new System.Drawing.Point(50, 49);
            this.comboBox_Position.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Position.Name = "comboBox_Position";
            this.comboBox_Position.Size = new System.Drawing.Size(134, 27);
            this.comboBox_Position.TabIndex = 20;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.Location = new System.Drawing.Point(50, 112);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(134, 27);
            this.Password_TextBox.TabIndex = 23;
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Input.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Input.BackgroundImage")));
            this.Input.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Input.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Input.Location = new System.Drawing.Point(1, 169);
            this.Input.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(210, 35);
            this.Input.TabIndex = 25;
            this.Input.Text = "Вход";
            this.Input.UseVisualStyleBackColor = false;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Information_service_of_a_wholesale_company.Properties.Resources.Авторизация;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(212, 208);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.comboBox_Position);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Position;
        public System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Button Input;
    }
}

