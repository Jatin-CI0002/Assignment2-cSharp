namespace Assignments2
{
    public class PilishStrings
    {
        public static string CreatePilishString(string input)
        {
            string Pi = "314159265358979";
            //int[] Pi = new int[15] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9 };
            int index = 0;
            int piIndex = 0;
            string output = "";
            string dynamicString = "";

            for (int i = 0; i < input.Length; i++)
            {
                dynamicString += input[i];
                index++;

                if (index >= Pi[piIndex] - '0')
                {
                    index = 0;
                    if (piIndex != 0)
                        output += " ";
                    output += dynamicString;
                    piIndex++;
                    if (piIndex >= 15)
                        return output;

                    dynamicString = "";
                }
            }
                if(dynamicString.Length != 0)
                {
                    while(index < Pi[piIndex] - '0')
                    {
                        dynamicString += input[input.Length - 1];
                        index++;
                    }

                    if (piIndex != 0)
                        dynamicString += " ";
                    output += dynamicString;
                }
            
            return output;
        }
    }
}
