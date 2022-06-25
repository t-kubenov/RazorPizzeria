using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;
using RazorPizzeria.Data;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {


        private readonly ApplicationDBContext _context;
        public PizzasModel pizza { get; set; }

        public CheckoutModel(ApplicationDBContext context)
        {
            _context = context;
        }


        public void OnGet()
        {        
            if (string.IsNullOrWhiteSpace(pizza.PizzaName))
            {
                pizza.PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(pizza.ImageTitle))
            {
                pizza.ImageTitle = "Create";
            }
        }


        public IActionResult OnPost()
        {  
            PizzaOrder pizzaOrder = new()
            {
                PizzaName = pizza.PizzaName,
                TomatoSauce = pizza.TomatoSauce,
                Cheese = pizza.Cheese,
                Pepperoni = pizza.Pepperoni,
                Mushroom = pizza.Mushroom,
                Tuna = pizza.Tuna,
                Pineapple = pizza.Pineapple,
                Beef = pizza.Beef,
                Chicken = pizza.Chicken,
                FinalPrice = pizza.FinalPrice
            };


            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();

            return RedirectToPage("/Checkout/ThankYou");
        }
    }
}
