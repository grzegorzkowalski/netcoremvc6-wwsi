## Zadania

### Pierwszy program - rozgrzewka

#### Zadanie 1

Stwórz nowy projekt typu Console App (.Net Core).

#### Zadanie 2

W metodzie `Main` umieść następujący kod:
```csharp
Console.WriteLine("Podaj swoje imię:");
var name = Console.ReadLine();
Console.WriteLine("Hello " + name);
```
1. Uruchom projekt, wyświetli się okno konsoli.

#### Zadanie 3

W metodzie `Main` umieść następujący kod:
```csharp
int result = 5 + 9
```
1. Uruchom projekt.
1. Jeśli uruchomienie zakończy się niepowodzeniem, znajdź i napraw błąd. Błędy możesz zobaczyć w oknie `Error List`.

#### Operatory

#### Zadanie 1

1. W metodzie `Main` utwórz 6 zmiennych.
1. Każda zmienna powinna przechowywać odpowiednio dobrany przez Ciebie typ danych na podstawie opisu.
1. Wartości mogą być dowolne.
* Zmienna o nazwie `number` przechowująca liczbę całkowitą.
* Zmienna o nazwie `money` przechowująca liczbę zmiennoprzecinkową (float).
* Zmienna o nazwie `text` przechowująca tekst.
* Zmienna o nazwie `isLogged` przechowująca wartość logiczną.
* Zmienna o nazwie `myChar` przechowująca pojedynczy znak.
* Zmienna o nazwie `price` przechowująca liczbę zmiennoprzecinkową z największą precyzją (decimal).

Po deklaracji wszystkich zmiennych wyświetl je w konsoli.

#### Zadanie 2

1. Utwórz zmienną o nazwie `myAge` typu `string` z wartością `Age: `.
1. Utwórz zmienną o nazwie `wifeAge` typu `int` z wartością `18`.
1. Utwórz zmienną o nazwie `result` i przypisz do niej rezultat dodawania zmiennych `myAge` i `wifeAge`.
1. Wyświetl zmienną `result` w konsoli.
5. Jakie wnioski?

#### Zadanie 3

1. Utwórz 3 zmienne typu `bool` o następujących nazwach i wartościach:
    1. `isTrue` o wartości `true`.
    1. `isFalse` o wartości `false`.
    1. `isReallyTrue` o wartości `true`.
1. Utwórz 3 kolejne zmienne o następujących nazwach i przypisz do nich wyniki działań na zmiennych logicznych:
    1. `and` powinna zwierać wynik działania `isTrue` AND `isFalse`.
    1. `or` powinna zwierać wynik działania `isTrue` OR `isReallyTrue`.
    1. `negative` powinna zawierać wynik negacji `isFalse`.
1. Wyświetl zmienne `and, or i negative` w konsoli.

#### Zadanie 4

1. Utwórz dwie zmienne o nazwach `a`, `b` i przypisz do nich wartości `5, 12`.
1. Utwórz zmienne o nazwach `add`, `sub`, `div`, `mul`, `mod` i przypisz do nich kolejno wynik dodawania, odejmowania, dzielenia, mnożenia i modulo zmiennych `a` i `b`.
1. Wyświetl zmienne `add`, `sub`, `div`, `mul`, `mod` w konsoli.


#### Zadanie 5

1. Utwórz trzy zmienne typu `string` o nazwach `a`, `b` i `c`.
1. Do zmiennych przypisz kolejno tekst `Ala `, `ma `, `kota.`.
1. Utwórz 4 zmienną o nazwie `result` i przypisz do niej wynik operacji `a + b + c`.
1. Wyświetl zmienną `result` w konsoli.
1. Napisz w komentarzu swoje spostrzeżenia dotyczące wyniku.

### Instrukcje sterujące i pętle

#### Zadanie 1

