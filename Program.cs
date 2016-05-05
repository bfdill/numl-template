using System;
using numl.Model;
using numl.Supervised.DecisionTree;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var description = Descriptor.Create<Iris>();
            var data = Iris.Load();
            var generator = new DecisionTreeGenerator();
            var model = generator.Generate(description, data);
            Console.WriteLine("Generated model: ");
            Console.WriteLine(model);
        }
    }
}
