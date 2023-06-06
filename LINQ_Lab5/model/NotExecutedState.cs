using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class NotExecutedState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as executed. Task is not checked.");
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("You submitted the task for review");
        task.ChangeState(new SubmittedForReviewState());
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("Task marked as checked.");
        task.ChangeState(new CheckedState());
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("You requested review");
        task.ChangeState(new RetakeForReviewState());
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Task is already marked as not executed.");
    }

    public override void IssuedTask()
    {
        Console.WriteLine("Error: Task is already marked as issued.");
    }
}