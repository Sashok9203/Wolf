using System.Media;
using Wolf.Properties;

namespace Wolf
{
    public partial class Form1 : Form
    {
        private bool left = false, right = true, up = false, down = true, start = false;
        private List<Egg> eggs = new List<Egg>();
        private SoundPlayer sp;
        private int count = 100,
                    eggsCount = 8,
                    broken = 0,
                    catched = 0;

        public Form1()
        {
            InitializeComponent();
            chicken3.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            chicken4.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            catched_eggs.Visible = false;
            not_catched_eggs.Visible = false;
            sp = new (Resources.sound);
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            start = true;
            timer1.Enabled = true;
            timer1.Interval = 70;
            timer1.Start();
            catched_eggs.Visible = true;
            not_catched_eggs.Visible = true;
            catched_eggs.Text = $"Спіймано : {catched}";
            not_catched_eggs.Text = $"Розбито    : {broken}";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (start)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        if (!down)
                        {
                            down = true;
                            up = false;
                            wolf.Image = Resources.wolf_down;
                            if (left) wolf.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        break;

                    case Keys.Up:
                        if (!up)
                        {
                            down = false;
                            up = true;
                            wolf.Image = Resources.wolf_up;
                            if (left) wolf.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        break;

                    case Keys.Left:
                        if (!left)
                        {
                            left = true;
                            right = false;
                            wolf.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        break;

                    case Keys.Right:
                        if (!right)
                        {
                            left = false;
                            right = true;
                            wolf.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        }
                        break;
                    case Keys.Escape:
                        timer1.Stop();
                        var res =  MessageBox.Show("Бажаєте закінчити ?","Вихід",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes) Close();
                        timer1.Start();
                        break;
                }

                wolf.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (eggs.Count < eggsCount)
            {
                count++;
                if (count >= 100)
                {
                    eggs.Add(new Egg(this, () => not_catched_eggs.Text = $"Розбито    : {++broken}"));
                    count = 0;
                }
            }

            foreach (var val in eggs)
            {
                if (!val.Move()) val.Refrash();
                else if (val.XMove > 65 && val.XMove < 75)
                {
                    if ((val.StartLocation == Egg.Location.LeftDown && left && down)
                        || (val.StartLocation == Egg.Location.LeftUp && left && up)
                        || (val.StartLocation == Egg.Location.RightUp && right && up)
                        || (val.StartLocation == Egg.Location.RightDown && right && down))
                    {
                        sp.PlaySync();
                        catched_eggs.Text = $"Спіймано : {++catched}";
                        val.Dispose();
                        val.Refrash();

                    }
                }
            }



        }
    }
}