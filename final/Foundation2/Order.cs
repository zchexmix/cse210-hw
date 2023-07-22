using System;

class Order
{
    private Customer customer;
    private decimal shippingCost;
    private Product[] products;

    public Order(Customer customer, Product[] products)
    {
        this.customer = customer;
        this.products = products;
        shippingCost = customer.IsInUSA() ? 5 : 35;
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in products)
        {
            total += product.GetTotalPrice();
        }
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in products)
        {
            label += product.ToString() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nName: {customer.Name}\nAddress: {customer.Address}";
    }
}