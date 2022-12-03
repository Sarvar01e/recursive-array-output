namespace recursive_array_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            arrayoutput(array);
     
        }

        static void arrayoutput (int[] inputarray, int index =0, int sum = 0) 
        {
            Console.Write(inputarray[index]+"\t");
            sum = sum + inputarray[index];
            index++;
            if (index == inputarray.Length)
            {
                Console.WriteLine("\n\nSum is\t" + sum);
                return;
            }
            arrayoutput(inputarray,index,sum);
        }
        static void find_the_sum_of_the_digits(int inputvalue) 
        {
            string valueout = Convert.ToString(inputvalue);


        }
    }
}