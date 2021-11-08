using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCls
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            //cat.ShowInfo();
            cat.Name = "Кошка";
            cat.ShowInfo();
            Dog dog = new Dog();
            //dog.ShowInfo();
            dog.Name = "Собака";
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name = "Животное")
        {
            Name = name;
        }
        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} говорит: {Say()}");
        }
    }
    public class Cat : Animal
    {
        public string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "\"Мяу?\"";
        }

    }
    public class Dog : Animal
    {
        public string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public override string Say()
        {
            return "\"Гав!\"";
        }
    }
}
