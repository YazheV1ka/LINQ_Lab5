using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class RetakeForReviewState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as executed. Task is under review for retake.");
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("Error: Task is already submitted for review.");
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("You marked the task as checked.");
        task.ChangeState(new CheckedState());
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("Review is requested for the task.");
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Task marked as not executed.");
        task.ChangeState(new NotExecutedState());
    }
    
    public override void IssuedTask(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as issued.");
    }
}