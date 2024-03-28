using System;
using System.Security.Cryptography.X509Certificates;
class Program{
    static void Main(string[] arg){
        int n = 8;
        double[] xValues = new double[n];
        double[] fValues = new double[n];
        double x;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"введите число x{i + 1}:");


            x = double.Parse(Console.ReadLine());
            xValues[i] = x;

            if (x < -4)
            {
                fValues[i] = ((Math.Pow(x, 2) - 1 / x) / (3 * x)) * ((x + 3) / (1 + x));
            }
            else if (x < 6 * Math.PI && x >= -4)
            {
                fValues[i] = Math.Pow(x - 5, 2) * Math.Pow(Math.Sin(2 * x), 2);

            }
            else
            {
                fValues[i] = 35.0 / 3;

            }

        }

        double y;
        int meow = 0 ;
        
        for(int i=0;i<n;i++)
        {
            x = xValues[i];
            y = fValues[i];
            if ((Math.Pow(x, 2) + Math.Pow(y, 2))<= Math.Pow(4, 2));
            {
                if(x>=0 && y<=0)
                {
                    if(y>=x-4)
                    {
                        meow++;
                    }
                }
                if(x<=0 && y >=0)
                {
                    if(x<=-2)
                    {
                        meow++;
                    }
                }
                if (x<=0 && y <=0)
                {
                    meow++;
                }
            }
        }
        Console.Write("x\t\tf(x)");
        for(int i=0;i<n; i++)
        {
            Console.WriteLine($"{xValues[i]}\t\t{fValues[i]}");
        }
        Console.WriteLine($"количество точек лежащих в заштрих области: {meow}");
    }

}