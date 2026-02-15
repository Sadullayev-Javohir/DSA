//int[] a = { 1, 2, 3 };
//int n = a.Length;

//for (int mask = 0; mask < (1 << n); mask++)
//{
//    for (int i = 0; i < n; i++)
//    {
//        if (( mask & ( 1 << i ) ) != 0) Console.Write(a[i] + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadLine();

// Binaryga o'tkazish
//string ToBinary(int n)
//{
//    char[] bits = new char[8];

//    for (int i = 7; i >= 0; i--)
//    {
//        int bit = n % 2;
//        bits[i] = (char)('0' + bit);

//        n >>= 1;
//    }
//    var result = new string(bits);
//    return result;
//}
//Console.WriteLine(ToBinary(3));

// 1
void FindKPosition(int n, int k)
{
    Console.WriteLine((n & (1 << k)) != 0 ? '1' : '0');
}
FindKPosition(64, 5);

// 2
static void ReplaceKPosition1(int n, int k)
{
    Console.WriteLine(n | (1 << k));
}
ReplaceKPosition1(10, 2);

// 3
void ReplaceKPosition0(int n, int k)
{
    int result = n & ~(1 << k);
    Console.WriteLine(result);
}

// 4
void ToggleKPosition(int n, int k)
{
    int result = n ^ (1 << k);
    Console.WriteLine(result);
}

// 5
void BrianKernighan(int n)
{
    while (n > 0)
    {
        n = n & (n - 1);
        count++;
    }
}

Console.WriteLine(n > 0 && (n & (n - 1)) == 0 ? "Power of Two" : "Not Power of Two");


//int n = 13, count = 0;

//while (n > 0)
//{
//    n = n & ( n - 1 );
//    count++;
//}
////while (n > 0)
////{
////    if (n % 2 == 1) count++;
////    n >>= 1;
////}
//Console.WriteLine(count);

int n = 24;



Console.ReadLine();






