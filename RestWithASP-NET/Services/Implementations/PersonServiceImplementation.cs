using RestWithASP_NET.Model;

namespace RestWithASP_NET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {
            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = 1,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Uberlândia - Minas Gerais - Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
