using Vecka2.Interfaces;

namespace Vecka2.Services;

public class SwishPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Swish payment method called");
    }
}