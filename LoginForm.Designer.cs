namespace Teatr
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            rjButton2 = new RJButton();
            rjButton1 = new RJButton();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1331, 778);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(rjButton2);
            panel2.Controls.Add(rjButton1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(480, 223);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 323);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(60, 218);
            label2.Name = "label2";
            label2.Size = new Size(213, 21);
            label2.TabIndex = 9;
            label2.Text = "Неверный логин или пароль";
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Silver;
            rjButton2.BackgroundColor = Color.Silver;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 20;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(193, 263);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(92, 33);
            rjButton2.TabIndex = 8;
            rjButton2.Text = "Отмена";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Silver;
            rjButton1.BackgroundColor = Color.Silver;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 20;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(48, 263);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(97, 33);
            rjButton1.TabIndex = 7;
            rjButton1.Text = "Войти";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(129, 137);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 57);
            textBox2.TabIndex = 4;
            textBox2.Text = "Пароль";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(48, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 57);
            textBox1.TabIndex = 3;
            textBox1.Text = "Логин";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._9217728;
            pictureBox2.InitialImage = Properties.Resources._2321232;
            pictureBox2.Location = new Point(48, 137);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources._2321232;
            pictureBox1.Location = new Point(226, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(90, 14);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 778);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private RJButton rjButton1;
        private RJButton rjButton2;
        private Label label2;
    }
}