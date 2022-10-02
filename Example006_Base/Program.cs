int a = 1;
int b = 2;
int c = 6;
int e = 8;
int d = 4;

int max = a;
if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = e;
if (d > max) max = d;

Console.Write("max = ");
Console.WriteLine(max);