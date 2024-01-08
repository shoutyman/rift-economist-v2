using Microsoft.Extensions.DependencyInjection;
using RiftEconomistProcessor.Model;

namespace RiftEconomistProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();
            services.AddSingleton<ValueCalculator>();
            var serviceProvider = services.BuildServiceProvider();

            var valueCalculator = serviceProvider.GetRequiredService<ValueCalculator>();
            var bigFatRammus = new Champion { MagicResist = 200 };
            var hypotheticalPenItem = new Item { MagicPenetrationPercent = 0.4 };
            var me = new Champion
            {
                MagicPenetration = 0
            };
            Console.WriteLine($"Purchasing a HYPOTHETICAL_PEN_ITEM will increase your damage to Rammus by {valueCalculator.CalculateDamageIncrease(bigFatRammus, hypotheticalPenItem) * 100}%");
            Console.ReadKey();
        }
    }
}
