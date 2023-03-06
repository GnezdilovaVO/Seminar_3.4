Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = {};

if(n <= 0)
{
    Console.WriteLine("Число не соответсвует задаче");
}
else
{

}

for (int index=0; index <= arr.Length-1; index++)
{
    arr[index] = new Random().Next(0, 1);
}
Console.WriteLine(arr);