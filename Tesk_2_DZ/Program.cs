// Напишите программу , которая принимает на    452 > 11
// вход число и выдает сумму цифр в числе.       82 > 10
//                                             9012 > 12
Console.WriteLine("Введите число ");
int Namber = Convert.ToInt32(Console.ReadLine());

int Summa (int N)
{
    int res = 0;
    for(int i = 0; N > 0; i++)
    {
        int S = N % 10;
        res = res + S;
        N =N / 10;
    }
    return res;
}

Console.WriteLine(Summa(Namber));