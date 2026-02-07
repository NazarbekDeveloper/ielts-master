using System.ComponentModel.DataAnnotations;
using IeltsMaster;
OveralBallCalculate();
static bool IsBallValid(decimal ball)
{
    return (ball < 0 || ball > 9);
}
static void OveralBallCalculate()
{   // Obyektlar
    Printer print = new Printer();
    Counter counter = new Counter();

    print.PrintLine("Assalomu alaykum IELTS-MASTER dasturimizga xush kelibsiz ");

    print.PrintLine("IELTS imtihonidagi 4 ta bo'lim bo'yicha ballaringizni kiriting: ");
    string[] ieltsSections = { "Reading", "Listening", "Writing", "Speaking" };


    for (int i = 0; i < ieltsSections.Length; i++)
    {
        print.PrintLine($"{ieltsSections[i]} balingiz(0 - 9): ");
        decimal ball = decimal.Parse(Console.ReadLine());
        if (IsBallValid(ball))
        {
            print.PrintLine($"{ieltsSections[i]} balini xato kiritdingiz. Qaytadan kiring..!!");
            i--;
            continue;
        }
        counter.BallQosh(ball);
    }
    print.PrintLine($"Sizning Overal balingiz: {counter.YigindiQaytar()/ieltsSections.Length}");
}
Console.WriteLine("Assalomu alaykum xush kelibsiz bizninng dasturimizga bu dastur bugungi kundagi amaishlarni bajarishga sizga yaqindan ");
