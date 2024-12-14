using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        // Costo de envío
        if (_customer.IsInUSA())
        {
            total += 5; // Envío dentro de USA
        }
        else
        {
            total += 35; // Envío internacional
        }
        return total;
    }

    public string GetPackingLabel()
    {
        // Nombre y ID de cada producto
        string label = "Packing Label:\n";
        foreach (Product p in _products)
        {
            label += p.GetName() + " (ID: " + p.GetProductId() + ")\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        // Nombre del cliente y dirección completa
        string label = "Shipping Label:\n";
        label += _customer.GetName() + "\n" + _customer.GetAddress().GetFullAddress() + "\n";
        return label;
    }
}
