//2. Напишите программу, которая на вход принимает 3 числа и выдаёт максимальное из этих чисел.
Console.Write("напишите первое число ");
string s1 = Console.ReadLine();
int i= 0;
Console.Write("напишите второе число ");
string s2 = Console.ReadLine();
int i2 = 0;
Console.Write("напишите третье число ");
string s3 = Console.ReadLine();
int i3 = 0;


if (int.TryParse(s1, out i) && int.TryParse( s2 ,out i2)&& int.TryParse(s3, out i3)){
    if (i >= i2 && i>=i3){
        System.Console.WriteLine($"число {i} максимальное ");
        }
    else if (i2 >= i && i2>=i3) {
        System.Console.WriteLine($"число {i2} максимальное ");
        }
    else if (i3 >= i && i3>=i2) {
        System.Console.WriteLine($"число {i3} максимальное");
        }
}
else {System.Console.WriteLine("упс");}