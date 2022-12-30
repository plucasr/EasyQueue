using System;
using System.Threading.Tasks;

namespace EasyQueue;

public interface IQueueListener
{
    ///<sumary>
    /// Listener that receives the string processorChannel and the callback for handle the action
    ///</sumary>
    Task Processor<ProcessorType>(string processorChannel, Action<ProcessorType> onProcess);

    ///<sumary>
    /// JSON - Listener that receives the string processorChannel and the callback for handle the action
    ///</sumary>
    Task Processor(string processorChannel, Action<string> onProcess);
}
