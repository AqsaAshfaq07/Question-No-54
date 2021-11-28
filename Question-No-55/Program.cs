// See https://aka.ms/new-console-template for more information

int a = 10, b = 20, c = 15, d = 8, e = 40;

//(1)
Console.WriteLine((a + b / (c - 5)) / ((d + 7) / (e - 37) % 3));

//(2)
Console.WriteLine(a + b / c - 5 / d + 7 / e - 37 % 3);

//(3)
Console.WriteLine(a * (b * b) - (c * b) + d);
