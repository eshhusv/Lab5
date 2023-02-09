internal class Program
{
    private static void Main(string[] args)
    {
        double a = 0, b = 0, c = 0;

        try
        {
            Console.Write("Enter Ax: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Enter By: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.Abs(a + b + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)):F2}");

            try
            {
                double d = FuncWith(a, b, c);
                Console.WriteLine($"D = {d:F2}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                FuncExcept(a, b, c);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                double d = FuncOur(a, b, c);
                Console.WriteLine($"D = {d:F2}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }

        double FuncWithout(double a, double b, double c)
        {
            return Math.Abs(a + b + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }

        double FuncWith(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                return Math.Abs(a + b + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            }
            throw new Exception("The distance cannot be negative");
        }

        void FuncExcept(double a, double b, double c)
        {
            double d = 0;
            
            try
            {
                d = Math.Abs(a + b + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine($"D = {d:F2}");
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        double FuncOur(double a, double b, double c)
        {
            if (a >= 0 && b >= 0 && c >= 0)
            {
                return Math.Abs(a + b + c) / Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            }
            throw new Exception("The distance cannot be negative");
        }
    }
}