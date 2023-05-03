using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        List<Pizza> pizze = new List<Pizza>()
            {
                new Pizza(0,"Margherita con bufala", "Pizza classica con bufala 100% italiana", 4.00M, "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg"),
                new Pizza(1,"Prosciutto e funghi", "Pizza margherita con prosciutto e funghi", 6.00M, "https://assets.afcdn.com/recipe/20210514/120317_w640h486c1cx1060cy707cxb2121cyb1414.webp"),
                new Pizza(2,"Pizza margherita semplice", "Pizza con margherita classica", 3.50M, "https://images.ctfassets.net/nw5k25xfqsik/64VwvKFqxMWQORE10Tn8pY/200c0538099dc4d1cf62fd07ce59c2af/20220211142754-margherita-9920.jpg?w=1024"),
           };
        public IActionResult Index()
        {
           
            return View(pizze);
        }

        public IActionResult Details(long id)
        {
            Pizza pizza = pizze.FirstOrDefault(p => p.Id == id);

            return View(pizza);
        }
    }
}
