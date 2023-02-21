// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] a = {1,2,3};
int[] b = {3,4,5};
int[] c = new int[a.Length + b.Length];

for(int x = 0; x < b.Length; x++)
{
    c[x] = b[x];
}

int y;
y = 0;
for(int x = b.Length; x < c.Length; x++)
{
    c[x] = a[y];
    y++;
}

Array.Sort(c);

foreach(var val in c)
{
    Console.WriteLine($"Valor {val}");
}

// Actualizando
