using System.Collections.Generic;
using MyMvcProject.ViewModels;

namespace MyMvcProject.Models
{
    public interface IPeopleService
    {
        IEnumerable<PersonViewModel> GetAllPeople(); // Get all people from the service
        PersonViewModel GetPersonById(int id); // Get a person by their ID from the service
        void AddPerson(PersonCreateViewModel model); // Add a new person using the service
        void DeletePerson(int id); // Delete a person by their ID using the service
    }
}