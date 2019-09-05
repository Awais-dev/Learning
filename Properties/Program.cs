using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Tom = new Player();
            Console.WriteLine($"Tom health is : {Tom.health}");
            Tom.health -= 37;
            Console.WriteLine($"Tom took damage by : {Tom.health}");
            Tom.health = 45;
            Console.WriteLine($"Tom health is now : {Tom.health}");

        }
    }

    class Player
    {
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


