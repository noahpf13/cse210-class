class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        string input = "";

        while (input != "7")
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.DisplayGoals();
                    Console.Write("Select goal to record: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    manager.RecordEvent(index);
                    break;
                case "4":
                    manager.ShowScore();
                    break;
                case "5":
                    Console.Write("Enter filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;
                case "6":
                    Console.Write("Enter filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Types: 1 = Simple, 2 = Eternal, 3 = Checklist");
        Console.Write("Enter goal type: ");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, pts));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, pts));
                break;
            case "3":
                Console.Write("Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, pts, target, bonus));
                break;
        }
    }
}
