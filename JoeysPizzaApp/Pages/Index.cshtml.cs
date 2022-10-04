using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using JoeysPizzaApp.Entities;
using JoeysPizzaApp.Models;

namespace JoeysPizzaApp.Pages
{
    public class IndexModel : PageModel
    {
        //private readonly ILogger<IndexModel> _logger;

        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}
        public List<Pizza> Pizzas;

        public void OnGet()
        {
            PizzaModel productModel = new PizzaModel();
            Pizzas = productModel.findAll();
        }
        //public void OnGet()
        //{

        //}
    }
}