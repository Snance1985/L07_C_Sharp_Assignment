class Program
{
    static List<Task> taskList = new List<Task>();

    static void Main(string[] args)
    {
        bool quit = false;
        while (!quit)
        {
            DisplayOptions();
            Console.WriteLine("Enter your choice (1-4):");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateTask();
                    break;
                case "2":
                    ViewAllTasks();
                    break;
                case "3":
                    CompleteTask();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Program has ended. Press any key to exit.");
        Console.ReadKey();
    }

    static void DisplayOptions()
    {
        Console.WriteLine("1. Create a Task");
        Console.WriteLine("2. View All Tasks");
        Console.WriteLine("3. Complete a Task");
        Console.WriteLine("4. Quit");
    }

    static void CreateTask()
    {
        Console.WriteLine("Enter the name of the task:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the duration of the task:");
        string duration = Console.ReadLine();

        Task newTask = new Task(name, duration);
        taskList.Add(newTask);

        Console.WriteLine("Task created successfully!");
    }

    static void ViewAllTasks()
    {
        if (taskList.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            Console.WriteLine("Tasks:");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"Task {i + 1}:");
                Console.WriteLine($"Name: {taskList[i].GetTaskName()}");
                Console.WriteLine($"Duration: {taskList[i].GetDuration()}");
                Console.WriteLine($"Complete: {taskList[i].IsComplete()}");
                Console.WriteLine();
            }
        }
    }

    public static void CompleteTask()
    {
        if (taskList.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            Console.WriteLine("Select the task to complete:");
            for (int i = 0; i < taskList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {taskList[i].TaskName}");
            }
        
            Console.Write("Enter the task number: ");
    }
    }
}