1. Utwórz dwie zmienne typu `int` o nazwach `n1` i `n2`. Przypisz do nich liczby `10` i `20`.
1. Używając instrukcji `if` sprawdź wartości tych zmiennych i wypisz w konsoli, która z liczb jest większa lub czy są równe.
1. Tekst powinien się wyświetlić według wzoru `n1 jest większe od n2` lub `n1 jest równe n2`.

#### Zadanie 2

1. Stwórz pętlę, która 10 razy wypisze w konsoli `C#`.
1. Zadanie rozwiąż używając pętli `for` oraz pętli `while`.
1. W sumie w konsoli wyraz `C#` powinien pojawić się 20 razy.

#### Zadanie 3

1. Stwórz zmienną o nazwie `n`, które będzie zainicjowana wartością `10`.
1. Następnie wypisz w konsoli informacje czy liczba jest parzysta, czy nie, dla liczb od `0` do `n`.
Wzór:
```
0 - Parzysta
1 - Nieparzysta
2 - Parzysta
itd...
```

Jak sprawdzić czy liczba jest parzysta? Podpowiedź: `modulo`.

#### Zadanie 4 *dodatkowe

1. Stwórz zmienną o nazwie `n`, która będzie zawierała wartość 5.
1. Następnie napisz skrypt, który wypisze w konsoli poniższy schemat.

Schemat dla `n = 5`.
```
*
* *
* * *
* * * *
* * * * *
```

Schemat dla `n = 3`.
```
*
* *
* * *
```

#### Zadanie 5 *dodatkowe

1. Utwórz zmienną `exam`, która będzie zawierała wartość od 0 do 100.
1. Zmienna `exam` przechowuje wyniki egzaminu.
1. Utwórz kod, który wyświetli w konsoli ocenę z testu na podstawie zmiennej `point`, według poniższego schematu.
    * 0 - 39 pkt - `Ocena Niedostateczna`
    * 40 - 54 pkt - `Ocena Dopuszczająca`
    * 55 - 69 pkt - `Ocena Dostateczna`
    * 70 - 84 pkt - `Ocena Dobra`
    * 85 - 98 pkt - `Ocena Bardzo Dobra`
    * 99 - 100 pkt - `Ocena Celująca`
1. W przypadku gdy wartość `exam` jest mniejsza od `0` lub większa od `100` wyświetl komunikat: `Wartość poza zakresem`.

Przykład: Dla point z wartością `57`, w konsoli powinno wyświetlić się `Ocena Dostateczna`.

### Kolekcje

#### Zadanie 1

1. Utwórz czteroelementową tablicę typu `string` o nazwie `colors`.
1. Tablicę uzupełnij dowolnymi nazwami kolorów.
1. Wyświetl pierwszy kolor z tablicy w konsoli według wzoru `Mój pierwszy kolor to: niebieski`.
1. Wyświetl ostatni kolor z tablicy w konsoli według wzoru `Mój ostatni kolor to: czerwony`.

#### Zadanie 2

1. Stwórz tablicę z 10 dowolnymi liczbami.
1. Następnie wypisz w konsoli, przy użyciu pętli `for`, `foreach` i `while` 10 razy tekst `Liczba: 13`, gdzie `13` będzie kolejną liczbą z tablicy.

Wzór
```csharp
Liczba: 0
Liczba: 1
```

#### Zadanie 3

1. Utwórz czteroelementową listę `List<string>` o nazwie `fruits`.
1. Tablicę uzupełnij dowolnymi nazwami owoców, używając metody remove.
1. Wyświetl w konsoli wszystkie owoce według wzoru `Pomidor, Jabłko, Marchewka`. Między nazwami owoców musi się znaleźć przecinek i spacja.
4. Usuń za pomocą metod `Revome i RemoveAt` pierwszy i ostatni element listy.
5. Wyświetl wszystkie elementy listy.


## Warsztat

#### Zadanie 1: Zapoznanie się z Visual Studio

