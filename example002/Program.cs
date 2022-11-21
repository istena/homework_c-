Console.Clear();
Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
if (a>b){
    Console.Write("Максимально число из двух ");
    Console.Write(a);
}
else if(b>a){
    Console.Write("Максимально число из двух ");
    Console.Write(b);
}
else 
Console.Write("Оба числа равны ");
