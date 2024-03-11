Console.WriteLine("Eded daxil edin ");

int eded = Convert.ToInt32(Console.ReadLine());
int a = 1;
int hasil = 1;

while (eded > 0)
{
    a = eded % 10;
    hasil *= a;
    eded /= 10;
}

Console.WriteLine(hasil);