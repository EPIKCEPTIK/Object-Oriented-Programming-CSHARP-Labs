using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Projectile
    {
        public double damage;
        public double accurace;
        public abstract void HitTarget(IDamageabe target);
    }
    public class Bullet : Projectile
    {
        new double damage = 20;
        new int accurace = 5;

        public override void HitTarget(IDamageabe target) {
            
            Random rnd = new Random();
            double random = rnd.Next(accurace, 10) / 10.0;
            double damageAccurace = damage * random;
            Console.WriteLine($"Нанесено {damageAccurace} урону");
            target.TakeDamage(damageAccurace);
        }
    }
    public class Rocket : Projectile
    {
        new double damage = 100;
        new int accurace = 8;
        public override void HitTarget(IDamageabe target)
        {
            
            Random rnd = new Random();
            double random = rnd.Next(accurace, 10)/10.0;
            double damageAccurace = damage * random;
            Console.WriteLine($"Нанесено {damageAccurace} урону");
            target.TakeDamage(damageAccurace);
        }
    }
}
