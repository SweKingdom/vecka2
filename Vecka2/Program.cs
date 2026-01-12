using Vecka2.Interfaces;
using Vecka2.Models;
using Vecka2.Services;

Animal animal = new Dog(); // A dog is a Animal
animal.Eat();   // Dog.Eat()

List<int> numb = [1, 2, 3, 4, 5];

var greaterthen = numb.Where(n => n > 2).ToList();

greaterthen.ForEach(n => Console.WriteLine(n));


List<IPaymentMethod> payment = new()
{
    new CreditCardPayment(),
    new SwishPayment()
};

foreach (var i in payment)
{
    i.ProcessPayment(100m);
}
