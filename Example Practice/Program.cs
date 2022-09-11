using Example_Practice;

static void Main()
{
    ProblemSeven pe = new ProblemSeven();
    Console.WriteLine("How many Entries?");
    int numOfReq = Convert.ToInt32(Console.ReadLine());

    double[] userInput = pe.RequestInput(numOfReq);

    double multOut = pe.MultiplyX(userInput);
}

namespace Example_Practice
{

    public class ProblemSeven
    {
        // double[] -> double
        // produce the result of all 3 inputs multiplied together

        public double MultiplyX(double[] entryArray)  // stub
        {
            double result = 1;

            for (int i = 0; i < entryArray.Length; i++)
            {
                result *= entryArray[i];
            }
            return result;
        }

        // double[] -> double
        // produce the result of x divisions (in order of entry)
        // public double DivideX(double[] entryArray) { return 0; } // stub
        public double DivideX(double[] entryArray)
        {
            double result = entryArray[0];
            for(int i = 1; i < entryArray.Length; i++)
            {
                    result /= entryArray[i];
            }

            return result;
        }

        // double[] -> double
        // produce the result of the addition of x values
        // public double AddX(double[] entryArray) { return 0; } // stub
        public double AddX(double[] entryArray)
        {
            double result = entryArray[0];
            for (int i = 1; i < entryArray.Length; i++)
            {
                result += entryArray[i];
            }

            return result;
        }

        // double[] -> double
        // produce the result of x divisions (in order of entry)
        // public double SubtractX(double[] entryArray) { return 0; } // stub
        public double SubtractX(double[] entryArray)
        {
            double result = entryArray[0];
            for (int i = 1; i < entryArray.Length; i++)
            {
                result -= entryArray[i];
            }

            return result;
        }

        // int -> double[]
        // Request doubles from the user the number of times the input specifies
        public double[] RequestInput(int numberOfEntries) // this is the stub
        {
            double[] output = new double[numberOfEntries];
            for (int i = 0; i < numberOfEntries; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                output[i] = Convert.ToDouble(Console.ReadLine());
            }

            return output;
        }
    }

    public class ProblemEight
    {
        // integer -> int[10]
        // Produce the multplication table (through 10) of the entry

        //public int[] MultiplyTable(int entry) 
        //{ 
        //  int[] result = { 0, 0}; 
        //  return result; 
        //} //stub
        
        public int[] MultiplyTable(int entry)
        {
            int[] result = new int[10];

            for (int i = 0; i < 10; i++)
            {
                result[i] = entry * (i + 1);
            }
            return result;
        } 

    }
}





