Console.Clear();
Console.WriteLine("Вводите числа");
int a = Convert.ToInt32(Console.ReadLine());
int max = 0;
int max2 = 0;
while(a != 0){
    a = Convert.ToInt32(Console.ReadLine());
    if(a > max){
        max2 = max;
        max = a;
    }
}
Console.WriteLine($"Второй максимум: {max2}");
