using Microsoft.AspNetCore.Mvc;
using WebApiSample.Api.Controllers;
using WebApiSample.Api.Models;

namespace WebApiSample.Controllers;

public class PetsController : PetsApiController
{
    public override IActionResult CreatePets(Pet pet)
    {
        return new ObjectResult(true);
    }

    public override IActionResult ListPets(int? limit)
    {
        return new ObjectResult(new List<Pet>{new() {Id = 0, Name = "Dog"}, new () {Id = 1, Name = "Cat"}});
    }

    public override IActionResult ShowPetById(string petId)
    {
        if (petId == "0")
        {
            return new ObjectResult(new Pet { Id = 0, Name = "Dog" });
        }
        if (petId == "1")
        {
            return new ObjectResult(new Pet { Id = 1, Name = "Cat" });
        }

        return NotFound();
    }
}