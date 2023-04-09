int a = 2;
int r = 3;
int n = 5;
Console.WriteLine(SumFirstNElementsInGroup(a, r, n));

int SumFirstNElementsInGroup(int a, int r, int n)
{
    int result = 0;
    for (int numberenter = 0; numberenter < n; numberenter++)
    {
        result += a + r * numberenter;
    }
    return result;
}
    

