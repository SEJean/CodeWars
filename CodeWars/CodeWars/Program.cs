using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Author profile : https://www.codewars.com/users/jeank714
namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }
    }

    public static class Kata
    {
        /// <summary>
        /// Challenge URL : https://www.codewars.com/kata/ip-validation/
        /// </summary>
        /// <param name="IpAddres"></param>
        /// <returns>true if the IP address is valid</returns>
        ///
        public static bool is_valid_IP(string IpAddres)
        {
            string[] numbers = IpAddres.Split('.');
            bool ipValid = true;
            ipValid = IpAddres != "" && string.Join("", numbers).All(char.IsDigit) && numbers.Length == 4;

            for (int i = 0; i < numbers.Length && ipValid; i++)
            {
                int num = Convert.ToInt32(numbers[i]);
                ipValid = (num >= 0 && num <= 255) && numbers[i][0] != '0';
            }
            return ipValid;
        }
    }
}
