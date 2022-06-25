using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> pizzaOrders = new();
        private readonly ApplicationDBContext _context;
        public OrdersModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
