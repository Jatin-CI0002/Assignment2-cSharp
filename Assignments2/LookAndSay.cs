using System.Text;

namespace Assignments2
{
    public class LookAndSay
    {
        public static List<long> LookAndSaySequence(int n, int total)
        {
            string start = n.ToString();
            List<long> sequence = new();
            sequence.Add(n);
            for(int itr = 1; itr < total; itr++)
            {
                int count = 0;
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < start.Length; i++)
                {
                    if (i + 1 == start.Length || start[i] != start[i + 1])
                    {
                        sb.Append(++count).Append(start[i]);
                        count = 0;
                    }

                    else
                        count++;
                }
                start = sb.ToString();
                long number = long.Parse(sb.ToString());
                sequence.Add(number);
            }
            return sequence;
        }
    }
}