1. Utwórz nową solucję o nazwie Library
2. W solucji utwórz projekt Library.ConsoleApp typu aplikacja konsolowa
3. W solucji utwórz projekt Library.Domain typu ClassLib
4. W solucji utwórz projekt Library.Persistence typu ClassLib
5. W projekcie Library.Persistence dodaj referencję do projektu Library.Domain
6. W projekcie Library.ConsoleApp dodaj referencję do projektów Library.Domain i Library.Persistence
7. W projekcie Library.Domain utwórz klasę ksiązki, mozesz ją skopiowac z kodu ponizej
```csharp
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public string ISBN { get; set; }

        public int ProductsAvailable { get; set; }
        public decimal Price { get; set; }
        
        public Book() {}

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }
    }
}
```
8. W projekcie Library.Persistence utwórz klasę BooksRepository, na chwilę obecną moze to byc pusta klasa
9. W projekcie Library.ConsoleApp w pliku Program.cs utworz obiekt wczesniej utworzonych klas
```csharp
Book book = new Book(/*uzupelnij parametry*/);
BooksRepository repository = new BooksRepository();
```
10. Skompiluj projek aby sprawdzic czy nie ma w nim błędów.
11. *Utwórz katalog solucji Presentation
12. *Przenies do katalogu Presentation projekt Library.ConsoleApp
13. *Utworz katalog solucji Logic
14. *Przenies do katalogu Logic projekty Library.Domain oraz Library.Persistence

#### Zadanie 2: Instrukcje Warunkowe / Debugowanie

1. Otwórz plik Program.cs w projekcie Library.ConsoleApp
2. Za pomocą API obiektu console, pobierz od uzytkownika jego login i haslo
```csharp
string text = Console.ReadLine();
```
3. Jezeli login to `Admin` a haslo to `password` wypisz na consoli napis `Access Granted`
4. W przeciwnym wypadku wypisz napis `Access Denied`
5. Za pomocą przycisku F9 (lub klikając w lewą kolumnę edytora) oznacz miejsce z if-em, tak aby wykonywanie programu zatrzymało się.
6. Urucham projekt Library.ConsoleApp w trybie Debug
7. Za pomocą przycisku F10 przejdź przez flow programu

#### Zadanie 3: Utworzenie menu w aplikacji konsol / Pętle sterujące 

1. Otworz plik Program.cs z aplikacji Library.ConsoleApp
2. Następnie za pomocą pętli zczytuj kolejne linie tekstu wprowadzone przez uzytkownika
3. Pętla ma zakończyc swoje zadanie kiedy uzytkownik wpisze komende `wyjdz`
4. Pętla ma czekac az uzytkownik wprowadzi komende
5. Wewnątrz pętli sprawdzaj jaką komendę podał uzytkownik według ponizszej rozpiski: 
   - dodaj -> Powinna wypisac tekst: "proba dodania ksiazki"
   - usun -> Powinna wypisac tekst: "proba usuniecia ksiazki"
   - wypisz -> Powinna wypisac tekst: "proba wypisania wszystkich ksiazek"
   - zmien -> Powinna wypisac tekst: "proba zmiany stanu magazynowego ksiazek"
   - dodaj zamowienie -> Powinna wypisac tekst: "proba dodania nowego zamowienia"
   - lista zamowien -> Powinna wypisac tekst: "proba wypisania wszystkich zamowien"
6. Wykorzystaj komende `Console.Clear()` aby po wprowadzeniu komendy ekran konsoli wypisywal tylko menu aplikacji
7. Wykorzystaj komendę `Console.WriteLine` aby wyswietlic uzytkownikowi mozliwe do wpisania komendy
8. *W przypadku kiedy uzytkownik poda nie wspierana komende, aplikacja powinna wyswietlic informacje ze podana komenda nie jest wspierana
9. *Po kazdej komendzie aplikacja powinna wyswietlic napis: `Press AnyKey` i wstrzymac wykonywanie programu do czasu wcisniecia klawisza

﻿#### Zadanie 4: Books Service

