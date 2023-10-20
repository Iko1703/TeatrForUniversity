namespace Teatr
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            rjButton1 = new RJButton();
            rjButton2 = new RJButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(282, 33);
            label1.TabIndex = 0;
            label1.Text = "Введите название театра:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "Театр ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(380, 51);
            label3.Name = "label3";
            label3.Size = new Size(382, 28);
            label3.TabIndex = 3;
            label3.Text = "Введите художественного руководителя:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(470, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(292, 31);
            textBox2.TabIndex = 4;
            textBox2.Text = "Художественный руководитель:";
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(164, 33);
            label4.TabIndex = 5;
            label4.Text = "Введите адрес:";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(292, 31);
            textBox3.TabIndex = 6;
            textBox3.Text = "Адрес:";
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(515, 190);
            label5.Name = "label5";
            label5.Size = new Size(247, 28);
            label5.TabIndex = 7;
            label5.Text = "Введите рейтинг театра:";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Control;
            textBox4.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(470, 248);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(292, 31);
            textBox4.TabIndex = 8;
            textBox4.Text = "Рейтинг:";
            textBox4.TextChanged += textBox4_TextChanged_1;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Control;
            textBox5.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox5.Location = new Point(12, 349);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(750, 31);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 301);
            label2.Name = "label2";
            label2.Size = new Size(83, 36);
            label2.TabIndex = 10;
            label2.Text = "Итог:";
            // 
            // rjButton1
            // 
            rjButton1.BackColor = SystemColors.Control;
            rjButton1.BackgroundColor = SystemColors.Control;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(54, 403);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 13;
            rjButton1.Text = "Добавить";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = SystemColors.Control;
            rjButton2.BackgroundColor = SystemColors.Control;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(550, 403);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 40);
            rjButton2.TabIndex = 14;
            rjButton2.Text = "Отмена";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(794, 458);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCreate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private RJButton rjButton1;
        private RJButton rjButton2;
    }
}