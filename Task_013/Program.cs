Console.Clear();
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 100){
    Console.WriteLine("Третьего числа нет!");
}
else 
while(a > 1000 ){
    a /= 10;
}
Console.WriteLine(a % 10);