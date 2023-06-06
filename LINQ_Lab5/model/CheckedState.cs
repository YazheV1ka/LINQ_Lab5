using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class CheckedState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("You marked task as executed.");
        task.ChangeState(new ExecutedState());
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("Error: Cannot submit the task for review. Task is already checked.");
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("Error: Task is already checked.");
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("Requesting review for the task.");
        task.ChangeState(new RetakeForReviewState());
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Task marked as not executed.");
        task.ChangeState(new NotExecutedState());
    }
    
    public override void IssuedTask()
    {
        Console.WriteLine("Error: Cannot mark the task as issued. Task is already checked.");
    }
}