using System;
using EasyQueue.Enums;

namespace EasyQueue.Models;

public class Process
{
    public Process(
        string slug,
        string body,
        string bodyType,
        string processorChannel,
        QueueStatus status
    )
    {
        Id = Guid.NewGuid();
        Slug = slug;
        Body = body;
        BodyType = bodyType;
        ProcessorChannel = processorChannel;
        Status = status;
    }

    public Guid Id { get; set; }
    public string Slug { get; set; } = "";
    public string Body { get; set; } = "";
    public string BodyType { get; set; } = "";
    public IntervalType IntervalType { get; set; } = IntervalType.Minute;
    public string ProcessorChannel { get; set; } = "";
    public DateTime LastUpdated { get; set; } = DateTime.Now;
    public QueueStatus Status { get; set; } = QueueStatus.ToProcess;
    public DateTime StartedAt { get; set; } = DateTime.Now;
    public DateTime EndedAt { get; set; } = DateTime.Now;
}
