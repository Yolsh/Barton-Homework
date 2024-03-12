using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A121
{
    internal class PizzaOrder
    {
        private string address;
        private int diameter;
        private List<string> toppings;

        public PizzaOrder(string addressToDeliver, int size, List<string> listOfToppings)
        {
            address = addressToDeliver;
            diameter = size;
            toppings = listOfToppings;
        }

        public int getPrice()
        {
            return (int) Math.Floor((Math.PI * Math.Pow(diameter / 2, 2) / 10) + toppings.Count + 2);
        }

        public void getSummary()
        {
            Console.WriteLine($"the Pizza is being deliverede to {address}");
            Console.WriteLine($"it is {diameter}");
            Console.WriteLine($"it will cost {getPrice()}");
            Console.WriteLine("it contains: ");
            foreach (string item in toppings) Console.WriteLine(item);
        }
    }
}
