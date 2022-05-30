    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Zapisz wiadomość z wielkich liter");
string informacja = Console.ReadLine();
char[] achar = informacja.ToCharArray();
int x;


Console.WriteLine("Ilość przesunięcia");
x = Int32.Parse(Console.ReadLine());

    for (int i =0; i < achar.Length; i++)

{
    achar[i] = (char)((achar[i] + x));
    if(achar[i] > 90)
    {
        achar[i] = (char)((achar)[i] - 26);
    }
}
string zaszyfrowana = new string(achar);
Console.WriteLine("Po zaszyfrowaniu");
Console.WriteLine(zaszyfrowana);

string rozwiazanie = new string(achar);
Console.WriteLine("Po odszyfrowaniu");
Console.WriteLine(informacja);

Console.ResetColor();
