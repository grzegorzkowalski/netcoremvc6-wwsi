//Rozgrzewka
//Zadanie 2
{
    Console.WriteLine("Podaj swoje imię:");
    var name = Console.ReadLine();
    Console.WriteLine("Hello " + name);
}

//Zadanie 3
{
    //int result = 5 + 9 ERROR
    int result = 5 + 9;
    Console.WriteLine(result);
}

//Operatory
//Zadanie 1

{
    int number = 13;
    float money = 12.44f;
    string text = "Witam!";
    bool isLogged = true;
    char myChar = 'A';
    decimal price = 10.13m;

    Console.WriteLine($"number: {number}");
    Console.WriteLine($"money: {money}");
    Console.WriteLine($"text: {text}");
    Console.WriteLine($"isLogged: {isLogged}");
    Console.WriteLine($"myChar: {myChar}");
    Console.WriteLine($"price: {price}");
}

//Zadanie 2
{
    //string myAge = "Age: ";
    int myAge = 20;
    int wifeAge = 18;
    //int result2 = myAge + wifeAge; ERROR
    int result2 = myAge + wifeAge;
    Console.WriteLine(result2);
}

//Po dodaniu zmiennej typu string do zmiennej typu int pojawia się error.


//Zadanie 3
{
    bool isTrue = true;
    bool isFalse = false;
    bool isReallyTrue = true;

    bool and = isTrue && isFalse;
    bool or = isTrue || isReallyTrue;
    bool negative = !isFalse;

    Console.WriteLine($"and: {and}");
    Console.WriteLine($"or: {or}");
    Console.WriteLine($"negative: {negative}");
}

//Zadanie 4
{
    int a = 5;
    int b = 12;

    int add = a + b;
    int sub = a - b;
    int div = a / b;
    int mul = a * b;
    int mod = a % b;

    Console.WriteLine($"add: {add}");
    Console.WriteLine($"sub: {sub}");
    Console.WriteLine($"div: {div}");
    Console.WriteLine($"mul: {mul}");
    Console.WriteLine($"mod: {mod}");
}

//Zadanie 5
{
    string a = "Warszawa";
    string b = "to";
    string c = "miasto";

    string result = a + b + c;

    Console.WriteLine(result);
}

//instrukcje sterujące i pętle
//Zadanie1
{
    int n1 = 10;
    int n2 = 20;

    if (n1 > n2)
    {
        Console.WriteLine("n1 jest większe od n2.");
    }
    else if (n1 < n2)
    {
        Console.WriteLine("n2 jest większe od n1.");
    }
    else
    {
        Console.WriteLine("n1 jest równe n2.");
    }
}

//Zadanie2
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("C#");
    }

    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine("C#");
        counter++;
    }
}

//Zadanie3
{
    int n = 10;

    for (int i = 0; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i} - Parzysta");
        }
        else
        {
            Console.WriteLine($"{i} - Nieparzysta");
        }
    }
}
{
    int n = 10;
    int i = 0;

    while (i <= n)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"{i} - Parzysta");
        }
        else
        {
            Console.WriteLine($"{i} - Nieparzysta");
        }
        i++;
    }
}

//Zadanie 4
{
    int n = 5;

    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

//Zadanie 5
{
    int exam = 57;

    if (exam < 0 || exam > 100)
    {
        Console.WriteLine("Wartość poza zakresem.");
    }
    else if (exam < 40)
    {
        Console.WriteLine("Ocena Niedostateczna");
    }
    else if (exam < 55)
    {
        Console.WriteLine("Ocena Dopuszczająca");
    }
    else if (exam < 70)
    {
        Console.WriteLine("Ocena Dostateczna");
    }
    else if (exam < 85)
    {
        Console.WriteLine("Ocena Dobra");
    }
    else if (exam < 99)
    {
        Console.WriteLine("Ocena Bardzo Dobra");
    }
    else
    {
        Console.WriteLine("Ocena Celująca");
    }
}

//Kolekcje
//Zadanie 1
{
    string[] colors = { "czerwony", "zielony", "niebieski", "żółty" };

    Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}.");
    Console.WriteLine($"Mój ostatni kolor to: {colors[colors.Length - 1]}.");
}

//Zadanie 2
{
    int[] numbers = new int[] { 5, 8, 13, 21, 34, 55, 89, 144, 233, 377 };

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Liczba: " + numbers[i]);
    }

    foreach (int number in numbers)
    {
        Console.WriteLine("Liczba: " + number);
    }

    int j = 0;
    while (j < 10)
    {
        Console.WriteLine("Liczba: " + numbers[j]);
        j++;
    }
}

//Zadanie 3
{
    List<string> fruits = new List<string>() { "Pomidor", "Jabłko", "Marchewka", "Banan" };

    string fruitsString = String.Join(", ", fruits);
    Console.WriteLine(fruitsString);

    fruits.RemoveAt(0);
    fruits.RemoveAt(fruits.Count - 1);

    foreach (string fruit in fruits)
    {
        Console.WriteLine("Owoc: " + fruit);
    }
}