Console.Clear();
Console.WriteLine("Введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
if( a < 6 && a > 0){
    Console.WriteLine("Сегодня будний день");
}
else if(a < 8 && a > 5){
    Console.WriteLine("Ура! Сегодня выходной");
}
else{
    Console.WriteLine("Вы ввели некоректный день");
}