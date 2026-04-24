namespace particleMod
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        RecolorPoint point1;
        RecolorPoint point2;
        RecolorPoint point3;
        RecolorPoint point4;
        GravityPoint gravityPoint;

        int speedRotation;
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };

            emitters.Add(this.emitter);

            point1 = new RecolorPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
                FromColor = Color.Red,
                ToColor = Color.Red
            };
            point2 = new RecolorPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
                FromColor = Color.Blue,
                ToColor = Color.Blue
            };
            point3 = new RecolorPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 + 100,
                FromColor = Color.Green,
                ToColor = Color.Green
            };
            point4 = new RecolorPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2 - 100,
                FromColor = Color.Purple,
                ToColor = Color.Purple
            };
            gravityPoint = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
            emitter.impactPoints.Add(point3);
            emitter.impactPoints.Add(point4);
            emitter.impactPoints.Add(gravityPoint);
        }


        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();


            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.White);
                emitter.Render(g);
            }
            if (checkBox2.Checked == true)
            {
                if (emitter.Direction < 340)
                {
                    emitter.Direction += speedRotation;
                    tbDirection.Value = emitter.Direction;
                }
                else { emitter.Direction = 0; }
            }
            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                if (checkBox1.Checked == true)
                {
                    emitter.MousePositionX = e.X;
                    emitter.MousePositionY = e.Y;
                    gravityPoint.Power = 0;
                }
                else
                {
                    emitter.MousePositionX = picDisplay.Image.Width / 2;
                    emitter.MousePositionY = picDisplay.Image.Height / 2;
                }
            }

            gravityPoint.X = e.X;
            gravityPoint.Y = e.Y;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            txtDirection.Text = $"{tbDirection.Value}°";

        }

        private void tbGravity_Scroll(object sender, EventArgs e)
        {
            emitter.GravitationX = tbGravity.Value / 10;
            emitter.GravitationY = tbGravity.Value / 10;
            txtGravity.Text = $"{tbGravity.Value / 10}";
        }

        private void tbGravityPoint_Scroll(object sender, EventArgs e)
        {
            point1.Radius = tbGravityPoint.Value;

        }

        private void tbGravityPoint2_Scroll(object sender, EventArgs e)
        {
            gravityPoint.Power = tbGravityPoint2.Value;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbSpeedRotation_Scroll(object sender, EventArgs e)
        {
            speedRotation = tbSpeedRotation.Value;
            txtSpeedRotation.Text = speedRotation.ToString();
        }

        private void tbSize_Scroll(object sender, EventArgs e)
        {
            emitter.Size = tbSize.Value;
            txtSize.Text = tbSize.Value.ToString();
        }
    }
}
