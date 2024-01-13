int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = i + 1;
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int GetSumOfElements(int[] arr)
{

    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int product = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        product *= arr[i];
    }
    return product;
}

FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine(sum);
Console.WriteLine(product);