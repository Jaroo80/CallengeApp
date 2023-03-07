int number = 542265884;

string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
int[] wynik = new int[10];

foreach (char letter in letters)
{
    wynik[int.Parse(letter.ToString())]++;
}
    {
     Console.WriteLine("ilosc wystapien w liczbie " + number + ":");
    }

    for(int i = 0; i< 10; i++)
    {
        Console.WriteLine("Liczba"+":" + i + "-->" + wynik[i]);
    }
    