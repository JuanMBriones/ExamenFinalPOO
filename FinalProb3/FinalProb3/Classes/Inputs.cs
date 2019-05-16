using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProb3.Classes;

namespace FinalProb3.Classes
{
    class Inputs
    {
        public static string PeticionInput(string nombreVariable) {
            Console.WriteLine("Introduce tu "+nombreVariable+": ");
            return Console.ReadLine();
        }

        public static void Capture() {
            string name = PeticionInput("nombre");
            string lastName = PeticionInput("apellido");

            //Console.WriteLine(name+" "+lastName);
            Validator.Validate(name, lastName);

        }
    }
}
