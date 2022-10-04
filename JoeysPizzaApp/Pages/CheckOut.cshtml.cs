using JoeysPizzaApp.Entities;
using JoeysPizzaApp.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoeysPizzaApp.Pages
{
    public class CheckOutModel : PageModel
    {
        public List<Item> cart { get; set; }
        public double Total { get; set; }
        public void OnGet()
        {
            cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            Total = cart.Sum(i => i.Pizza.Price * i.Quantity);
        }
    }
}
