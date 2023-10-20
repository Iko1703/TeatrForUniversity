using System.Drawing.Drawing2D;

namespace Teatr
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button5 = new Button();
            rjButton1 = new RJButton();
            rjButton2 = new RJButton();
            listBox2 = new ListBox();
            rjButton3 = new RJButton();
            textBox1 = new TextBox();
            rjButton4 = new RJButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Help;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(1163, 12);
            button1.Name = "button1";
            button1.Size = new Size(170, 35);
            button1.TabIndex = 0;
            button1.Text = "Вывод театров";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Help;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(1163, 98);
            button2.Name = "button2";
            button2.Size = new Size(170, 31);
            button2.TabIndex = 1;
            button2.Text = "Добавить пьесу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Help;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(1110, 135);
            button3.Name = "button3";
            button3.Size = new Size(223, 35);
            button3.TabIndex = 2;
            button3.Text = "Удаление театра/пьесы";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MistyRose;
            listBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1092, 279);
            listBox1.TabIndex = 6;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Cursor = Cursors.Help;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(1163, 57);
            button5.Name = "button5";
            button5.Size = new Size(170, 35);
            button5.TabIndex = 8;
            button5.Text = "Добавить театр";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MistyRose;
            rjButton1.BackgroundColor = Color.MistyRose;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(12, 320);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(324, 33);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Театр с самым большим рейтингом";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.MistyRose;
            rjButton2.BackgroundColor = Color.MistyRose;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(12, 374);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(231, 33);
            rjButton2.TabIndex = 10;
            rjButton2.Text = "Сортировка по рейтингу";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.MistyRose;
            listBox2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(659, 301);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(199, 129);
            listBox2.TabIndex = 11;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.MistyRose;
            rjButton3.BackgroundColor = Color.MistyRose;
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 20;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.Black;
            rjButton3.Location = new Point(361, 320);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(184, 33);
            rjButton3.TabIndex = 12;
            rjButton3.Text = "Поиск по фамилии";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.MistyRose;
            textBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(361, 374);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 31);
            textBox1.TabIndex = 13;
            textBox1.Text = "Введите фамилию и нажмите Ок";
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.MistyRose;
            rjButton4.BackgroundColor = Color.MistyRose;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 20;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.Black;
            rjButton4.Location = new Point(551, 320);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(102, 33);
            rjButton4.TabIndex = 14;
            rjButton4.Text = "Ок";
            rjButton4.TextColor = Color.Black;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1237, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1295, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 39);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(1110, 301);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 129);
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1356, 435);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(rjButton4);
            Controls.Add(textBox1);
            Controls.Add(rjButton3);
            Controls.Add(listBox2);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Театр";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private CheckedListBox checkedListBox1;
        private ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button5;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private ListBox listBox2;
        private RJButton rjButton3;
        private TextBox textBox1;
        private RJButton rjButton4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}