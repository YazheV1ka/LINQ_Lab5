using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class IssuedState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as executed. Task is not submitted for review yet.");
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("Task submitted for review.");
        task.ChangeState(new SubmittedForReviewState());
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as checked. Task is not submitted for review yet.");
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("Error: Cannot request review. Task is not submitted for review yet.");
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Task marked as not executed.");
        task.ChangeState(new NotExecutedState());
    }

    public override void IssuedTask(CustomTask task)
    {
        Console.WriteLine("Error: Task is already issued.");
    }
}