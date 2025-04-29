using RepositoryPatternCarApp.RepositoryPattern;
using RepositoryPatternCarApp.Classes;
using RepositoryPatternCarApp.RepositoryPattern.Repositories;
using RepositoryPatternCarApp.RepositoryPattern.Interfaces;

namespace RepositoryPatternCarApp

{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            ICarRepo CarRepo = new FileCarRepo("Cars.txt");

            Console.WriteLine("HEJ");
            
            Console.ReadLine();
        }
    }
}
