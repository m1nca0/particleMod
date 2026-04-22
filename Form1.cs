namespace particleMod
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        RecolorPoint point1;
        GravityPoint point2;
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
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);
        }


        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                emitter.Render(g);
            }

            picDisplay.Invalidate();
        }

        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var emitter in emitters)
            {
                if(checkBox1.Checked == true)
                {
                    emitter.MousePositionX = e.X;
                    emitter.MousePositionY = e.Y;
                    point2.Power = 0;
                }
                else
                {
                    emitter.MousePositionX = picDisplay.Image.Width / 2;
                    emitter.MousePositionY = picDisplay.Image.Height / 2;
                }

            }

            point2.X = e.X;
            point2.Y = e.Y;
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
            point2.Power = tbGravityPoint2.Value;
        }
    }
}
