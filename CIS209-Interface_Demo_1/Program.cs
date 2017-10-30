using System;

namespace CIS209_Interface_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thing[] things = new Thing[] { new Chicken(), new Tiger(),
                                           new Orange(), new Apple() };

            foreach (Thing each in things)
            {
                if (each is Edible)
                    Console.WriteLine(each.howToEat());

                if (each is Animal)
                    Console.WriteLine(each.sound());
            }
        }
    }

    abstract class Thing  // parent class for Animal and Fruit
    {
        public abstract string howToEat();

        public abstract string sound();
    }

    interface Edible
    {
        string howToEat();
    }

    abstract class Fruit : Thing, Edible
    {
        public override string sound()  // fruits don't make sounds
        {
            throw new NotImplementedException();
        }
    }

    class Apple : Fruit
    {
        public override string howToEat()
        {
            return "Apple: Make apple cider";
        }
    }

    class Orange : Fruit
    {
        public override string howToEat()
        {
            return "Orange: Make orange juice";
        }
    }

    abstract class Animal : Thing  // not all animal are edible
    {
        public override abstract string sound();
    }

    class Tiger : Animal
    {
        public override string sound()
        {
            return "Tiger: RRRROOOAAARR";
        }

        public override string howToEat()
        {
            // Don't implement howToEat for a tiger
            throw new NotImplementedException();
        }
    }

    class Chicken : Animal, Edible
    {
        public override string howToEat()
        {
            return "Chicken: fry it";
        }

        public override string sound()
        {
            return "Chicken: cock-a-doodle-doo";
        }
    }
}
