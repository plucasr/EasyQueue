using System.Text.Json;
using StackExchange.Redis;

namespace HailaQueue;

public class QueueListener
{
    private List<string> channels = new();

    private readonly ISubscriber _pubSub;

    public QueueListener(ISubscriber pubSub)
    {
        _pubSub = pubSub;
    }

    ///<sumary>
    /// Listener that receives the string processorChannel and the callback for handle the action
    ///</sumary>
    public async Task Processor<ProcessorType>(
        string processorChannel,
        Action<ProcessorType> action
    )
    {
        if (channels.Contains(processorChannel))
        {
            throw new Exception("Duplicated processorChannel");
        }
        await _pubSub.SubscribeAsync(
            processorChannel,
            (channel, message) =>
            {
                var data = JsonSerializer.Deserialize<ProcessorType>(message.ToString());
                if (data != null)
                {
                    action(data);
                }
            }
        );
        return;
    }

    ///<sumary>
    /// JSON - Listener that receives the string processorChannel and the callback for handle the action
    ///</sumary>
    public async Task Processor(string processorChannel, Action<string> action)
    {
        if (channels.Contains(processorChannel))
        {
            throw new Exception("Duplicated processorChannel");
        }
        await _pubSub.SubscribeAsync(
            processorChannel,
            (channel, message) =>
            {
                action(message.ToString());
            }
        );
        return;
    }

    private void Process() { }
}
