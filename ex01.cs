// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 4;
int [] arr = new int[M];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

// Console.Write($"{arr}");
// Виталий, подскажите, пожалуйста, а как его распечать этот массив,
// введенный пользователем?(вопрос ради интереса)
int res = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0) res++;
}
Console.WriteLine(res);