namespace client
{
    partial class addHolderNotion
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
            this.innBox = new System.Windows.Forms.TextBox();
            this.surBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.otchBox = new System.Windows.Forms.TextBox();
            this.ogrBox = new System.Windows.Forms.TextBox();
            this.dopBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // innBox
            // 
            this.innBox.Location = new System.Drawing.Point(102, 57);
            this.innBox.Name = "innBox";
            this.innBox.Size = new System.Drawing.Size(225, 23);
            this.innBox.TabIndex = 0;
            // 
            // surBox
            // 
            this.surBox.Location = new System.Drawing.Point(102, 113);
            this.surBox.Name = "surBox";
            this.surBox.Size = new System.Drawing.Size(225, 23);
            this.surBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(102, 166);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(225, 23);
            this.nameBox.TabIndex = 2;
            // 
            // otchBox
            // 
            this.otchBox.Location = new System.Drawing.Point(102, 219);
            this.otchBox.Name = "otchBox";
            this.otchBox.Size = new System.Drawing.Size(225, 23);
            this.otchBox.TabIndex = 3;
            // 
            // ogrBox
            // 
            this.ogrBox.Location = new System.Drawing.Point(102, 268);
            this.ogrBox.Name = "ogrBox";
            this.ogrBox.Size = new System.Drawing.Size(225, 23);
            this.ogrBox.TabIndex = 4;
            // 
            // dopBox
            // 
            this.dopBox.Location = new System.Drawing.Point(102, 322);
            this.dopBox.Name = "dopBox";
            this.dopBox.Size = new System.Drawing.Size(225, 23);
            this.dopBox.TabIndex = 5;
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
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ограничения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Дополнения";
            // 
            // holderAddNotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.dopBox);
            this.Controls.Add(this.ogrBox);
            this.Controls.Add(this.otchBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surBox);
            this.Controls.Add(this.innBox);
            this.Name = "holderAddNotion";
            this.Text = "Добавление правообладателя";
            this.Load += new System.EventHandler(this.holderAddNotion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox innBox;
        public TextBox surBox;
        public TextBox nameBox;
        public TextBox otchBox;
        public TextBox ogrBox;
        public TextBox dopBox;
        public Button returnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}