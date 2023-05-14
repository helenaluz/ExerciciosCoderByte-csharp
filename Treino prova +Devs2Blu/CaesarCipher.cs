using System;

/**
 * Have the function CaesarCipher(str,num) take the str parameter and perform a Caesar Cipher shift on it using
 * the num parameter as the shifting number. A Caesar Cipher works by shifting each letter in the string N places
 * down in the alphabet (in this case N will be num). Punctuation, spaces, and capitalization should remain intact.
 * For example if the string is "Caesar Cipher" and num is 2 the output should be "Ecguct Ekrjgt".
 *
 * @author Nick Livens
 */
namespace Treino_prova__Devs2Blu
{
    internal class CaesarCipher
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Informe o número: ");
            int num = int.Parse(Console.ReadLine());

            char[] letras = str.ToCharArray();

            for (int i = 0; i < letras.Length; i++)
            {
                int hold = 0;
                if (char.IsLetter(letras[i]))
                {
                    hold = (int)letras[i] + num;
                }
                //Checando o Z
                if (char.IsUpper(letras[i]) && hold > (int)'Z' || char.IsLower(letras[i]) && hold > (int)'z') hold -= 26;

                letras[i] = (char)hold;
            }
            string Newstr = new string(letras);

            Console.WriteLine(str + " ==> " + Newstr);
            Console.ReadKey();
        }
    }
}
