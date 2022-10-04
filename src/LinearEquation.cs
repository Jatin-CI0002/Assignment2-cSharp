using System.Text.RegularExpressions;

namespace CSharp.Assignment.Part2
{
    public class LinearEquation
    {
        public static string LinearEquationSolver(string input)
        {
            List<string> leftSide = new List<string>();
            List<string> rightSide = new List<string>();

            input = Regex.Replace(input, "-", "+-");
            string[] equation = Regex.Split(input, "=");
            equation[0] = equation[0].TrimStart('+');
            equation[1] = equation[1].TrimStart('+');

            if (!equation[0].Contains("+")) 
                leftSide.Add(equation[0]);

            else
                leftSide = Regex.Split(equation[0], @"\+").ToList();

            if (!equation[1].Contains("+"))
                rightSide.Add(equation[1]);

            else
                rightSide = Regex.Split(equation[1], @"\+").ToList();

            for (int i = leftSide.Count - 1; i >= 0; i--)
            {
                if (leftSide[i] == "x" || leftSide[i] == "-x") 
                    leftSide[i] = (leftSide[i] == "x") ? "1x" : "-1x";

                if (!leftSide[i].Contains('x'))
                {
                    rightSide.Add((-1 * int.Parse(leftSide[i])).ToString());
                    leftSide.RemoveAt(i);
                }
            }

            for (int i = rightSide.Count - 1; i >= 0; i--)
            {
                if (rightSide[i].Contains('x'))
                {
                    if (rightSide[i] == "x" || rightSide[i] == "-x")
                        leftSide.Add(rightSide[i] == "x" ? "-1x" : "1x");

                    else
                        leftSide.Add((-1 * int.Parse(rightSide[i].TrimEnd('x'))).ToString());

                    rightSide.RemoveAt(i);
                }
            }

            double leftSum = leftSide.Sum(x => int.Parse(x.TrimEnd('x')));
            double rightSum = rightSide.Sum(x => int.Parse(x));

            if (leftSum > 1 || leftSum < 0)
                return $"x = {Math.Round(rightSum / leftSum, 2)}";

            if (leftSum == 1)
                return $"x = {rightSum}";

            if (leftSum == 0 && rightSum > 0)
                return $"No solution"; 

            if (leftSum == 0 && rightSum < 0)
                return $"No solution"; 

            if (leftSum == 0 && rightSum == 0)
                return $"Infinite solutions"; 

            return "Invalid Input";
        }
    }
}
