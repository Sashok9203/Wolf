namespace Wolf
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
            wolf = new PictureBox();
            chicken1 = new PictureBox();
            chicken2 = new PictureBox();
            chicken3 = new PictureBox();
            chicken4 = new PictureBox();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            catched_eggs = new Label();
            not_catched_eggs = new Label();
            ((System.ComponentModel.ISupportInitialize)wolf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chicken4).BeginInit();
            SuspendLayout();
            // 
            // wolf
            // 
            wolf.BackColor = Color.Transparent;
            wolf.Image = Properties.Resources.wolf_down;
            wolf.Location = new Point(94, 111);
            wolf.Name = "wolf";
            wolf.Size = new Size(258, 286);
            wolf.SizeMode = PictureBoxSizeMode.StretchImage;
            wolf.TabIndex = 0;
            wolf.TabStop = false;
            // 
            // chicken1
            // 
            chicken1.BackColor = Color.Transparent;
            chicken1.Image = Properties.Resources.chicken;
            chicken1.Location = new Point(-11, 57);
            chicken1.Name = "chicken1";
            chicken1.Size = new Size(76, 73);
            chicken1.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken1.TabIndex = 1;
            chicken1.TabStop = false;
            // 
            // chicken2
            // 
            chicken2.BackColor = Color.Transparent;
            chicken2.Image = Properties.Resources.chicken;
            chicken2.Location = new Point(-11, 174);
            chicken2.Name = "chicken2";
            chicken2.Size = new Size(76, 73);
            chicken2.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken2.TabIndex = 2;
            chicken2.TabStop = false;
            // 
            // chicken3
            // 
            chicken3.BackColor = Color.Transparent;
            chicken3.Image = Properties.Resources.chicken;
            chicken3.Location = new Point(379, 57);
            chicken3.Name = "chicken3";
            chicken3.Size = new Size(76, 73);
            chicken3.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken3.TabIndex = 3;
            chicken3.TabStop = false;
            // 
            // chicken4
            // 
            chicken4.BackColor = Color.Transparent;
            chicken4.Image = Properties.Resources.chicken;
            chicken4.Location = new Point(379, 174);
            chicken4.Name = "chicken4";
            chicken4.Size = new Size(76, 73);
            chicken4.SizeMode = PictureBoxSizeMode.StretchImage;
            chicken4.TabIndex = 4;
            chicken4.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            startButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            startButton.FlatStyle = FlatStyle.Popup;
            startButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.FromArgb(255, 255, 128);
            startButton.Location = new Point(170, 28);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 32);
            startButton.TabIndex = 5;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // catched_eggs
            // 
            catched_eggs.AutoSize = true;
            catched_eggs.BackColor = Color.Transparent;
            catched_eggs.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            catched_eggs.ForeColor = Color.Yellow;
            catched_eggs.Location = new Point(131, 9);
            catched_eggs.Name = "catched_eggs";
            catched_eggs.Size = new Size(47, 25);
            catched_eggs.TabIndex = 6;
            catched_eggs.Text = "text";
            // 
            // not_catched_eggs
            // 
            not_catched_eggs.AutoSize = true;
            not_catched_eggs.BackColor = Color.Transparent;
            not_catched_eggs.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            not_catched_eggs.ForeColor = Color.SkyBlue;
            not_catched_eggs.Location = new Point(131, 45);
            not_catched_eggs.Name = "not_catched_eggs";
            not_catched_eggs.Size = new Size(47, 25);
            not_catched_eggs.TabIndex = 7;
            not_catched_eggs.Text = "text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Фон_для_Ну_Погоди;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(440, 398);
            Controls.Add(not_catched_eggs);
            Controls.Add(catched_eggs);
            Controls.Add(startButton);
            Controls.Add(chicken4);
            Controls.Add(chicken3);
            Controls.Add(chicken2);
            Controls.Add(chicken1);
            Controls.Add(wolf);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ну постривай ! ! !";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)wolf).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken3).EndInit();
            ((System.ComponentModel.ISupportInitialize)chicken4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox wolf;
        private PictureBox chicken1;
        private PictureBox chicken2;
        private PictureBox chicken3;
        private PictureBox chicken4;
        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private Label catched_eggs;
        private Label not_catched_eggs;
    }
}