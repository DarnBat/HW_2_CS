Console.Clear();
Console.WriteLine("Вводите числа");
int a = Convert.ToInt32(Console.ReadLine());
int max = a; 
int max2 = 0;
while(a != 0){
 a = Convert.ToInt32(Console.ReadLine());
    if(a > max){
        max2 = max;
        max = a;
    }
    else if(a > max2){
        max2 = a;
    }
}
Console.WriteLine($"Второй максимум: {max2}");
Console.WriteLine($"Максимум: {max}");