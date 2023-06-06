using LINQ_Lab5.@abstract;

namespace LINQ_Lab5.model;

public class CustomTask
{
    private TaskState currentState;
    public string name { get; set; }

    public CustomTask()
    {
        currentState = new IssuedState();
    }

    public void ChangeState(TaskState newState)
    {
        currentState = newState;
    }

    public void MarkAsExecuted()
    {
        currentState.MarkAsExecuted(this);
    }

    public void SubmitForReview()
    {
        currentState.SubmitForReview(this);
    }

    public void MarkAsChecked()
    {
        currentState.MarkAsChecked(this);
    }

    public void RequestReview()
    {
        currentState.RequestReview(this);
    }

    public void MarkAsNotExecuted()
    {
        currentState.MarkAsNotExecuted(this);
    }
    public void IssuedTask()
    {
        currentState.IssuedTask(this);
    }
    
}