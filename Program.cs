namespace HelloWorld
{
    class Program
    {
        public static string FizzBuzz(int i)
        {
            return i switch
            {
                var x when is5(x) && is3(x) => "FizzBuzz",
                var x when is5(x) => "Fizz",
                var x when is3(x) => "Buzz",
                _ => i.ToString()
            };

            static bool is3(int x)
            {
                return x % 3 == 0;
            }
            static bool is5(int x)
            {
                return x % 5 == 0;
            }
        }   

        public static void Main(string[] args)
        {

            for (var i = 0; i <= 100; ++i)
            {
                Console.WriteLine(FizzBuzz(i));
            }
            var name = Console.ReadLine();
        }
    }
}