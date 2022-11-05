// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, write coordinates separated by commas for A");
string coordinates_a = Console.ReadLine();
Console.WriteLine("Hello, write coordinates separated by commas for B");
string coordinates_b = Console.ReadLine();

findDistance(coordinates_a, coordinates_b);

void findDistance(string a, string b){
    
    string[] a_splited = a.Split(',');
    string[] b_splited = b.Split(',');

    double x_cords = Math.Pow((Convert.ToDouble(a_splited[0])-Convert.ToDouble(b_splited[0])), 2);
    double y_cords = Math.Pow((Convert.ToDouble(a_splited[1])-Convert.ToDouble(b_splited[1])), 2);
    double z_cords = Math.Pow((Convert.ToDouble(a_splited[2])-Convert.ToDouble(b_splited[2])), 2);

    double result = Math.Sqrt(x_cords+y_cords+z_cords);
    Console.WriteLine(Math.Round(result, 2));
}