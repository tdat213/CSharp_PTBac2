internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Nhap he so a: ");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap he so b: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhap he so c: ");
        double c = double.Parse(Console.ReadLine());


        double delta = b * b - 4 * a * c;
        if (delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("Nghiem thu nhat: x1 = {0}", x1);
            Console.WriteLine("Nghiem thu hai: x2 = {0}", x2);
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Nghiem duy nhat: x = {0}", x);
        }
        else
        {
            Console.WriteLine("PT vo nghiem");
        }
    }
}