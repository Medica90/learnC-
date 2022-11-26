//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введи трехзначное число:");
int SddigitinNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(SddigitinNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);