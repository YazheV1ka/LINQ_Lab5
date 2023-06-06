using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class SubmittedForReviewState : TaskState
{
    public override void MarkAsExecuted(CustomTask task)
    {
        Console.WriteLine("Error: You can mark it as executed. Task is not checked.");
    }

    public override void SubmitForReview(CustomTask task)
    {
        Console.WriteLine("Error: Task is already submitted for review.");
    }

    public override void MarkAsChecked(CustomTask task)
    {
        Console.WriteLine("Task marked as checked.");
        task.ChangeState(new CheckedState());
    }

    public override void RequestReview(CustomTask task)
    {
        Console.WriteLine("Review is requested for the task.");
    }

    public override void MarkAsNotExecuted(CustomTask task)
    {
        Console.WriteLine("Error: Cannot mark the task as not executed. Task is already submitted for review.");
    }
    
    public override void IssuedTask()
    {
        Console.WriteLine("Error: Cannot mark the task as issued.");
    }
}