using HailaQueue.Models;

namespace HailaQueue;

public interface IQueueService
{
    void Add(Process process);
    void Remove(Process process);
    void Remove(string slug);
}
