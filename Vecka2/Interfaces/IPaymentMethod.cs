namespace Vecka2.Interfaces;

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}