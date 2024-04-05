namespace UnitTestUitleg;

public class Order
{
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public string Customer { get; set; }

    public decimal TotalPrice
    {
        get
        {
            decimal total = 0;
            foreach (var item in OrderItems)
            {
                total += item.Price;
            }

            // Als totaal >= 100, dan 5% korting
            // anders geen korting
            if (total >= 100)
            {
                total *= 0.95m;
            }

            return total;
        }
    }
}
