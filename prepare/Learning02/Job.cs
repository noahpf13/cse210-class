
    // A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Job
    {
        // The C# convention is to start member variables with an underscore _
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear;
        public int _endYear;

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
        }


    }