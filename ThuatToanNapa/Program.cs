bool IsSquareNumber(int n)
{
    int t = (int)Math.Sqrt(n);

    return t * t == n;
}

int CountSquareNumber(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (IsSquareNumber(numbers[i]))
        {
            count++;
        }
    }

    return count;
}

int[] ConvertToArray(string text)
{
    string[] numbers = text.Split(' ');
    int[] arrays = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        int number;
        bool checkDigit = int.TryParse(numbers[i], out number);
        if (!checkDigit)
        {
            return null;
        }
        arrays[i] = number;
    }

    return arrays;
}

string? EnterNumberString()
{
    Console.WriteLine("Enter integer array:");
    return Console.ReadLine();
}

void MainStart()
{

    string? textNumbers = "";

    do
    {
        textNumbers = EnterNumberString().Trim();
    } while (textNumbers == "" || textNumbers == null);

    int[] numbers = ConvertToArray(textNumbers);
    if (numbers == null)
    {
        Console.WriteLine("In array is not integer array");
        return;
    }
    Console.WriteLine("Numbers: {0}", CountSquareNumber(numbers));
}

MainStart();
