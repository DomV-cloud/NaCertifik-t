using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaCertifikát.Ref_OutParameter
{
    /// <summary>
    /// Práce s klíčovými slovy 'ref' a 'out'
    /// Příklad simuluje případ, kdy chci použít metodu bez návratového typu (void), ale přesto chci hodnoty vstupních parametrů změnit.
    /// 
    /// Proč použít 'ref' a 'out'
    /// - předávají proměnné/hodnoty funkcím za cílem je změnit
    /// 
    /// Rozdíly mezi 'ref' a 'out':
    /// 
    /// 'ref':
    ///  - proměnná musí být inicializovaná před předáním funkce (S.1)
    ///  - při implementaci metody je taktéž nutné použít klíčovo slovo 'ref' (S2)
    ///  - může být použito pro jakýkoliv datový typ nebo strukturu (Třídu - Class)
    ///  - mění proměnnout/hodnotu v RÁMCI FUNKCE (S.3)
    ///  - předávám hodnotu referencí (referuju -> ref)
    ///  - související metody: ChangeNamesWithRef, ChangeNamesWithVoidAndWithouthRefOrOut
    /// 'out':
    /// - velmi podobné 'ref'
    /// - proměnná nemusí být inicializovaná před předáním funkce
    /// - říkám, jaká hodnota bude výsledná (output -> out)
    /// - mění proměnnout/hodnotu v RÁMCI FUNKCE
    /// - související metody: ChangeNamesWithOut, ChangeNamesWithVoidAndWithouthRefOrOut
    /// </summary>
    public class Ref_OutParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outFirstName"></param>
        /// <param name="outLastName"></param>
        public void ChangeNamesWithOut(out string outFirstName, out string outLastName)
        {
            // Jak je vidět v implementaci, není třeba inicializovat proměnnou pro použití
            // jako tomu je u klíčového slova 'ref'.
            outFirstName = "Kevin";
            outLastName = "Costner";
        }
        /// <summary>
        /// Metoda, která ukazuje mění proměnné/hodnoty v rámci funkce za použití klíčového slova 'ref'.
        /// </summary>
        /// <param name="refFirstName"></param>
        /// <param name="refLastName"></param>
        public void ChangeNamesWithRef(ref string refFirstName, ref string refLastName)
        {
            Console.WriteLine($"Inputs before change are {nameof(ChangeNamesWithRef)} method:" + "\n" + refFirstName + "\n" + refLastName + "\n");
            refFirstName = "Karel"; // S.3
            refLastName = "Kryl"; // S.3
        }
        /// <summary>
        /// Metoda bez návratového typu (void), která mění vstupní parametry 'jméno' a 'příjmení'.
        /// V tomto případě se nepoužívá ani jedno s klíčových slov 'out' nebo 'ref'
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void ChangeNamesWithVoidAndWithouthRefOrOut(string firstName, string lastName)
        {
            Console.WriteLine($"Inputs before change using 'ref' are {nameof(ChangeNamesWithVoidAndWithouthRefOrOut)} method:" + "\n" + firstName + "\n" + lastName + "\n");

            firstName = "Andrejko";
            lastName = "Majerko";
        }
        /// <summary>
        /// Metoda s návratovým typem (return), která mění vstupní parametry 'jméno' a 'příjmení'.
        /// V tomto případě se nepoužívá ani jedno s klíčových slov 'out' nebo 'ref'
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public string ChangeNamesWithReturnAndWithouthRefOrOut(string firstName, string lastName)
        {
            Console.WriteLine($"Inputs before withouth using 'ref' change are {nameof(ChangeNamesWithReturnAndWithouthRefOrOut)} method:" + "\n" + firstName + "\n" + lastName + "\n");

            firstName = "Andrejko";
            lastName = "Majerko";

            return $"Names inside {nameof(ChangeNamesWithReturnAndWithouthRefOrOut)} the method:" + "\n" + firstName + "\n" + lastName;
        }
    }
}
