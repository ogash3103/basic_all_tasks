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



// task 4 start  Kalkulyator

        Console.Write("Birinchi raqamni kirgizing: ");
        decimal num1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Operatsiyani kiriting (+, -, *, /): ");
        char operator1 = Convert.ToChar(Console.ReadLine()!);

        Console.Write("Ikkinchi raqamni kirgizing: ");
        decimal num2 = Convert.ToDecimal(Console.ReadLine());

        decimal result = 0;

        if (operator1 == '+')
        {
            result = num1 + num2;
        }
        else if (operator1 == '-')
        {
            result = num1 - num2;
        }
        else if (operator1 == '*')
        {
            result = num1 * num2;
        }
        else if (operator1 == '/')
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Xato: Nolga bo'linish mumkin emas.");
            }
        }
        else
        {
            Console.WriteLine("Noto'g'ri operatsiya.");
        }

        Console.WriteLine($"{num1} {operator1} {num2} = {result}");

// 4 task end




// 5 task start

System.Console.WriteLine("Dastur maqsadi: Dastur 1 dan N gacha bo‘lgan barcha sonlar yig/‘indisini hisoblab beradi!");
System.Console.Write("N musbat butun son kiriting: ");
int inputNum = Convert.ToInt32(Console.ReadLine());

int sum = inputNum * (inputNum + 1) / 2;

Console.WriteLine($"1 dan {inputNum} gacha bo'lgan sonlar yig'indisi: {sum}");

// 5 task end


// 6 task start 

System.Console.Write("Son kirgizing va u sizga jusft || toq dagan javob qaytaradi: ");
int input = Convert.ToInt32(Console.ReadLine());
string hisobla = input % 2 == 0 ? "juft" : "toq";
System.Console.WriteLine(hisobla);




// 6 task end