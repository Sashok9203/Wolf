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
            resources.ApplyResources(wolf, "wolf");
            wolf.Name = "wolf";
            wolf.TabStop = false;
            // 
            // chicken1
            // 
            chicken1.BackColor = Color.Transparent;
            chicken1.Image = Properties.Resources.chicken;
            resources.ApplyResources(chicken1, "chicken1");
            chicken1.Name = "chicken1";
            chicken1.TabStop = false;
            // 
            // chicken2
            // 
            chicken2.BackColor = Color.Transparent;
            chicken2.Image = Properties.Resources.chicken;
            resources.ApplyResources(chicken2, "chicken2");
            chicken2.Name = "chicken2";
            chicken2.TabStop = false;
            // 
            // chicken3
            // 
            chicken3.BackColor = Color.Transparent;
            chicken3.Image = Properties.Resources.chicken;
            resources.ApplyResources(chicken3, "chicken3");
            chicken3.Name = "chicken3";
            chicken3.TabStop = false;
            // 
            // chicken4
            // 
            chicken4.BackColor = Color.Transparent;
            chicken4.Image = Properties.Resources.chicken;
            resources.ApplyResources(chicken4, "chicken4");
            chicken4.Name = "chicken4";
            chicken4.TabStop = false;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Transparent;
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            startButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            resources.ApplyResources(startButton, "startButton");
            startButton.ForeColor = Color.FromArgb(255, 255, 128);
            startButton.Name = "startButton";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // catched_eggs
            // 
            resources.ApplyResources(catched_eggs, "catched_eggs");
            catched_eggs.BackColor = Color.Transparent;
            catched_eggs.ForeColor = Color.Yellow;
            catched_eggs.Name = "catched_eggs";
            // 
            // not_catched_eggs
            // 
            resources.ApplyResources(not_catched_eggs, "not_catched_eggs");
            not_catched_eggs.BackColor = Color.Transparent;
            not_catched_eggs.ForeColor = Color.SkyBlue;
            not_catched_eggs.Name = "not_catched_eggs";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Фон_для_Ну_Погоди;
            Controls.Add(not_catched_eggs);
            Controls.Add(catched_eggs);
            Controls.Add(startButton);
            Controls.Add(chicken4);
            Controls.Add(chicken3);
            Controls.Add(chicken2);
            Controls.Add(chicken1);
            Controls.Add(wolf);
            DoubleBuffered = true;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
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