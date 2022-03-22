using System;
namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface ISchedulingParameters
    {
        int[] Values { get; set; }
        string[] Priorities { get; set; }
    }
}
