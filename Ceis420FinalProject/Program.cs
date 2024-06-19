// See https://aka.ms/new-console-template for more information
using Ceis420FinalProject;

Helper h = new();
List<SalesPerson> persons = [];
string input = "";
while (input != "3")
{
    Console.WriteLine("Developer: Handipa Liem for CEIS420");
    Console.WriteLine();
    Console.WriteLine($"DB Info: You have {persons.Count} salesman data in the database.");
    Console.WriteLine("─────────────────────────────────────────────────────────────────");
    Console.WriteLine();


    Console.WriteLine("     SALES MENU:");
    Console.WriteLine("─────────────────────────");
    Console.WriteLine("     1. Enter Sales");
    Console.WriteLine("     2. Create Report");
    Console.WriteLine("     3. Exit");
    Console.WriteLine("─────────────────────────");
    Console.WriteLine();
    Console.Write("Please select 1 - 3: ");
    input = Console.ReadLine();


    if (input == "1")
    {
        Console.Clear();
        SalesPerson sp = new();
        Console.WriteLine("Please start entering Salesperson information");
        Console.WriteLine("Enter\"x\" to quit this menu, enter \"q\" to stop entering sales amount");
        Console.WriteLine();

        while (input.ToLower() != "x")
        {
            Console.Write("Sales Person Name: ");
            input = Console.ReadLine().ToLower();

            if (input.ToLower() == "x")
            { Console.Clear(); break; }

            sp.Name = input;
            if (input.ToLower() == "x")
            { Console.Clear(); break; }

            Console.Write("Sales Person Title: ");
            input = Console.ReadLine();
            sp.Title = input;
            int counter = 0;

            while (input.ToLower() != "q")
            {
                counter++;
                Console.Write($"Enter sales#{counter} : ");
                input = Console.ReadLine();


                if (h.CheckNumber(input))
                {
                    sp.Sales.Add(Double.Parse(input));
                }
                else
                {
                    counter--;
                    Console.WriteLine("Please enter number only");
                }
            }
            persons.Add(sp);
            sp = new();
            counter = 0;
            Console.WriteLine();
            Console.WriteLine("Continue entering sales person data? (Y/N)");
            input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                Console.Clear();
                break;
            }

        }

    }
    else if (input == "2")
    {
        Console.WriteLine("Report Creator Page");
        Console.WriteLine("─────────────────────────────────────────────────────────────────");
        Console.WriteLine();

        if (persons.Count == 0)
        {
            Console.WriteLine("No sales person data found in the database!");
            Console.WriteLine("Please hit enter");
            Console.ReadLine();
            Console.Clear();
        }
        else
        {
            SalesPerson sp = new SalesPerson();
            sp.CreateReport(persons);
            Console.ReadLine() ;
            Console.Clear() ;
        }

    }
    else if (input == "3")
    {
        Console.WriteLine("Bye now ...");
        Environment.Exit(0);    
    }
    else
    {
        Console.WriteLine("Invalid input");
        Console.ReadLine();
        Console.Clear();
    }
}

