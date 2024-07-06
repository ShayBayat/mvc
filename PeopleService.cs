using System.Collections.Generic;
using System.Linq;
using MyMvcProject.ViewModels;

namespace MyMvcProject.Models
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepo _repo;

        public PeopleService(IPeopleRepo repo)
        {
            _repo = repo; // Injecting the repository
        }

        public IEnumerable<PersonViewModel> GetAllPeople()
        {
            // Convert each Person to PersonViewModel and return
            return _repo.GetAllPeople().Select(p => new PersonViewModel
            {
                Id = p.Id,
                Name = p.Name,
                City = p.City
            });
        }

        public PersonViewModel GetPersonById(int id)
        {
            var person = _repo.GetPersonById(id); // Get the person by ID from the repository
            if (person == null) return null;

            // Convert the Person to PersonViewModel and return
            return new PersonViewModel
            {
                Id = person.Id,
                Name = person.Name,
                City = person.City
            };
        }

        public void AddPerson(PersonCreateViewModel model)
        {
            // Convert the PersonCreateViewModel to Person
            var person = new Person
            {
                Name = model.Name,
                City = model.City
            };
            _repo.AddPerson(person); // Add the person to the repository
        }

        public void DeletePerson(int id)
        {
            _repo.DeletePerson(id); // Delete the person by ID from the repository
        }
    }
}