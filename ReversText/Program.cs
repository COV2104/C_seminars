// Слово развернуть в обратном порядке
System.Console.WriteLine("Введите текст: ");
string text = Console.ReadLine();
int i = text.Length - 1;

void Revers(string text, int i)
{
    if (i >= 0)
    {
        Console.Write(text[i]);
        Revers(text, i - 1);
    }
}
Revers(text, i);
System.Console.WriteLine();

