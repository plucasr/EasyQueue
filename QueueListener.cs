namespace HailaQueue;

public class QueueListener
{
    public delegate void ItemProcessor<PayloadType>(PayloadType item);

    public Task Processor<ProcessorType>(string processorChannel, ProcessorType payload)
    {
        return Task.FromResult(0);
    }
}
