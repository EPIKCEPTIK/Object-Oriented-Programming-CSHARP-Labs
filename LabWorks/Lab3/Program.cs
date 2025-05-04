using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main()
        {

            Bullet bullet = new Bullet();
            Enemy enemy = new Enemy();
            Rocket rocket = new Rocket();
            BreakableWall wall = new BreakableWall();
            ArmoredEnemy armoredEnemy = new ArmoredEnemy();
            bullet.HitTarget(wall);
            bullet.HitTarget(enemy);
            rocket.HitTarget(armoredEnemy);
        }
    }
}

