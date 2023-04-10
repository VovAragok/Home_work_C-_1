//1. Напишите программу, которая на вход принимает 2 числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("напишите первое число ");
string s1 = Console.ReadLine();
int i= 0;
Console.Write("напишите второе число ");
string s2 = Console.ReadLine();
int i2 = 0;
if (int.TryParse(s1, out i) && int.TryParse( s2 ,out i2)){
    if (i > i2){
        System.Console.WriteLine($" число {i} больше чем {i2}");
    }
    else if (i == i2){
        System.Console.WriteLine("числа равны");
    }
    else{
        System.Console.WriteLine($"число {i2} больше чем {i}");
    }
}
else {System.Console.WriteLine("упс");}




