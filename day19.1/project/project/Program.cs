//=== Polynomial murakkablik

//int[] a = { 1, 2, 3, 4, 5 };
//int count = 0;

//for (int i = 0; i < a.Length; i++)
//{
//    for (int j = 0; j < a.Length; j++)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);
//Console.ReadLine();

//=== Exponential murakkablik
//int[] a = { 1, 2, 3 }
//;
//int n = a.Length;

//for (int mask = 0; mask < (1 << n); mask++)
//{
//    for (int i = 0; i < mask; i++)
//    {
//        if ((mask & (1 << i)) != 0)
//        {
//            Console.Write($"{a[i]} ");
//        }
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();

//int number = 13;
//string b = Convert.ToString(number, 16);
//Console.WriteLine(b);

//string binary = "0010";
//int number = Convert.ToInt32(binary, 2);
//Console.WriteLine(number);

//Console.ReadLine();

//int number = 7;

//string binary = Convert.ToString(number, 2).PadLeft(8, '0');
//Console.WriteLine(binary);
//Console.ReadLine();

//int number = 13;
//string binary = "";

//while (number > 0)
//{
//    int remainder = number % 2;
//    binary = remainder + binary;
//    number /= 2;
//}

//Console.WriteLine(binary);

//string binary = "10110";
//int number = 0;

//foreach(char bit in binary)
//{
//    number = number * 2 + (bit - '0');
//}
//Console.WriteLine(number);
//Console.ReadLine();

//int number = 110;
//string binary = Convert.ToString(number, 2).PadLeft(8, '0');
//Console.WriteLine(binary);
//Console.ReadLine();
//Console.WriteLine(ToBinary(-11));


//string ToBinary(int number)
//{
//    if (number == 0) return "0";
//    string result = "";

//    while (number > 0)
//    {
//        int bit = number % 2;
//        result = bit + result;
//        number /= 2;
//    }
//    return result;
//}

//Console.WriteLine(BitwiseAnd(3, 2));

//Console.ReadLine();

//int BitwiseAnd(int a, int b)
//{
//    int result = 0;
//    int place = 1;

//    while (a > 0 || b > 0)
//    {
//        int bitA = a % 2;
//        int bitB = b % 2;

//        int andBit = (bitA == 1 && bitB == 1) ? 1 : 0;

//        result += andBit * place;

//        place *= 2, a /= 2, b /= 2;
//    }
//    return result;
//}

//=== Factorial murakkablik
void Permute(int[] a, int start)
{
    if (start == a.Length)
    {
        Console.WriteLine(string.Join(" ", a));
return;
    }

    for (int i = start; i < a.Length; i++)
{
    (a[start], a[i]) = (a[i], a[start]);

    Permute(a, start + 1);
    (a[i], a[start]) = (a[start], a[i]);
}
}

int[] a = { 1, 2, 3 };
Permute(a, 0);
Console.ReadLine();