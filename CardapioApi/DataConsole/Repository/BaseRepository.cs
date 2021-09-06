using DataConsole.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConsole.Repository
{
    class BaseRepository<T> where T : Base
    {
        public void Post()
        {
            var factory = new ConnectionFactory() { HostName = "192.168.0.124" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var cardapio = System.Text.Json.JsonSerializer.Deserialize<Cardapio>(body);
                    Console.WriteLine(" [x] Received {0}", cardapio.Nome);
                };
                channel.BasicConsume(queue: "Rod_queue",
                                                            autoAck: false,
                                                            consumer: consumer);
                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }

            
        }

    }
}
