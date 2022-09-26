using SistemaDePedidos.Entities;
using SistemaDePedidos.Entities.Enums;
using System;
using System.Globalization;

namespace SistemaDePedidos
{
    class Program
    {
        static void Main(string[] atgs)
        {
            // Instanciar um pedido
            Order order = new Order
            {
                // Código do produto
                Id = 12345,
                // Momento da compra do pedido
                Moment = DateTime.Now,
                // Status atual em que se encontra a compra desse pedido
                Status = OrderEStatus.PendingPayment
            };
            Console.WriteLine(order);

        }
    }
}
