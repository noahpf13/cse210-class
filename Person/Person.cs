class Person
{
    private string _lastName;
    private string _firstName;
    private int _age;

    public Person()
    {
        _lastName = "";
        _firstName = "";
        _age = 0;
    }
    public Person(string lastName, string firstName, int age)
    {
        _lastName = firstName;
        _firstName = lastName;
        _age = age;
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }
}