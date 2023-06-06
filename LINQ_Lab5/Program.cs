using LINQ_Lab5.model;

namespace LINQ_Lab5;

class Program
{
    static void Main(string[] args)
    {
        //[issued]->{not executed}->submit review->checked->executed
        //[issued]->{not executed}->submit review->checked->request review->checked->executed
        CustomTask task = new CustomTask();
        Console.WriteLine("Enter task name: ");
        string? taskName = Console.ReadLine();
        Console.WriteLine($"Task {taskName}: ");
        Console.WriteLine("Enter operation(issued/executed/not executed/submit review/request review/checked) or 'quit' to exit: ");
        string? operationName = Console.ReadLine();

        while (operationName != "quit")
        {
            switch (operationName)
            {
                case "issued":
                    task.IssuedTask();
                    break;
                case "executed":
                    task.MarkAsExecuted();
                    break;
                case "not executed":
                    task.MarkAsNotExecuted();
                    break;
                case "submit review":
                    task.SubmitForReview();
                    break;
                case "request review":
                    task.RequestReview();
                    break;
                case "checked":
                    task.MarkAsChecked();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.WriteLine("Enter operation(issued/executed/not executed/submit review/request review/checked) or 'quit' to exit: ");
            operationName = Console.ReadLine();
        }
    }
}

