using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Tom = new Player();

            Tom.Level = 10;
            Console.WriteLine($"Toms level is : Lv.{Tom.Level}");

            Console.WriteLine($"Tom health is : {Tom.health}");

            Tom.health -= 37;
            Console.WriteLine($"Tom took damage by 37, Health = {Tom.health}");

        }
    }

    class Player
    {
        public int Level { get; set; }

        private int _health = 100;
        public int health
        {
            get
            {
                return _health;
            }

            set
            {
                if (value <= 0)
                {
                    _health = 0;

                }
                else if (value >= 100)
                {
                    _health = 100;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public void Damage(int _dmg)
        {
            _health -= _dmg;
        }
    }
}

//public string Make { get;} Read only property
