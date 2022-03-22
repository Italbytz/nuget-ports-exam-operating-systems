using System;
namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface IRealtimeSchedulingParameters
    {
        (int, int)[] Requests { get; set; }
    }
}
