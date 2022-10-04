using JoeysPizzaApp.Entities;

namespace JoeysPizzaApp.Models
{
    public class PizzaModel
    {
        private List<Pizza> Pizzas;

        public PizzaModel()
        {
            Pizzas = new List<Pizza>() {
                new Pizza
                {
                    Id = "p01",
                    Name = "Margerita",
                    Price = 4,
                    Photo = "Margerita.png"
                },
                new Pizza
                {
                    Id = "p02",
                    Name = "Corn",
                    Price = 2,
                    Photo = "Corn.jpg"
                },
                new Pizza
                {
                    Id = "p03",
                    Name = "Onion",
                    Price = 8,
                    Photo = "Onion.jpg"
                }
            };
        }

        public List<Pizza> findAll()
        {
            return Pizzas;
        }

        public Pizza find(string id)
        {
            return Pizzas.Where(p => p.Id == id).FirstOrDefault();
        }

    }
}
   