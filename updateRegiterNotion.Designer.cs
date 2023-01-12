namespace client
{
    partial class updateRegisterNotion
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
            this.tipBox = new System.Windows.Forms.TextBox();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tipBox
            // 
            this.tipBox.Location = new System.Drawing.Point(113, 184);
            this.tipBox.Name = "tipBox";
            this.tipBox.Size = new System.Drawing.Size(225, 23);
            this.tipBox.TabIndex = 0;
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(113, 232);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(225, 23);
            this.dateBox.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(108, 382);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(131, 56);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "OK";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Новые данные";
            // 
            // updateRegisterNotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.tipBox);
            this.Name = "updateRegisterNotion";
            this.Text = "Обновление данных регистрации прав собственности";
            this.Load += new System.EventHandler(this.updateRegisterNotion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox tipBox;
        public TextBox dateBox;
        public Button returnButton;
        private Label label1;
        private Label label2;
        private Label label4;
    }
}