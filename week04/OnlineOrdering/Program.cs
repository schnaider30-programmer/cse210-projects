using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Order> listOfOrder = new List<Order>();

        Address firstCustomerAddress = new Address("123 Maple Street", "Montreal", "Quebec", "Canada");
        Address secondCustomerAddress = new Address("456 Elm Avenue", "Provo", "Utah", "USA");
        Address thirdCustomerAddress = new Address("Delmas 32", "Port-au-Prince", "Haiti");


        Customer firsrCustomer = new Customer("Sophie Tremblay", firstCustomerAddress);
        Customer secondCustomer = new Customer("Michael Johnson", secondCustomerAddress);
        Customer thirdCustomer = new Customer("Schnaider Jean Louis", thirdCustomerAddress);

        Product p1 = new Product("CTR Ring", "CTR003", 15, 2);
        Product p2 = new Product("Book Of Mormon", "BOM004", 20, 4);
        Product p3 = new Product("Calendar 2016", "CD108", 20, 1);
        Product p4 = new Product("Earphone", "EP897", 30, 1);
        Product p5 = new Product("Diary", "DR564", 20, 5);
        Product p6 = new Product("Laptop", "IS351", 500, 3);

        Order order1 = new Order(firsrCustomer, p1);
        order1.AddProduct(p3);
        order1.AddProduct(p5);
        Order order2 = new Order(secondCustomer, p4);
        order2.AddProduct(p2);
        Order order3 = new Order(thirdCustomer, p4);
        order3.AddProduct(p1);
        order3.AddProduct(p6);

        listOfOrder.Add(order1);
        listOfOrder.Add(order2);
        listOfOrder.Add(order3);

        foreach (Order order in listOfOrder)
        {
            Console.WriteLine($"\n{new string('=', 50)}");
            Console.WriteLine($"Product(s): \n{order.OrderPAckingLabel()}{new string('-', 40)}\nDeliver to: {order.OrderShippingLabel()} \n{new string('-', 40)}\nPrice: {order.TotalCostOfOrder()}$");

        }
    }
}