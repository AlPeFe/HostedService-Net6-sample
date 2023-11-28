using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcEjemploManco
{
    internal class WorkerStatus : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine($"Worker STATUS {DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss")}");

            await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
            await base.StartAsync(stoppingToken);
        }
    }
}
