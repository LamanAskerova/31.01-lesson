using System.Data;
using _31._01_lesson;

namespace Farm;

/*
add animal
show animal
add fermer
show fermer
add farm 
show farm
add account
*/

internal class Program
{
    static void Main(string[] args)
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        DataContext dataContext = new DataContext();
        string command;
        do
        {
            Console.WriteLine("Enter command");
            command = Console.ReadLine();
          
            switch (command.ToLower())
            {
                case "add animals":
                    dataContext.AddAnimal();
                    break;
                case "print animal":
                    dataContext.PrintAnimal();
                    break;
                case "print animals":
                    dataContext.PrintAnimals();
                    break;
            }
        } while (command != "exit") ;
        
    }
}
 