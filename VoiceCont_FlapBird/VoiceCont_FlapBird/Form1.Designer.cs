namespace VoiceCont_FlapBird
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            progressBar1 = new ProgressBar();
            button1 = new Button();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            bird = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)bird).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 7);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(345, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(502, 7);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 1;
            button1.Text = "Start Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(365, 7);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // bird
            // 
            bird.Image = (Image)resources.GetObject("bird.Image");
            bird.Location = new Point(34, 244);
            bird.Name = "bird";
            bird.Size = new Size(34, 24);
            bird.SizeMode = PictureBoxSizeMode.AutoSize;
            bird.TabIndex = 3;
            bird.TabStop = false;
            bird.Click += pictureBox1_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources.background_day;
            ClientSize = new Size(750, 473);
            Controls.Add(bird);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox bird;
        private System.Windows.Forms.Timer timer2;
    }
}