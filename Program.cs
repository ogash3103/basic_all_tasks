using System;


//=================  task 1 start

System.Console.Write("Radiusni qiymatini kiriting: ");
       decimal radius = Convert.ToDecimal(Console.ReadLine());

        decimal pi = (decimal)Math.PI;

        decimal S = pi * (decimal)(radius * radius); 
        decimal L = 2 * pi * (decimal)radius; 

        System.Console.WriteLine($"Doiraning yuzasi: {S}");
        System.Console.WriteLine($"Doiraning uzunligi: {L}");

// task 1 end


// task 2 start

System.Console.Write("Qiymat kiriting: ");
double qiymat = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Kurs qiyimatini kiriting (so'm): ");
double kurs = Convert.ToDouble(Console.ReadLine());

// hisob kitobda decimal ishlatish kk
decimal summa = (decimal)(qiymat * kurs);

System.Console.WriteLine($"natija: {summa} so'm");

// ============= task 2 end



// task 3 start

// inoput orqali kirgizishlar
System.Console.Write("Tug'ulgan yillingizni kirgizing: ");
int bornYear = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Hozirgi yilni kirgizing: ");
int currentYear = Convert.ToInt32(Console.ReadLine());

// hisoblash
int yillar = currentYear - bornYear;
int kunlar = yillar * 365;

System.Console.WriteLine($"Hozirgi yilgacha: {kunlar} kun utdi");

// task 3 end






// task 2 end
