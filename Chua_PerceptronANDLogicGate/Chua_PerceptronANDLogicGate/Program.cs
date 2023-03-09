using Chua_PerceptronANDLogicGate;
public class Program
{
    static void Main(string[] args)
    {
        // Define the inputs and the corresponding targets for the AND gate
        double[][] inputs =
        {
            new double[] {0, 0},
            new double[] {0, 1},
            new double[] {1, 0},
            new double[] {1, 1}
        };

        int[] targets = { 0, 0, 0, 1 };

        // Create a new perceptron with two inputs and a learning rate of 0.1
        Perceptron p = new Perceptron(2, 0.1);

        // Train the perceptron for 100 epochs
        p.Train(inputs, targets, 100);

        // Test the perceptron with user input
        while (true)
        {
            Console.Write("Enter input 1 (0 or 1): ");
            double input1;
            while (!double.TryParse(Console.ReadLine(), out input1) || (input1 != 0 && input1 != 1))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter input 1 again (0 or 1): ");
            }

            Console.Write("Enter input 2 (0 or 1): ");
            double input2;
            while (!double.TryParse(Console.ReadLine(), out input2) || (input2 != 0 && input2 != 1))
            {
                Console.WriteLine("Invalid input.");
                Console.Write("Enter input 1 again (0 or 1): ");
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Output: " + p.Predict(new double[] { input1, input2 }));

            while (true)
            {
                Console.Write("Test again? (y/n): ");
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    break;
                }
                else if (response == "n")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Console.Write("Please enter 'y' or 'n'.");
                }
            }
        }
    }
}