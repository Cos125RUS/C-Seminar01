//Показать вторую цифру трёхзначного числа

int num = 347;

num /= 10;
num %= 10;

Console.WriteLine(num);