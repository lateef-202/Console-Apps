// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.Write("Enter Year(e.g 2002): ");// Question 20
int Year = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Month(e.g 1-12): ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Day of the Month(e.g 1-31): ");
int Q = Convert.ToInt32(Console.ReadLine());

int J = Year / 100;
int K = Year % 100; 
 if (M==1)
 {
    M = 13;
    Year--;
 }

 if (M==2)
 {
    M = 14;
    Year--;
 }
int a1 = 26 * (M + 1)/100;
int a2 = K/4;
int a3 = J/4;
int a4 = 5 * J;
int Day = (Q + a1 + K + a2 + a3 + a4) % 7;

switch (Day)
{
    case 0:
    System.Console.WriteLine($"Saturday ,{Q}/{M}/{Year}.");
    break;

     case 1:
    System.Console.WriteLine($"Sunday ,{Q}/{M}/{Year}.");
    break;

     case 2:
    System.Console.WriteLine($"Monday ,{Q}/{M}/{Year}.");
    break;

     case 3:
    System.Console.WriteLine($"Tuesday ,{Q}/{M}/{Year}.");
    break;

     case 4:
    System.Console.WriteLine($"Wednesday ,{Q}/{M}/{Year}.");
    break;

     case 5:
    System.Console.WriteLine($"Friday ,{Q}/{M}/{Year}.");
    break;

    case 6:
    System.Console.WriteLine($"Friday ,{Q}/{M}/{Year}.");
    break;

    default:
    System.Console.WriteLine("Syntax Error! .");
    break;
}
 
