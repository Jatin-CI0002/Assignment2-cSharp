namespace Assignments2
{
    public class FareySequence
    {
        public static string[] CreateFareySequence(int n)
        {
            SortedDictionary<double, string> sequence = new SortedDictionary<double, string>();

            for(double denominator = 1; denominator <= n; denominator++)
            {
                for(double numerator = 1; numerator < denominator; numerator++)
                {
                    if(!sequence.ContainsKey(numerator/denominator))
                        sequence.Add(numerator/denominator, numerator + "/" + denominator);
                }
            }

            sequence.Add(0, "0/1");
            sequence.Add(1, "1/1");

            return sequence.Values.ToArray();
        }
    }
}
