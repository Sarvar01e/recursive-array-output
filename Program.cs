namespace recursive_array_output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
           // arrayoutput(array);
            int a = 515;
            //sumreturner(ref a);
            string value = Console.ReadLine();
            summer(ref value);
     
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
        static void sumreturner(ref int inputvalue) 
        {
            string valueout = Convert.ToString(inputvalue);
            int sum = 0;
            for (int i = 0; i < valueout.Length; i++)
            {
                sum = sum+inputvalue%10;
                inputvalue = inputvalue / 10;
                if (i == valueout.Length - 1)
                {
                sum = sum + inputvalue;
                }
            }
            inputvalue = sum;
            Console.WriteLine(sum);
        }
        static void summer(ref string value1, int end =0, int sum=0) 
        {
            int inputvalue = Convert.ToInt32(value1);
            sum = sum + inputvalue % 10;

            inputvalue = inputvalue / 10;
            string changed;
            changed = Convert.ToString(inputvalue);
            if (end > value1.Length)
            {
                sum = sum + inputvalue % 10;
                Console.WriteLine("Sum of numbers is\t" + sum);
                return;
            }
            end++;
            summer(ref changed, end, sum);
            
        }
    }
}