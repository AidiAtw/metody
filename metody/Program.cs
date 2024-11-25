int x = 3;
int y = 4;
string slovo = "KJT";

Stekni5Krat();
StekniXKrat(x);
TiskniSlovoXkrat(slovo, y);
RetezSlovoXkrat(slovo, y);

string retez = RetezSlovoXkrat(slovo, y);
Console.WriteLine(retez);

string retezBool = RetezSlovoXkratBool(slovo, y, true);
Console.WriteLine(retezBool);

void Stekni5Krat()
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Haf");
    }
}

void StekniXKrat(int x)
{
    for (int i = 0; i < x; i++)
    {
        Console.WriteLine("nHaf");
    }
}

void TiskniSlovoXkrat(string slovo, int y)
{
    for (int i = 0; i < y; i++)
    {
        Console.WriteLine(slovo);
    }

}

string RetezSlovoXkrat(string slovo, int y)
{
    string Z = string.Empty;
    for (int i = 0; i < y; i++)
    {
        Z += slovo + " ";
    }
    return Z;
}

string RetezSlovoXkratBool(string slovo, int y, bool novyRadek)
{
    string V = string.Empty;
    if (novyRadek)
    {
        for (int i = 0; i < y; i++)
        {
            V += slovo + Environment.NewLine;
        }
    }
    else
    {
        V = RetezSlovoXkrat(slovo, y);
    }
    return V;
}