class Program
{
    public static void Main(string[] args)
    {
        Person myperson = new Person("Bobby", "Bob", 53);
        Console.WriteLine(myperson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 35);
        Console.WriteLine(myPoliceMan.GetPersonInformation());
    }
}
