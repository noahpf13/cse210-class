
public class Resume
{
    // Attributes or variables
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Constructs resume
    public Resume()
    {   
    }
    
    // Methods
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        foreach (Job job in _jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear} - {job._endYear}");
        }
    }
}