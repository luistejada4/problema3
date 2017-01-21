using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            String fecha = String.Format("La fecha y hora es: {0: hh:mm:sstt dd/MM/yy}", DateTime.Now);
            Console.WriteLine(fecha);
            Console.ReadKey();
        }
    }
}
