using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace ShoppingCart
{
    public class ConfigurableDiscount : IDiscount
    {
        ProductHandler productHandler = new ProductHandler();

        public double GetDiscount(Dictionary<string, int> items)
        {
            int discount = 0;
            int totalPrice = 0;

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
      .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            int.TryParse(configuration.GetConnectionString("discount"),out discount);
            for (int i = 0; i < items.Count; i++)
            {
                var item = items.ElementAt(i);
                totalPrice = totalPrice + (productHandler.GetItemPriceByName(item.Key) * item.Value);
            }
            return totalPrice * discount / 100;

        }
    }
}
