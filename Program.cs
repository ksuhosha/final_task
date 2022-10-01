Console.WriteLine("введите количесво строк:");
int N= int.Parse(Console.ReadLine());
string[] array = new string[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine($"введите {i+1}/{N}");
    array[i] = Console.ReadLine()!;
}
