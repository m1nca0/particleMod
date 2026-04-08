namespace particleMod
{
    public partial class Form1 : Form
    {
        List<Particle> particles = new();
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);


        }

        private void UpdateState()
        {
            foreach (var particle in particles)
            {
                particle.Life -= 1;

                if (particle.Life < 0)
                {

                    particle.Life = 20 + Particle.rand.Next(100);

                    particle.Direction = Particle.rand.Next(360);
                    particle.Speed = 1 + Particle.rand.Next(10);
                    particle.Radius = 2 + Particle.rand.Next(10);

                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                }
                else
                {

                    var directionInRadians = particle.Direction / 180 * Math.PI;
                    particle.X += (float)(particle.Speed * Math.Cos(directionInRadians));
                    particle.Y -= (float)(particle.Speed * Math.Sin(directionInRadians));
                }
            }

            for (var i = 0; i < 10; i++)
            {
                if (particles.Count < 500)
                {
                    
                    var particle = new ParticleColorful();
                    
                    particle.FromColor = Color.Yellow;
                    particle.ToColor = Color.FromArgb(0, Color.Magenta);
                    particle.X = MousePositionX;
                    particle.Y = MousePositionY;
                    particles.Add(particle);
                }
                else break;
            }
        }

        private void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
        }

        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateState();

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                Render(g);
            }

            picDisplay.Invalidate();
        }

        private int MousePositionX = 0;
        private int MousePositionY = 0;
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            MousePositionX = e.X;
            MousePositionY = e.Y;
        }
    }
}
