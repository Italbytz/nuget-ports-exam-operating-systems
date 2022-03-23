using System;
using System.Collections.Generic;

namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface IPageReplacementSolution
    {
        List<IPageReplacementStep> Steps { get; set; }
    }
}
