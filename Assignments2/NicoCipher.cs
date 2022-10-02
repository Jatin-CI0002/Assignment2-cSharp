
using System.Collections.Generic;
using System.Linq;

namespace Assignments2
{
    public class NicoCipher
    {
        public static string CreateNicoCipher(string message, string key)
        {
            int index = 0;
            string outputString = "";
            string[] messageArray = new string[key.Length];
            List<KeyValuePair<char, string>> dictionary = new();

            while(index < message.Length)
            {
                for(int i = 0; i < key.Length; i++)
                {
                    if (index < message.Length)
                        messageArray[i] += message[index];

                    else
                        messageArray[i] += " ";
                    index++;
                }
            }

            for (int i = 0; i < key.Length; i++)
                dictionary.Add(new KeyValuePair<char, string>(key[i], messageArray[i]));

            dictionary = dictionary.OrderBy(x => x.Key).ToList();

            for (int i = 0; i < dictionary.First().Value.Length; i++)
            {
                foreach (var item in dictionary)
                    outputString += item.Value[i];
            }

            return outputString;
        }
        }
    }

