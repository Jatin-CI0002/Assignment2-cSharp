namespace CSharp.Assignment.Part2
{
    class Program
    {
            public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Problem statement Index");
            Console.WriteLine("1. Farey Sequence");
            Console.WriteLine("2. Pilish Strings");
            Console.WriteLine("3. Nico Cipher");
            Console.WriteLine("4. Look and Say");
            Console.WriteLine("5. Linear Equation");
            string assignment = Console.ReadLine();

            switch (assignment)
            {
                case "1":
                    Program.GetFareySequence();
                    break;
                case "2":
                    Program.CreatePilishString();
                    break;
                case "3":
                    Program.CreateNicoCipher();
                    break;
                case "4":
                    Program.GetLookAndSay();
                    break;
                case "5":
                    Program.SolveLinearEquation();
                    break;
            }
        }
            private static void GetFareySequence()
            {
                Console.WriteLine("Enter the number ");
                int n = Int32.Parse(Console.ReadLine());
                string[] sequence = FareySequence.CreateFareySequence(n);

                for (int i = 0; i < sequence.Length; i++)
                    Console.Write(sequence[i] + " ");
            }
            private static void CreatePilishString()
            {
                Console.WriteLine("Enter the String");
                string input = Console.ReadLine();
                string output = PilishStrings.CreatePilishString(input);
                Console.WriteLine(output);
            }
            private static void CreateNicoCipher()
            {
                Console.WriteLine("Enter message");
                string message = Console.ReadLine();
                Console.WriteLine("Enter Key");
                string key = Console.ReadLine();

                Console.WriteLine(NicoCipher.CreateNicoCipher(message, key));
            }
            private static void GetLookAndSay()
            {
                Console.WriteLine("Enter start");
                int start = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter total");
                int total = Int32.Parse(Console.ReadLine());

                List<long> output = LookAndSay.LookAndSaySequence(start, total);
                foreach (long i in output)
                    Console.Write(i + " ");
            }
            private static void SolveLinearEquation()
            {
                Console.WriteLine("Enter the Equation");
                string input = Console.ReadLine();
                string output = LinearEquation.LinearEquationSolver(input);
                Console.WriteLine(output);
            }            
        }
    }
