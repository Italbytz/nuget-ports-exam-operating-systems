namespace Italbytz.Ports.Exam.OperatingSystems
{
    public interface IBuddyParameters
    {
        string[] Processes { get; set; }
        int[] Requests { get; set; }
        string[] FreeOrder { get; set; }
    }
}