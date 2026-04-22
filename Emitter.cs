using System;
using System.Collections.Generic;
using System.Text;

namespace particleMod
{
    public class Emitter
    {
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();

        List<ParticleColorful> particles = new List<ParticleColorful>();

        public int ParticlesCount = 500;
        public int MousePositionX;
        public int MousePositionY;

        public float GravitationX = 1;
        public float GravitationY = 1;


        public int X;
        public int Y;
        public int Direction = 0;
        public int Spreading = 360;
        public int SpeedMin = 1;
        public int SpeedMax = 10;
        public int RadiusMin = 2;
        public int RadiusMax = 10;
        public int LifeMin = 20;
        public int LifeMax = 100;

        public int ParticlesPerTick = 1;

        public Color ColorFrom = Color.White;
        public Color ColorTo = Color.FromArgb(0, Color.Black);
        public virtual ParticleColorful CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }
        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;
            foreach (var particle in particles)
            {
                if (particle.Life < 0) 
                {
                    //if (particlesToCreate > 0)
                    //{
                    //    particlesToCreate -= 1; 
                        ResetParticle(particle);
                    //}
                }
                else
                {
                    particle.X += particle.SpeedX;
                    particle.Y += particle.SpeedY;

                    particle.Life -= 1;
                    foreach (var point in impactPoints)
                    {
                        point.ImpactParticle(particle);
                    }

                    particle.SpeedX += GravitationX;
                    particle.SpeedY += GravitationY;
                }
            }

            while (particlesToCreate >= 1)
            {
                particlesToCreate -= 1;
                var particle = CreateParticle();
                ResetParticle((ParticleColorful)particle);
                particles.Add((ParticleColorful)particle);
            }
        }

        public void Render(Graphics g)
        {
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
            foreach (var point in impactPoints)
            {
                point.Render(g);
            }
        }
        public virtual void ResetParticle(ParticleColorful particle)
        {
            particle.Life = ParticleColorful.rand.Next(LifeMin, LifeMax);
            particle.FromColor = Color.White;
            particle.ToColor = Color.White;

            particle.X = MousePositionX;
            particle.Y = MousePositionY;

            var direction = Direction
                + (double)ParticleColorful.rand.Next(Spreading)
                - Spreading / 2;

            var speed = ParticleColorful.rand.Next(SpeedMin, SpeedMax);

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = ParticleColorful.rand.Next(RadiusMin, RadiusMax);
        }
    }
    public class TopEmitter : Emitter
    {
        public int Width;

        public override void ResetParticle(ParticleColorful particle)
        {
            base.ResetParticle(particle);

           
            particle.X = ParticleColorful.rand.Next(Width);
            particle.Y = 0; 

            particle.SpeedY = 1;
            particle.SpeedX = ParticleColorful.rand.Next(-2, 2);
        }
    }
}
