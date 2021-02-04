using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Localisation
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            
            Console.WriteLine("Tapez : \n 1 for CCI \n 2 for Chez Wam \n 3 for Stade des Alpes \n \n 4 Pour le offline");
            
            string choice = Console.ReadLine();

            int choiceNumber = int.Parse(choice);

            Console.WriteLine(choice);
            

            Model model = new Model();
            model.getUrl(choiceNumber);
        }
    }
}
