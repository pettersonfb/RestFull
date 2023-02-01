using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Services
{
    public interface IPersonService
    {
        Person FindById(long Id);
        Person Create(Person person);        
        Person Update(Person person);
        void Delete(long Id);
        List<Person> FindAll();
        List<Person> FindAllByName(string name);
    }
}
