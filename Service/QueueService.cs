using System;
using System.Text;
using EasyQueue.Models;
using StackExchange.Redis;

namespace EasyQueue;

public class QueueService : IQueueService
{
    private readonly ISubscriber _pubSub;
    private readonly IDatabase _database;

    public QueueService(ISubscriber pubSub, IDatabase database)
    {
        _pubSub = pubSub;
        _database = database;
    }

    private void AddCronJob(Process process)
    {
        // TODO - CREATE QUARTZ CRON SETUP HERE
    }

    public async void Add(Process process)
    {
        if (process.Schedule)
        {
            AddCronJob(process);
        }
        var json = System.Text.Json.JsonSerializer.Serialize(process);
        await _database.StringSetAsync(process.Slug, json);
        var data = await _database.StringGetAsync(
            $"{process.IntervalType.ToString()}.{process.IntervalTime.ToString()}"
        );
        data.ToString();
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
