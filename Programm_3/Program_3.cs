//3. Напишите программу, которая на вход принимает число и выдаёт, ( является ли число чётным)
Console.Write("введите число: ");
string s = Console.ReadLine();
int i;
if (int.TryParse(s, out i)){
     if (i % 2 == 0) {
        System.Console.WriteLine($"число {i} - чётное");
        }
    else {
        System.Console.WriteLine($"число {i} - нечетное");
        }
}
else{ System.Console.WriteLine("упс");}



