
/*
2) Создать несколько видов пароля
Легкий - только буквы в разном регистре
Средний - буквы (разный регистр) и цифры 
Сложный - буквы (разный регистр) и цифры + символы
Адекватный - буквы (разный регистр) и цифры + символы, при этом они не должны повторяться в рамках строки

using Lesson_19_12_2023_Peregruzka;

Parole pas =  new Parole();

Parole psa1 = new Parole(10);

Console.WriteLine(psa1);

psa1[0] = '-';

Console.WriteLine(psa1);
*/





//3) Реализовать классы 
//Простая дробь
//Смешанная дробь
//и обучить их операциям между собой  - + * / < > == 


using Lesson_19_12_2023_Peregruzka;


Console.WriteLine("Простая дробь:");

OrdFract ord1 = new OrdFract(4, 7);

OrdFract ord2 = new OrdFract(6, 10);

OrdFract ord3 = new OrdFract();

Console.WriteLine($"Дробь ord1:");
ord1.PrintFract();
Console.WriteLine($"Дробь ord2:");
ord2.PrintFract();

ord3 = ord1 + ord2;
Console.Write($"ord1 + ord2 = ");
ord3.PrintFract();

ord3 = ord1 - ord2;
Console.Write($"ord1 - ord2 = ");
ord3.PrintFract();

ord3 = ord2 / ord1;
Console.Write($"ord1 / ord2 = ");
ord3.PrintFract();

ord3 = ord2 * ord1;
Console.Write($"ord1 * ord2 = ");
ord3.PrintFract();


Console.WriteLine($"Дробь ord1 > ord2:  \t{ord1 > ord2}");

Console.WriteLine($"Дробь ord1 < ord2:  \t{ord1 < ord2}");

Console.WriteLine($"Дробь ord1 == ord2:  \t{ord1 == ord2}");

Console.WriteLine($"Дробь ord1 != ord2:  \t{ord1 != ord2}");




Console.WriteLine("\nСмешанная дробь:");

MixFract mix1 = new MixFract(9, 5, 8);
MixFract mix2 = new MixFract(7, 3, 11);
MixFract mix3 = new MixFract();

Console.WriteLine($"Дробь mix1:");
mix1.PrintFract();
Console.WriteLine($"Дробь mix2:");
mix2.PrintFract();

mix3 = mix1 + mix2;
Console.Write($"mix1 + mix2 = ");
mix3.PrintFract();

mix3 = mix1 - mix2;
Console.Write($"mix1 - mix2 = ");
mix3.PrintFract();

mix3 = mix1 * mix2;
Console.Write($"mix1 * mix2 = ");
mix3.PrintFract();

mix3 = mix1 / mix2;
Console.Write($"mix1 / mix2 = ");
mix3.PrintFract();


Console.WriteLine($"Дробь mix1 > mix2:  \t{mix1 > mix2}");

Console.WriteLine($"Дробь mix1 < mix2:  \t{mix1 < mix2}");

Console.WriteLine($"Дробь mix1 == mix2:  \t{mix1 == mix2}");

Console.WriteLine($"Дробь mix1 != mix2:  \t{mix1 != mix2}");



