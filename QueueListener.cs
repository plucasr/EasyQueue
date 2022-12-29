namespace HailaQueue;

public class QueueListener
{
    public Task Processor<ProcessorType>(
        string processorChannel,
        ProcessorType payload,
        Action<ProcessorType> action
    )
    {
        return Task.FromResult(0);
    }

    public Task Processor(string processorChannel, string json, Action<string> action)
    {
        return Task.FromResult(0);
    }

    private void Process() { }
}
