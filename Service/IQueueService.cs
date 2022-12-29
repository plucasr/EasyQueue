using EasyQueue.Models;

namespace EasyQueue;

public interface IQueueService
{
    void Add(Process process);
    void Remove(Process process);
    void Remove(string slug);
}
