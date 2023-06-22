// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;
string str = number.ToString();

if (amount < 5 | amount > 5){
    Console.WriteLine("Это не пятизначное число");
}
else{
    if (str[0] == str[4] && str[1] == str[3]){
        Console.WriteLine("Да, это число является палиндромом");
    }
    else{
        Console.WriteLine("НЕ палиндром");
    }

    // for (int i = 0; i < 5; i++)
    // {
    //     for (int j = 4; j >= 0; j--)
    //     {
    //        System.Console.WriteLine("Это палиндром");
    //     }
    // }
}



