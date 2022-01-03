using System; 

class URI {

    static void Main(string[] args) { 

        String[] v = Console.ReadLine().Split();
            double a = double.Parse(v[0]), b = double.Parse(v[1]), c = double.Parse(v[2]);
            if ((b-c) < a && a < (b+c) && (a-c) < b && b < (a+c)&&(a-b) < c && c < (a+b))
            {
                Console.WriteLine("Perimetro = " + (a+b+c).ToString("0.0"));
            }
            else
            {
                Console.WriteLine("Area = " + (((a + b) * c) / 2).ToString("0.0"));
            }
    }

}