1. W projekcie Library.ConsoleApp stwórz klasę `BooksService`
2. W klasie `BooksService` zaimplementuj takie metody jak: 
   - AddBook():void -> Powinno pobrac od uzytkownika wszystkie dane potrzebne do stworzenia instancji klasy `Book`
   - RemoveBook():void -> Powinno pobrac od uzytkownika tytul ksiazki do usuniecia
   - ListBooks():void -> Ta metoda powinna wyswietlic napis `Tutaj pojawi sie lista ksiazek`
   - ChangeState():void -> Ta metoda powinna pobrac od uzytkownikow tytul ksiazki, której stan ma się zmienic oraz samą zmianę stanu np. -1
Do konwersji string-a na int-a uzyj klasy Convert
```csharp
Convert.ToInt32(Console.ReadLine());
```
3. Przejdz do pliku `Program.cs` w projekcie Library.ConsoleApp
4. Przed pętlą utwórz obiekt klasy `BooksService`
5. W srodku pętli podmien wyswietlanie tekstow na wywołanie odpowiedniej metody z obiektu klasy `BooksService`
6. Uruchom aplikację i sprawdz czy wsyzstko działa poprawnie

#### Zadanie 5: Dodanie repozytorium

1. Otwórz klasę `BooksRepository` znajdującą się w projekcie Library.Persistence
2. Utwórz pole `readonly List<Book>` o nazwie _database
3. Utwórz bezparametroy Konstruktor
4. W konstruktorze dodaj kilka ksiązek, mozesz do tego uzyc ponizszych: 
```csharp
    new Book("Stary człowiek i morze", "Ernest Hemingway", 1986, "AAAA", 10, 19.99m),
    new Book("Komu bije dzwon", "Ernest Hemingway", 1997, "BBBB", 0, 119.99m),
    new Book("Alicja w krainie czarów", "C.K. Lewis", 1998, "CCCC", 53, 39.99m),
    new Book("Opowieści z Narnii", "C.K. Lewis", 1999, "DDDD", 33, 49.99m),
    new Book("Harry Potter", "J.K. Rowling", 2000, "EEEE", 23, 69.99m),
    new Book("Paragraf 22", "Joseph Heller", 2001, "FFFF", 5, 45.99m),
    new Book("Lalka", "Bolesław Prus", 2002, "GGGG", 7, 76.99m),
    new Book("To", "Stephen King", 2003, "HHHH", 2, 12.99m),
    new Book("Idiota", "Fiodor Dostojewski", 1950, "IIII", 89, 25.99m),
    new Book("Mistrz i Małgorzata", "Michaił Bułhakow", 1965, "JJJJ", 41, 36.99m),   
```
5. Dodaj metodę `Insert(Book book): void`, która będzie odpowiedzialna za dodawanie nowej ksiązki do listy
6. Dodaj metodę `GetAll(): List<Book>`, która będzie zwracac wszystkie ksiązki, które znajdują się w repozytorium
7. Dodaj metodę `RemoveByTitle(string title): void`, która będzie kasowac wybraną ksiązke z repozytorium. Aby szybciej namierzyc ksiązke mozesz uzyc ponizszego wyrazenia LINQ
```csharp
.First(x => x.Title == title)
```
8. Dodaj metode `ChangeState(string title, in stateChange)`, która będzie uaktualniac stan w wybranym tytule. Wykorzystaj wyrazenie LINQ z poprzedniego cwiczenia.
9. Przejdz do pliku `BooksService` w projekcie Library.ConsoleApp
10. Utwórz konstruktor, w którym jedynym parametrem będzie obiekt klasy `BooksRepository`
11. Przypisz obiekt klasy `BooksRepository` do pola w klasie o nazwie `_repository`
12. Wykorzystaj obiekt `_repository` w wywołaniach metod klasy `BooksService`
13. Przejdz do pliku `Program.cs` i przed utworzeniem obiektu `BooksService` utworz obiekt klasy `BooksRepository`
14. Przekaz obiekt klasy `BooksRepository` do konstruktora klasy `BooksService`
15. Przetestuj czy mozna dodac nową ksiązke do repozytorium 

