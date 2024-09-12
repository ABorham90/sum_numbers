namespace sum_numbers
{
    internal class Program
    {
        public static int sum(int num1,int num2)
        {
            return num1 + num2;
        }
        static void Main(string[] args)
        {
            int result=sum(10, 20);
            Console.WriteLine(result.ToString());
            Console.WriteLine("Hello, World!");
        }
    }
}
