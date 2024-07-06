using Microsoft.AspNetCore.Mvc;
using MyMvcProject.Models;
using MyMvcProject.ViewModels;

namespace MyMvcProject.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService; // Injecting the service
        }

        // This method displays the list of people
        public IActionResult Index()
        {
            var people = _peopleService.GetAllPeople();
            return View(people); // Passing the list to the view
        }

        // This method returns the reate view
        public IActionResult Create()
        {
            return View();
        }

        // This method handles the form submission for creating a new person
        [HttpPost]
        public IActionResult Create(PersonCreateViewModel model)
        {
            if (ModelState.IsValid) // Check if the model is valid
            {
                _peopleService.AddPerson(model);
                return RedirectToAction("Index"); // Redirect to the list after creation
            }
            return View(model); // If not valid, return the same view with errors
        }

        // This method displays the details of a person
        public IActionResult Details(int id)
        {
            var person = _peopleService.GetPersonById(id);
            if (person == null)
            {
                return NotFound(); // Return 404 if person not found
            }
            return View(person); // Pass the person to the view
        }

        // This method deletes a person
        public IActionResult Delete(int id)
        {
            _peopleService.DeletePerson(id);
            return RedirectToAction("Index"); // Redirect to the list after deletion
        }
    }
}