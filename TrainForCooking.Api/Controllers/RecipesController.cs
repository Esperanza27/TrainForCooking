using Microsoft.AspNetCore.Mvc;
using TrainForCooking.Dto;

namespace TrainForCooking.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecipesController : ControllerBase
{
    [HttpGet("{id:int}")]
    public IActionResult GetRecipe(int id)
    {
        if (id == 4)
        {
        return NotFound();
        }
        var category = new Category() { Id = 1, Name = "Primi Piatti" };
        var cuisine = new Cuisine() { Id = 1, Name = "Italiana" };

        var ingredients = new List<Ingredient>
        {
            new Ingredient() { Name = "Spaghetti", Quantity = 400, unitOfMeasure = Unit.Gr },
            new Ingredient() { Name = "uova", Quantity = 4, unitOfMeasure = Unit.unit},
            new Ingredient() { Name = "Guanciale", Quantity = 200, unitOfMeasure = Unit.Gr },
            new Ingredient() { Name = "pecorino", Quantity = 50, unitOfMeasure = Unit.Gr },
            new Ingredient() { Name = "Pepe",  Quantity = 1, unitOfMeasure = Unit.Tsp},
            new Ingredient() { Name = "Sale",  Quantity = 1, unitOfMeasure = Unit. Tsp },

        };

        var recipe = new Recipe()
        {
            Id = id,
            Title = "Spaghetti alla carbonara",
            Category = category,
            CategoryId = category.Id,
            Cuisine = cuisine,
            CuisineId = cuisine.Id,
            CookingTimeInMinutes = 10,
            PreparationTimeInMinutes = 20,
            Ingredients = ingredients,
            Instruction = "Cuocere gli spaghetti "
        };
        return Ok(recipe);
    }
}
