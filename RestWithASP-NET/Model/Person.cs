namespace RestWithASP_NET.Model
{
    public class Person
    {

        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;

        public Person()
        {
        }

        public Person(long id, string firstName, string lastName, string address, string gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Gender = gender;
        }
    
          
    }
}
