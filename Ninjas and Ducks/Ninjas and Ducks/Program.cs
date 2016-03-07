using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjas_and_Ducks
{
    class Program
    {
        public class Ninja : IAbility, ISpeak, IStats
        {

            private int m_health;
            private int m_attack;
            private string m_name;

            public int attack
            {
                get
                {
                    return m_attack;
                }

                set
                {
                    m_attack = value;
                }
            }

            public int health
            {
                get
                {
                    return m_health;
                }

                set
                {
                    m_health = value;
                }
            }

            public string name
            {
                get
                {
                    return m_name;
                }

                set
                {
                    m_name = value;
                }
            }

            public void Fight(IAbility b)
            {
                if (this.attack > b.health)
                {
                    this.SayName();
                }
                else
                {
                    b.SayName();
                }
            }

            public void SayName()
            {
                Console.WriteLine("My name is " + this.name + "!");
            }

            public Ninja(int a, int b, string c)
            {
                health = a;
                attack = b;
                name = c;
            }
        }

        public class Duck : IAbility, ISpeak, IStats
        {
            private int m_health;
            private int m_attack;
            private string m_name;

            public Duck(int a, int b, string c)
            {
                health = a;
                attack = b;
                name = c;
            }

            public int attack
            {
                get
                {
                    return m_attack;
                }

                set
                {
                    m_attack = value;
                }
            }

            public int health
            {
                get
                {
                    return m_health;
                }

                set
                {
                    m_health = value;
                }
            }

            public string name
            {
                get
                {
                    return m_name;
                }

                set
                {
                    m_name = value;
                }
            }

            public void Fight(IAbility b)
            {
                if (this.attack > b.health)
                {
                    this.SayName();
                }
                else
                {
                    b.SayName();
                }
            }

            public void SayName()
            {
                Console.WriteLine("My name is " + this.name + "!");
            }
        }

        static void Main(string[] args)
        {
            List<IAbility> warriors = new List<IAbility>();
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                Ninja ninja = new Ninja(rnd.Next(1, 500), rnd.Next(1, 500), "Ninja " + i);
                Duck duck = new Duck(rnd.Next(1, 500), rnd.Next(1, 500), "Duck " + i);
                warriors.Add(ninja);
                warriors.Add(duck);
            }

            int iter = 0;
            foreach (IAbility a in warriors)
            {
                iter += 1;
                if (iter == warriors.Count)
                {
                    iter -= 1;
                }
                a.Fight(warriors[iter]);
            }
            Console.ReadLine();
        }
    }
}
