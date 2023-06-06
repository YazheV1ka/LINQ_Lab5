using LINQ_Lab5.model;

namespace LINQ_Lab5.@abstract;

public abstract class TaskState
{
    public abstract void MarkAsExecuted(CustomTask task);
    public abstract void SubmitForReview(CustomTask task);
    public abstract void MarkAsChecked(CustomTask task);
    public abstract void RequestReview(CustomTask task);
    public abstract void MarkAsNotExecuted(CustomTask task);
    public abstract void IssuedTask(CustomTask task);
    
}