public interface Subject
{
    void Notify();
    string SubjectState { get; set; }
}