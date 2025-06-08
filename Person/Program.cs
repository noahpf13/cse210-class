class Program
{
    public static void Main(string[] args)
    {
        Person myperson = new Person("Bobby", "Bob", 53);
        Console.WriteLine(myperson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 35, "Club");
        Console.WriteLine(myPoliceMan.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 65, "Stethoscope");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}
