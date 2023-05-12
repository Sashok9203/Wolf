using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolf
{
    internal class Egg : IDisposable
    {
        public enum Location
        {
            RightUp,
            LeftUp,
            RightDown,
            LeftDown
        }
        private PictureBox egg;
        private const int flour = 360;
        private const int wait = 100;
        private const int maxRefTime = 100;
        private int refTime;
        private bool disposed = false, refrash;
        private int xShift, yShift, count;
        private Point startPos;
        private Action broken_increment;
        private Point[] startPoss = { new Point(358, 111), new Point(46, 111), new Point(358, 223), new Point(46, 223) };
        public Egg(Form form, Action broken_increment)
        {
            egg = new()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.Transparent,
                BackgroundImageLayout = ImageLayout.Zoom,

                Location = startPos,
                Size = new Size(29, 35),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 6,
                TabStop = false,
            };
            form.Controls.Add(egg);
            egg.BringToFront();
            Refrash();
            refrash = false;
            this.broken_increment = broken_increment;
        }

        public bool Move()
        {
            if (refrash)
            {
                count++;
                if (count < refTime) return true;
                else
                {
                    count = 0;
                    refrash = false;
                    egg.Show();
                }
            }
            if (!disposed)
            {
                if (egg.Location.Y < flour)
                {
                    if (XMove >= 58)
                    {
                        xShift = 2;
                        yShift = 5;
                    }
                    egg.Location = new Point((StartLocation == Location.RightDown || StartLocation == Location.RightUp ? egg.Location.X - xShift : egg.Location.X + xShift), egg.Location.Y + yShift);
                    egg.Refresh();
                }
                else
                {
                    if (count == 0)
                    {
                        egg.Image = Properties.Resources.broken_egg;
                        egg.Refresh();
                        broken_increment.Invoke();
                        count++;
                    }
                    else
                    {
                        count++;
                        if (count >= wait)
                        {
                            Dispose();
                            return false;
                        }

                    }
                }
                return true;
            }
            else return false;
        }

        public int XMove => (Math.Abs(egg.Location.X - startPos.X));

        public Location StartLocation { get;private set;}

        public void Refrash()
        {
            egg.Image = Properties.Resources.egg;
            StartLocation = (Location) new Random().Next(0, 4);
            startPos = startPoss[(int)StartLocation];
            egg.Location = startPos;
            disposed = false;
            xShift = 5;
            yShift = 2;
            count = 0;
            refrash = true;
            refTime = new Random().Next(50, maxRefTime);
        }

        public void Dispose()
        {
            egg.Hide();
           
            disposed = true;
        }
    }
}
