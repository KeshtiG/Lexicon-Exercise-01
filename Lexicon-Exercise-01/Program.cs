namespace Lexicon_Exercise_01;



internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the employee register.");
        List <Employee> allEmployees = new List<Employee>();

        while (true)
        {
            Console.WriteLine("Enter an option from the list below.");
            Console.WriteLine("1: Add employee\n2: Show employee list\n3: Exit");
            Console.Write("\nEnter a number: ");

            string? userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    AddEmployee(allEmployees);
                    break;
                case "2":
                    ShowEmployees(allEmployees);
                    break;
                case "3":
                    Console.WriteLine("Shutting down program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice, choose from the available options.");
                    break;
            }
        }
    }

    static void AddEmployee(List<Employee> employees)
    {
        Console.Write("First name: ");
        string firstName = Console.ReadLine() ?? "";
        Console.Write("Last name: ");
        string lastName = Console.ReadLine() ?? "";
        Console.Write("Salary: ");
        string salary = Console.ReadLine() ?? "";

        if (firstName == "" || lastName == "" || salary == "")
            Console.WriteLine("You did not fill in the fields correctly, please try again.");
        else
        {
            Employee newEmployee = new Employee(firstName, lastName, salary);
            employees.Add(newEmployee);
            Console.WriteLine("New employee added.\n");
        }
    }

    static void ShowEmployees(List<Employee> employees)
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("There are no employees in the list.\n");
            return;
        }

        Console.WriteLine("\nEMPLOYEE LIST:");
        foreach (var employee in employees)
        {
            employee.showEmployeeInfo();
        }

        Console.WriteLine("");
    }
}

