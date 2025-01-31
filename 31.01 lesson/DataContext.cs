namespace _31._01_lesson;

internal class DataContext
{
    public Animal[] Animals { get; set; } = new Animal[100];
    public Farmer[] Farmers { get; set; } = new Farmer[100];
    public Farm[] Farms { get; set; } = new Farm[100];

    private int _animalIndex = 0;
    private int _farmerIndex = 0;
    private int _farmIndex = 0;

    #region  Animals

    public void AddAnimal()
    {
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Write("Enter name of animal : ");
        string name = Console.ReadLine();
        Console.Write("Enter Farm name : ");
        string Farm = Console.ReadLine();

        var animals = new Animal(name, _animalIndex, Farm);
        Animals[_animalIndex++] = animals;
    }

    public void PrintAnimal()
    {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.Write("Enter the animal id:");
        string idInString = Console.ReadLine();

        Console.WriteLine(new string('-', 45));

        if (!int.TryParse(idInString, out int id) || !(id >= 0 && id < _animalIndex))
        {
            Console.WriteLine("Not found");
            return;
        }

        Console.WriteLine($"{"Name",-20}{"Id",-20}{"Farm",-5}");

        var animal = Animals[id];
        Console.WriteLine($"{animal.Name,-20}{animal.Id,-20}{animal.Farm,-5}");
        Console.WriteLine(new string('-', 45));
    }

    public void PrintAnimals()
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(new string('-', 55));
        Console.WriteLine($"{"Name",-20}{"Id",-20}{"Farm",-5}");

        for (int i = 0; i < _animalIndex; i++)
        {
            var animal = Animals[i];

            if (animal == null) continue;

            Console.WriteLine($"{animal.Name,-20}{animal.Id,-20}{animal.Farm,-5}");
        }
        Console.WriteLine(new string('-', 55));

    }

    public void PrintAnimals(Animal[] animals)
    {
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{"Name",-20}{"Id",-20}{"Farm",-5}");
        foreach (var animal in animals)
        {
            if (animal == null) continue;

            Console.WriteLine($"{animal.Name,-20}{animal.Id,-20}{animal.Farm,-5}");
            Console.WriteLine(new string('-', 70));
        }
    }
    #endregion

    public void AddFarmer()
    {
        Console.Write("Firstname:");
        string firstName = Console.ReadLine();
        Console.Write("Lastname:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Subject:");
        string subject = Console.ReadLine();

        var farmer  = new Teacher(firstName, lastName, age, subject, _teacherIndex);
        Teachers[_teacherIndex++] = teacher;
    }

    public void PrintTeachers()
    {
        Console.WriteLine(new string('-', 65));
        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}{"Subject",-20}");

        for (int i = 0; i < _teacherIndex; i++)
        {
            var teacher = Teachers[i];
            Console.WriteLine($"{teacher.FirstName,-20}{teacher.LastName,-20}{teacher.Age,-5}{teacher.Subject,-20}");
        }
        Console.WriteLine(new string('-', 65));
    }

    public void PrintTeacher()
    {
        Console.Write("Enter the teacher id:");
        string idInString = Console.ReadLine();

        Console.WriteLine(new string('-', 65));

        if (!int.TryParse(idInString, out int id) || !(id >= 0 && id < _teacherIndex))
        {
            Console.WriteLine("Not found");
            return;
        }

        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}{"Subject",-20}");

        var teacher = Teachers[id];
        Console.WriteLine($"{teacher.FirstName,-20}{teacher.LastName,-20}{teacher.Age,-5}{teacher.Subject,-20}");
        Console.WriteLine(new string('-', 65));
    }
}

