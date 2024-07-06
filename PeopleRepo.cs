using System.Collections.Generic;
using System.Linq;

namespace MyMvcProject.Models
{
    public class PeopleRepo : IPeopleRepo
    {
        private readonly List<Person> _people = new List<Person>(); // In-memory list to store people

        public IEnumerable<Person> GetAllPeople()
        {
            return _people; // Return all people
        }

        public Person GetPersonById(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id); // Find person by ID
        }

        public void AddPerson(Person person)
        {
            person.Id = _people.Count + 1; // Set ID for new person
            _people.Add(person); // Add person to list
        }

        public void DeletePerson(int id)
        {
            var person = _people.FirstOrDefault(p => p.Id == id); // Find person by ID
            if (person != null)
            {
                _people.Remove(person); // Remove person if found
            }
        }
    }
}