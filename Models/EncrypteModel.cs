using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Models
{
    public class EncrypteModel
    {
        public static string Text { get; set; }
        public static void Encrypte(string messageEF, string keyEF)
        {
            bool Not_in_alf = false;
            int nomer = 0;
            int nomer_2 = 0;
            int counter = -1;
            string decrypted_text = "";
            char[] message = messageEF.ToLower().ToCharArray();
            char[] key = keyEF.ToLower().ToCharArray();

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < alfavit.Length; j++)
                {
                    if (message[i] == alfavit[j])
                    {
                        nomer = j;
                        counter += 1;
                        break;
                    }
                    if (j == 32)
                    {
                        Not_in_alf = true;
                        decrypted_text += message[i];
                        break;
                    }
                }
                if (!Not_in_alf)
                {
                    for (int j = 0; j < alfavit.Length; j++)
                    {
                        if (key[counter % key.Length] == alfavit[j])
                        {
                            nomer_2 = j;
                            break;
                        }
                    }
                    int shift = nomer + nomer_2;
                    if (shift > 32) { shift -= 33; }
                    decrypted_text += alfavit[shift];
                }
                Not_in_alf = false;
            }
            Text =  decrypted_text;
        }
    }
}
