using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Enemy : IDamageabe
    {
        public double hp = 100;
    
        public void TakeDamage(double damage) { 
            hp -= damage;
            if (hp <= 0)
            {
                Console.WriteLine("Ворог переможений");
                hp = 100;
            }
            else
            {
                Console.WriteLine($"Залишилось {hp} здоров'я ворога");
            }
        }
        
    }
    public class BreakableWall : IDamageabe
    {
        public double hp = 500;
       
        public void TakeDamage(double damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                Console.WriteLine("Стінка зруйнована");
                hp = 500;
            }
            else
            { Console.WriteLine($"Залишилось {hp} здоров'я стінки"); }
        }
    }
    public class ArmoredEnemy : IDamageabe
    {
        public double hp = 100;
        public double protection = 0.5;
        public void TakeDamage(double damage)
        {
            hp -= damage*protection;
            if (hp <= 0)
            {
                Console.WriteLine("Ворог переможений");
                hp = 100;
            }
            else
            {
                Console.WriteLine($"Залишилось {hp} здоров'я ворога");
            }
        }

    }
}
