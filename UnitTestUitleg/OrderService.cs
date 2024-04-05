using System;
using UnitTestUitleg;

public class OrderService
{
    private readonly IOrderRepository repository;

    public OrderService(IOrderRepository repository)
	{
        this.repository = repository;
    }

    public void AddOrder(Order order)
    {
        if (order.TotalPrice > 500)
        {
            throw new Exception("Order too expensive");
        }

        repository.AddOrder(order); 
    }
}
