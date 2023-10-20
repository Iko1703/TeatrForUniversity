namespace Teatr
{
    partial class FormPes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPes));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            rjButton1 = new RJButton();
            rjButton2 = new RJButton();
            listBox1 = new ListBox();
            rjButton3 = new RJButton();
            label3 = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 49);
            label1.TabIndex = 0;
            label1.Text = "Введите название пьесы";
            // 
            // label2
            // 
            label2.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(276, 49);
            label2.TabIndex = 1;
            label2.Text = "Введите время начала";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(322, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "Пьеса \"лала\"";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(322, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 38);
            textBox2.TabIndex = 3;
            textBox2.Text = "12:00";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            rjButton1.Location = new Point(438, 156);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(110, 30);
            rjButton1.TabIndex = 4;
            rjButton1.Text = "Добавить ";
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
            rjButton2.Location = new Point(443, 255);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(105, 30);
            rjButton2.TabIndex = 5;
            rjButton2.Text = "Закрыть";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(17, 156);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 129);
            listBox1.TabIndex = 6;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = SystemColors.Control;
            rjButton3.BackgroundColor = SystemColors.Control;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 20;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.Black;
            rjButton3.Location = new Point(438, 207);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(110, 30);
            rjButton3.TabIndex = 7;
            rjButton3.Text = "Удалить";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(571, 9);
            label3.Name = "label3";
            label3.Size = new Size(285, 49);
            label3.TabIndex = 8;
            label3.Text = "Выберите театр:";
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Control;
            listBox2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(567, 83);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(285, 204);
            listBox2.TabIndex = 9;
            // 
            // FormPes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(868, 303);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(rjButton3);
            Controls.Add(listBox1);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPes";
            Text = "FormPes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private ListBox listBox1;
        private RJButton rjButton3;
        private Label label3;
        private ListBox listBox2;
    }
}