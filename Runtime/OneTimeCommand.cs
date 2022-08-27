public abstract class OneTimeCommand : Command
{
    private bool wasExecuted = false;

    public virtual void Execute()
    {
        wasExecuted = true;
    }

    public virtual void Reset()
    {
        wasExecuted = false;
    }

    public virtual bool ShouldExecute()
    {
        return !wasExecuted;
    }
}
