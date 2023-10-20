namespace Teatr
{
    partial class Formdelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formdelete));
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            rjButton1 = new RJButton();
            rjButton2 = new RJButton();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(517, 304);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = SystemColors.Control;
            listBox2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(548, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(394, 304);
            listBox2.TabIndex = 1;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(17, 397);
            label1.Name = "label1";
            label1.Size = new Size(384, 28);
            label1.TabIndex = 2;
            label1.Text = "Выберите театр или пьесу для удаления ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(17, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(925, 34);
            textBox1.TabIndex = 3;
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
            rjButton1.Location = new Point(507, 397);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(137, 33);
            rjButton1.TabIndex = 4;
            rjButton1.Text = "Удалить";
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
            rjButton2.Location = new Point(706, 397);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(137, 33);
            rjButton2.TabIndex = 5;
            rjButton2.Text = "Отмена";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // Formdelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(968, 465);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Formdelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private Label label1;
        private TextBox textBox1;
        private RJButton rjButton1;
        private RJButton rjButton2;
    }
}