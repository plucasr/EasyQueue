namespace HailaQueue;

public interface IQueueService
{
    void Add();
    void Remove();
    void Execute();
}
