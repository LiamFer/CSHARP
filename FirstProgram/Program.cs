internal class Program
{
    private static void Main(string[] args)
    {
        //// Variables
        //int? x = 90;
        //double? y = 9.56;
        //bool status = false;
        //char character = '$';
        //string? nome = "asdasd";
        //// A constant variable cannot be changed in the future, its constant afterall
        //const double pi = 3.141516;
        //Console.WriteLine(nome + character + status + y + x);

        //// Type Casting
        //int ycon = Convert.ToInt32(y);
        //double xcon = Convert.ToDouble(x);

        ////Hypotenuse calculator
        //Random r = new Random();
        //// Generating two random values
        //int a = 5;
        //int b = 12;
        //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        //Console.WriteLine($"The Hypotenuse of {a} and {b} is {c}!");

        //string test = "testing_split_method";
        //string[] words = test.Split("_");

        //for (int i = 0; i < words.Length;i++)
        //{
        //    Console.WriteLine(words[i]);
        //}

        //foreach(var word in words)
        //{
        //    Console.WriteLine(word);
        //}

        //Console.WriteLine("What's the Temperature outside?");
        //double temp = Convert.ToDouble(Console.ReadLine());
        //string result = temp >= 24 ? "Hot" : "Cold";
        //Console.WriteLine($"It's really {result} outside dude.");


        // Building a triangle using nested loops
        Console.WriteLine("Input the Triangle Height:");
        int Theight = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Here's your Triangle fella:\n");
        for (int i = 1; i<=Theight;i++)
        {
            string row = "";
            for (int j = 1;j <= i; j++)
            {
                row += "@";
            }
            Console.WriteLine(row);
        }



        Console.ReadKey();
    }
}