#### Zadanie 6: Orders

1. Otwórz projek Library.Domain
2. Stwórz klasę BookOrdered, która powinna zawierac: 
    - Propertis BookId typu int
    - Propertis NumerOrdered typu int
3. Stwórz klasę Order, która powinna zawierac: 
    - Propertis Date typu DateTime
    - propertis BooksOrderedList typu `List<BookOrdered>`
    - Bezparametrowy konstruktor, w którego ciele zastaną wykonane następujące akcję:
        - Ustawienie propertisa Date na wartosc `DateTime.Now`
        - Zainicjalizowanie listy BooksOrderedList pustą listą
    - Metodę ToString (pamiętaj o uzyciu `override`), która wygeneruje ciąg znaków w postaci
        ```
        Order: DataUtworzenia obiektu
        Book: IdKsiazki Count: IloscZamowionych ksiazek
        ```
        w tym celu mozesz uzyc interpolacji stringów
        ```csharp
            string str = "Test";
            str += $"Test: {JakasZmienna} Test2: {JakasZmienna}";
        ```
4. Przejdz do projektu Library.Persistence
5. Utworz klasę `OrdersRepository`
6. Wewnatrz klasy `OrdersRepository` utwórz prywatne pole `database` typu List<Order>, które od razu zainicjalizu pustą listą.
7. Wewnatrz klasy `OrdersRepository` zaimplementuj dwie metody: 
    - `Insert(Order order): void` -> wywołanie tej metody ma dodawac elementy do kolekcji
    - `GetAll(): List<Order>` -> wywołanie tej metody ma zwrócic wszystkie wczesniej dodane order-y
8. Przejdz do projektu Library.ConsoleApp
9. Utwórz klasę `OrderService`
10. W klasie `OrderService` utwórz konstruktor, który będzie przyjmował obiekt klasy `OrdersRepository` jako swój paramter
11. W konstruktorze klasy `OrderService` przypisz obiekt klasy `OrderRepository` do prywatnego pola o nazwie `_orderRepository`
12. W klasie `OrderService` zaimplementuj metodę `PlaceOrder`, która będzie odpowiedzialna za proces składania nowego zamówienia:
    - Utworzenie obiektu klasy `Order`,
    - Wypisanie menu w postaci: 
    ```
        add - dodaj pozycje do zamowienia
        end - zamknij zamowienie
    ```
    - W momencie wpisania komendy `add`, program powinien zapytac uzytkownika o: 
        - Id ksiązki
        - Ilosc 
    - Następnie utworzyc obiekt klasy `BookOrdered` i dodac go do pola `BooksOrderedList` z obiektu `order`
    - Następnie powrócic do menu `add / end` aby bylo mozliwe dodanie wiecej niz tylko jednej pozycji w zamowieniu
    - W momencie wpisania komendy `end` program powinien dodac obiekt `order` do repozytorium
13. W klasie `OrderService` zaimplementuj metodę `ListAll`, której zadaniem będzie wypisanie wszystkich zamowien pobranych z repozytorium
14. Przejdz do pliku `Program.cs` w projekcie Library.ConsoleApp
15. Utwórz obiekt klasy `OrdersRepository` przed główną pętlą programu
16. Utwórz obiekt klasy `OrdersService`, wykorzystując przy tym wczesniej utworzony obiekt klasy `OrdersRepository`
17. Wykorzystaj obiekt klasy `OrdersService` aby podpiąc jego metody do zadan:
    - dodaj zamowienie
    - lista zamowien
18. Uruchom aplikację Library.ConsoleApp w trybie debug-u
19. Przetestuj czy dodawanie zamowien działa poprawnie
20. *Zrób zabezpieczenie aby nie dało się dodac do zamówienia ksiazki, której nie ma na w repozytorium
21. *Zrób zabezpieczenie aby do zamowienia nie dało się dodac więcej ksiązek, niz jest w repozytorium.
