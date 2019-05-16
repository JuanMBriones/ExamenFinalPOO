using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProb3.Classes
{
    class Validator
    {
        public static void Validate(string name, string lastName) {
            try
            {
                if (name.Length <= 2 || lastName.Length <= 2)
                {
                    throw new FormatException();
                }
            } catch(FormatException e)
            {
                Console.WriteLine("nombre/apellido no válido");
            }
            Console.ReadKey();
        }
    }
}
