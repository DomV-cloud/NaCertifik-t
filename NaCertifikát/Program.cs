using NaCertifikát.Ref_OutParameter;

namespace NaCertifikát
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ref_OutParameters ref_OutParameters = new Ref_OutParameters();

            // Viz. dokumentace sekce 'Rozdíly mezi 'ref' a 'out' '
            // klíčové slovo 'ref':

            string firstNameToChangeWithRef = "Vlasta"; // S.1
            string lastNameToChangeWithRef = "Burián"; // S.1

                                                 // S.2                        // S.2
            ref_OutParameters.ChangeNamesWithRef(ref firstNameToChangeWithRef, ref lastNameToChangeWithRef);

            Console.WriteLine($"Outputs using 'ref' are {nameof(ref_OutParameters.ChangeNamesWithRef)} method:" + "\n" + firstNameToChangeWithRef + "\n" + lastNameToChangeWithRef + "\n");

            ref_OutParameters.ChangeNamesWithVoidAndWithouthRefOrOut(firstNameToChangeWithRef, lastNameToChangeWithRef);

            Console.WriteLine($"Outputs without using 'ref' are {nameof(ref_OutParameters.ChangeNamesWithVoidAndWithouthRefOrOut)} method:" + "\n" + firstNameToChangeWithRef + "\n" + lastNameToChangeWithRef + "\n");


            ref_OutParameters.ChangeNamesWithOut(out string firtNameToChangeWithOut, out string lastNameToChangeWithOut);

            Console.WriteLine($"Outputs using 'out' are {nameof(ref_OutParameters.ChangeNamesWithOut)} method:" + "\n" + firtNameToChangeWithOut + "\n" + lastNameToChangeWithOut + "\n");

        }

    }

}