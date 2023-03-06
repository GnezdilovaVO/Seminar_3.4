int[] arr = { 1, 0, 1, 0, 0 };
double number = 0;
int a = arr.Length - 1;
for (int i = 0; i < arr.Length; i++)
{
    number = number + arr[i] * Math.Pow(2, a);
    a = a - 1;
}
Console.WriteLine(number);