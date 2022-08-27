public interface Command
{
    bool ShouldExecute();

    void Execute();

    void Reset();
}
