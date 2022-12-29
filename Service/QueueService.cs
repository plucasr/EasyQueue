using HailaQueue.Models;
using StackExchange.Redis;

namespace HailaQueue;

public class QueueService : IQueueService
{
    private readonly ISubscriber _pubSub;
    private readonly IDatabase _database;

    public QueueService(ISubscriber pubSub, IDatabase database)
    {
        _pubSub = pubSub;
        _database = database;
    }

    public void Add(Process process)
    {
        throw new NotImplementedException();
    }

    public void Remove(Process process)
    {
        throw new NotImplementedException();
    }

    public void Remove(string slug)
    {
        throw new NotImplementedException();
    }

    private void AddProcessInterval(Process process) { }
}
