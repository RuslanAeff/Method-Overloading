using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Person 
    {

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }


        public Person(string name, string surname, int age, double weight, double height)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Weight = weight;
            Height = height;    
       
        }
        public override string ToString()
        {
            return $"Name:{Name} Surname: {Surname} Age:{Age} Weight:{Weight} Height:{Height}";
            
        }
        
    }
    internal class Program
    {
        


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("PLease enter age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter weight:");
            double weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter height:");
            int height = int.Parse(Console.ReadLine());


            var person = new Person(name,surname,age,weight, height );
            

            Console.WriteLine(person.ToString());
        }
    }
}
