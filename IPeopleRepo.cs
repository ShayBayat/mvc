using System.Collections.Generic;

namespace MyMvcProject.Models
{
    public interface IPeopleRepo
    {
        IEnumerable<Person> GetAllPeople(); // Get all people from the repository
        Person GetPersonById(int id); // Get a person by their ID
        void AddPerson(Person person); // Add a new person to the repository
        void DeletePerson(int id); // Delete a person from the repository by their ID
    }
}
