int digSum (int number)

{

int sum = 0;
while (number != 0)
{
    sum += number % 10;
    number /= 10;
}

    return sum;

}

int dSum = digSum (9012);
Console.WriteLine ($"Сумма цифр в числе = {dSum}");
