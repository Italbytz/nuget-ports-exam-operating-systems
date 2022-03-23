using System;
namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface IPageReplacementParameters
    {
        int[] ReferenceRequests { get; set; }
        int MemorySize { get; set; }
    }
}
