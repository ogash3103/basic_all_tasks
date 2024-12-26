using System;

System.Console.Write("Radiusni qiymatini kiriting: ");
       decimal radius = Convert.ToDecimal(Console.ReadLine());

        decimal pi = (decimal)Math.PI;

        decimal S = pi * (decimal)(radius * radius); 
        decimal L = 2 * pi * (decimal)radius; 

        System.Console.WriteLine($"Doiraning yuzasi: {S}");
        System.Console.WriteLine($"Doiraning uzunligi: {L}");

        