using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class ExecutedState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Task is already marked as executed.");
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("You submitted the task for review.");
        task.ChangeState(new SubmittedForReviewState());
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as checked. Task is already executed.");
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("Error: Cannot request review. Task is already executed.");
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as not executed. Task is already executed.");
    }

    public override void IssuedTask(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as issued. Task is already executed.");
    }
}