using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoTypePattern
{
    public abstract class XboxGame
    {
        public string Title { get; set; }
        public string ProductKey { get; set; }
        public abstract XboxGame Clone();
        public static string ProductKeyGeneration()
        {
            Random r = new Random();
            string productKey = "";
            for (int i = 0; i < 20; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    productKey += "-";
                }
                productKey += (char)(r.Next(26) + 65);

            }
            return productKey;
        }
    }
}
