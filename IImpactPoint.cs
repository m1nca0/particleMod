using System;
using System.Collections.Generic;
using System.Text;

namespace particleMod
{
    public abstract class IImpactPoint
    {
        public float X;
        public float Y;

        public abstract void ImpactParticle(ParticleColorful particle);

        public virtual void Render(Graphics g)
        {
            g.FillEllipse(
                    new SolidBrush(Color.Red),
                    X - 5,
                    Y - 5,
                    10,
                    10
                );
        }
    }
    public class GravityPoint : IImpactPoint
    {
        public int Power = 100;

        public override void ImpactParticle(ParticleColorful particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;

            double r = Math.Sqrt(gX * gX + gY * gY);
            if (r + particle.Radius < Power / 2)
            {
               
                float r2 = (float)Math.Max(100, gX * gX + gY * gY);
                particle.SpeedX += gX * Power / r2;
                particle.SpeedY += gY * Power / r2;
            }
        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }
    public class AntiGravityPoint : IImpactPoint
    {
        public int Power = 100;

       
        public override void ImpactParticle(ParticleColorful particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);
            particle.SpeedX -= (float)(gX * Power / r2);
            particle.SpeedY -= (float)(gY * Power / r2);

        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Power / 2,
                   Y - Power / 2,
                   Power,
                   Power
               );
        }
    }
    public class RecolorPoint : IImpactPoint 
    {
        public int Radius = 100;
        public override void ImpactParticle(ParticleColorful particle)
        {
            float gX = X - particle.X;
            float gY = Y - particle.Y;
            float r2 = (float)Math.Max(100, gX * gX + gY * gY);

            if ( gX < Radius && gY < Radius )
            {
                particle.FromColor = Color.Red;
                particle.ToColor = Color.Red;
            }

        }
        public override void Render(Graphics g)
        {
            g.DrawEllipse(
                   new Pen(Color.Red),
                   X - Radius / 2,
                   Y - Radius / 2,
                   Radius,
                   Radius
               );
        }
    }
}
