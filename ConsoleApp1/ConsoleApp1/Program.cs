// See https://aka.ms/new-console-template for more information

Console.WriteLine("Modification 3");

static double Average(int[] integers)
{
    int sum = 0;
    foreach (var i in integers) sum += i;
    return (double)sum / integers.Length;
}