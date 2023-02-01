using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        Person pet = new Person() { Id = 1, FirstName = "Pet", LastName = "Burity", Gender = "masculino", Adress = "Pau Ferro" };

        Person IPersonService.Create(Person person)
        {
            return person;
        }

        void IPersonService.Delete(long Id)
        {
            
        }

        List<Person> IPersonService.FindAll()
        {
            List<Person> persons = new List<Person>();
            return persons;
        }

        List<Person> IPersonService.FindAllByName(string name)
        {
            throw new NotImplementedException();
        }

        Person IPersonService.FindById(long Id)
        {
            return null;
        }

        Person IPersonService.Update(Person person)
        {
            return null;
        }

        
    }
}
