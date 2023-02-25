void Metod()
{
    int n = 3;
    int j = 0; 

    string[] array = { "qw", "21", "2dd2", "qwe122", ":-)", "- -", "hello" };

    string[] NewArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {
            NewArray[j] = array[i];
            Console.WriteLine($"{NewArray[j]}");
            j++;  
        }
    }
}
Metod();
