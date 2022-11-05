// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, write number");
int number = Convert.ToInt32(Console.ReadLine());

functionCub(number);

void functionCub(int listCub){
for (int a = 1; a < listCub+1; a++)
{ 
        double tabCub = Math.Pow(a, 3);
        System.Console.Write(tabCub + " ");
}
}
