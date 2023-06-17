namespace review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 2, 3, 7, 8, 10, 9 };
            int count = 0;
            int sum = 0;
            for (int i = arr.Length-1; i >0; i--)
            {
               
                if (arr[i] %2 == 0 && count <2)
                {
                    sum += arr[i];
                    count++;
             

                }
                
            }
            Console.WriteLine(sum);
        }
    }
}