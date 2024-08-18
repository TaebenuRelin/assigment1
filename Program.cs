String nilai_a;
String nilai_b;
double konversi_a, konversi_b, c, d, e, f;
Console.WriteLine("Masukan Nilai a = ");
nilai_a = Console.ReadLine();
Console.WriteLine("Masukan Nilai b = ");
nilai_b = Console.ReadLine();
konversi_a = Convert.ToDouble(nilai_a);
konversi_b = Convert.ToDouble(nilai_b);

c = konversi_a + konversi_b;
d = konversi_a - konversi_b;
e = konversi_a * konversi_b;
f = konversi_a / konversi_b;

Console.WriteLine("c = hasil penjumlahan a + b adalah {0} ", c);
Console.WriteLine("d = hasil pengurangan a - b adalah {0} ", d);
Console.WriteLine("e = hasil perkalian a x b adalah {0} ", e);
Console.WriteLine("f = hasil pembagian a / b adalah {0} ", f);

if (c < e)
    Console.WriteLine("maka c < e adalah True");
else
    Console.WriteLine("maka c < e adalah False");
if (c > e)
    Console.WriteLine("maka c > e adalah True");
else
    Console.WriteLine("maka c > e adalah False");
if (d <= f)
    Console.WriteLine("maka d <= f adalah True");
else
    Console.WriteLine("maka d <= f adalah False");
if (d >= f)
    Console.WriteLine("maka d >= f adalah True");
else
    Console.WriteLine("maka d >= f adalah False");
if (c == e)
    Console.WriteLine("maka c = e  adalah True");
else
    Console.WriteLine("maka c = e adalah False");
if (d != f)
    Console.WriteLine("maka d != f adalah True");
else
    Console.WriteLine("maka d != f adalah False");
Console.ReadLine();
