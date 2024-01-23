public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();
    public void Display()
    {
        Console.Write(_name);
        foreach (Job job in _jobs)
        {
            Console.Write($"{job.Display}");
        }
    }
    
}