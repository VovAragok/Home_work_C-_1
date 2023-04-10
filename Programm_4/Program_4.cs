// 4. Напишите программу, которая на вход принимает число N и выдаёт все чётные числа от 1 до N 
Console.Write("введите число: ");
string s = Console.ReadLine();
int n;
if (int.TryParse(s, out n)){
    for (int i = 1; i <= n; i++){
        if( i %2 ==0){
            System.Console.WriteLine(i);
}}}

else{ System.Console.WriteLine("упс");}