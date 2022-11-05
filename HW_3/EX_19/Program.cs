// See https://aka.ms/new-console-template for more information
Console.WriteLine("Provide 5 digit number:");
string inputNumber = Console.ReadLine();
if (inputNumber.Length != 5 && inputNumber == "")
{
    Console.WriteLine(inputNumber);
    Console.WriteLine("Something went wrong, please provide a correct number");
    return;
}

isPalindrom(inputNumber);

void isPalindrom(string digit){
for (int i = 0; i < (digit.Length/2); i++)
{
    int j = digit.Length - i - 1;
    
    if (digit[i]==digit[j])
    {   
        continue;
    }
    else 
    {
        Console.WriteLine(digit);
        Console.WriteLine("Something went wrong");
        return;
    }
    
}
Console.WriteLine("Provided digit is palindrom!");
}

