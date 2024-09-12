namespace sum_numbers
{
    internal class Program
    {
        public static int sum(int num1,int num2)
        {
            return num1 + num2;
        }
        public static int multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        public double division(int num1,int num2)
        {
            return num1 / num2;
        }
        //added in local repo => branch feature
        public static int subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            int result=sum(10, 20);
            int Result=multiply(10, 20);
            Console.WriteLine(result.ToString());
            Console.WriteLine(Result.ToString());
            Console.WriteLine("Hello, World!");
        }
    }
}
