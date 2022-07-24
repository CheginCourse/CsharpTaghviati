using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Dog
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private int health;
        public int Health
        {
            get { return health; }
            set
            {
                health = value;
                OnHealthChanged?.Invoke(this, this.Health);
            }
        }
        public event EventHandler<int> OnHealthChanged;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog objDog = new Dog
            {
                ID = 31,
                Name = "bunny",
                Health = 300
            };
            objDog.Health = 200;
            objDog.OnHealthChanged += OnEventFuction;

            for (int i = 0; i < 10; i++)
            {
                objDog.Health -= 20;
            }

            Console.WriteLine("Hello World!");
        }

        public static void OnEventFuction(object sender, int e)
        {
            var dog = (Dog)sender;

            System.Console.WriteLine($"{dog.Name} is barking  {dog.Health}");
        }

        public static void OnDie(object sender, int e)
        {
            var dog = (Dog)sender;

            if (dog.Health < 1)
            {
                System.Console.WriteLine($"{dog.Name} is dying {dog.Health}");
            }
        }
    }
}
