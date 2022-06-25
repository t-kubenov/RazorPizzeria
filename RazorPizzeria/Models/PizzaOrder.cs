namespace RazorPizzeria.Models
{
    public class PizzaOrder
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string PizzaName { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Pepperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Beef { get; set; }
        public bool Chicken { get; set; }
        public float FinalPrice { get; set; }
    }
}
