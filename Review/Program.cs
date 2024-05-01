using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":D");
        }
    }

    enum Colours
    {
        White,  
        Black,
        Grey
    }
    enum AnimalType
    {
        Crocodile,
        Lizard
    }
    abstract class Animal
    {
        //Data
        protected int Age { get; set; }
        protected Colours SkinColour { get; set; }
        protected int Calories { get; set; }

        public Animal(int Age, Colours SkinColour, int Calories)
        {
            this.Age = Age; 
            this.SkinColour = SkinColour;   
            this.Calories = Calories;
        }

        //Behaviour
        protected void Sleep(int hours)
        {
            Calories += hours * 20;
        }
        protected void Eat(int calories)
        {
            Calories += calories;
        }

        protected abstract void Talk();
    }
    interface ISwim
    {
        void Swim();
    }
    interface IWalk
    {
        void Walk();
    }
    class Dog : Animal, IWalk
    {
        //Data
        public int Speed { get; set; }

        public Dog(int Age, Colours SkinColour, int Calories, int Speed) : base(Age, SkinColour, Calories)
        {
            this.Speed = Speed;
        }

        //Behaviour
        protected override void Talk()
        {
            Console.WriteLine("Woof");
        }

        public int Walk(int hours)
        {
            Calories = Calories - (hours * Speed) / 2;
            return Calories;
        }
        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
    class Reptile : Animal, IWalk, ISwim
    {
        //Data
        AnimalType Type {  get; set; }

        public Reptile(int Age, Colours SkinColour, int Calories, AnimalType Type) : base(Age, SkinColour, Calories)
        {
            this.Type = Type;
        }
        //Behaviour
        protected override void Talk()
        {
            Console.WriteLine("Ssrr");
        }

        public int Walk(int hours)
        {
            if(Type == AnimalType.Crocodile)
            {
                Calories = Calories - hours * 15;
            }
            else if(Type == AnimalType.Lizard)
            {
                Calories = Calories - hours * 10;
            }
            return Calories;
        }

        public int Swim(int hours) 
        {
            Calories -= hours * 10;

            if (Type == AnimalType.Crocodile)
            {
                 Calories = Calories - hours * 10;
            }
            else if (Type == AnimalType.Lizard)
            {
                 Calories = Calories - hours * 5;
            }
            return Calories;
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
    class Fish : Animal, ISwim
    {
        //Data
        int Size { get; set; }
        public Fish(int Age, Colours SkinColour, int Calories, int Size) : base(Age, SkinColour, Calories)
        {
            this.Size = Size;
        }
        //Behaviour
        protected override void Talk()
        {
            Console.WriteLine("...");
        }

        public void Swim(int hours)
        {
            Calories -= hours * Size;
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }

}
