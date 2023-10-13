
List<object> listaValores = new List<object>();

listaValores.Add(7);
listaValores.Add(28);
listaValores.Add(-1);
listaValores.Add(true);
listaValores.Add("silla");

foreach (object val in listaValores) 
{
    Console.WriteLine(val);
}

Console.WriteLine("------------------------------------------------");

int suma = 0;
foreach (object num in listaValores)
{
    if (num is int)
    {
        suma += (int)num;
    }
}

Console.WriteLine($"La suma es: {suma}");


