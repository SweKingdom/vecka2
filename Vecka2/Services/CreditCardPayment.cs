using Vecka2.Interfaces;

namespace Vecka2.Services;

public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine("Credit card payment method called");
    }
}