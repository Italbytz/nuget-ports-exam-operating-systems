using System;
using Italbytz.Ports.Algorithms;

namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface ISchedulingSolver : ISolver<ISchedulingParameters, ISchedulingSolution>
    {
    }
}
