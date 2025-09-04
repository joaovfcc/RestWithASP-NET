using RestWithASP_NET.Model;
using RestWithASP_NET.Model.Context;

namespace RestWithASP_NET.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {

        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context)
        { 
            _context = context;
        
        }

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
        }

        public List<Person> FindAll()
        {

            return _context.Persons.ToList();
        }
        

        public Person FindById(long id)
        {
            // Retorna uma instância de Person usando o construtor correto
            return new Person(id, "Leandro", "Costa", "Uberlândia - Minas Gerais - Brasil", "Male");
        }

        public Person Update(Person person)
        {
            return person;
        }
   
    }
}
