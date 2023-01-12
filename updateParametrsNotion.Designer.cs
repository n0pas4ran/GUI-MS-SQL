namespace client
{
    partial class updateParametrsNotion
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
            this.squareBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.TextBox();
            this.floorsBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // squareBox
            // 
            this.squareBox.Location = new System.Drawing.Point(108, 163);
            this.squareBox.Name = "squareBox";
            this.squareBox.Size = new System.Drawing.Size(225, 23);
            this.squareBox.TabIndex = 0;
            // 
            // materialBox
            // 
            this.materialBox.Location = new System.Drawing.Point(108, 201);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(225, 23);
            this.materialBox.TabIndex = 1;
            // 
            // floorsBox
            // 
            this.floorsBox.Location = new System.Drawing.Point(108, 239);
            this.floorsBox.Name = "floorsBox";
            this.floorsBox.Size = new System.Drawing.Size(225, 23);
            this.floorsBox.TabIndex = 2;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(108, 278);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(225, 23);
            this.priceBox.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Площадь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Материал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Кол-во этажей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Новые данные";
            // 
            // updateParametrsNotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.floorsBox);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.squareBox);
            this.Name = "updateParametrsNotion";
            this.Text = "Обновление параметров объекта";
            this.Load += new System.EventHandler(this.updateParametrsNotion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox squareBox;
        public TextBox materialBox;
        public TextBox floorsBox;
        public TextBox priceBox;
        public Button returnButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
    }
}