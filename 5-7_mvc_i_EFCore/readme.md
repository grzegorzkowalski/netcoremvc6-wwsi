## Stwórz nowy  projekt, który będziemy rozwijać. 

### To będzie baza filmowa. Możemy nazwać go FilmDB.

####  Zadanie 1
 
1. Załóż nowy projekt w serwisie GitHub.
2. Przy tworzeniu nowego projektu dodaj plik `.gitignore` dls Visual Studio.
3. Stwórz nowy projekt .NET Core MVC `FilmDB`.
4. Stwórz nową bazę danych `FilmDB`. Jeśli to konieczne zainstaluj wcześniej SQL Express. 
5. Zainstaluj pakiety umożliwiające korzystanie z `Entity Framework Core` (wszystkie pakiety w wersji 6.0.13).


#### Zadanie 2

1. Dodaj model `FilmModel`.
2. W modelu utwórz właściwości:
    `ID` typu `int` - klucz główny.
    `Title` typu `string` - tytuł filmu - właściwość musi być wymagana.
    `Year` typu `int` - tekst filmu.
4. Dodaj nowy kontroler `FilmController`.
5. Ustaw powyższy kontroler jako domyślny w pliku `Program.cs`.

#### Zadanie 3

1. Utwórz klasę kontekstu o nazwie `FilmContext`, która dziedziczy po klasie `DbContext`.
1. W kontekście utwórz właściwość `DbSet<FilmModel>` o nazwie `Films`.
1. Pobierz lub utwórz łańcuch połączenia do bazy `FilmDb`.
1. Ustaw łańcuch połączenia w metodzie `OnConfiguring`, aby korzystał z bazy Microsoft Sql Sever.

#### Zadanie 4

1. Utwórz migrację o nazwie `Initial`.
1. Zobacz pliki migracji.
1. Przy pomocy Package Manager Console zaktualizuj bazę danych na podstawie migracji.
1. Zobacz tabelę utworzoną w bazie danych.

#### Zadanie 5

1. Utwórz w projekcie klasę:
```csharp
public class FilmManager
{
    public FilmManager AddFilm(FilmModel filmModel)
    {
        return this;
    }

    public FilmManager RemoveFilm(int id)
    {
        return this;
    }

    public FilmManager UpdateFilm(FilmModel filmModel)
    {
        return this;
    }

    public FilmManager ChangeTitle(int id, string newTitle)
    {
        return this;
    }

    public FilmManager GetFilm(int id)
    {
        return null;
    }

    public List<FilmModel> GetFilms()
    {
        return null;
    }
}
```
2. W klasie `FilmManager` w metodzie `AddFilm` należy:
    1. Utworzyć obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Dodać do kontekstu obiekt typu `FilmModel` przekazany w parametrze metody `AddFilm`.
    1. Obiekt dodajemy wywołując metodę `Add` na właściwości `Films` kontekstu.
    1. Zatwierdzić zmiany wywołując metodę `SaveChanges` na obiekcie kontekstu.
3. W akcji `Index` kontrolera `Film` utwórz obiekt klasy `FilmModel` o nazwie `FilmModel` przypisując do właściwości dowolne dane.
4. Do właściwości `ID` modelu przypisz wartość `1`.
5. Utwórz obiekt klasy `FilmManager` o nazwie `FilmManager` i sprawdź działanie metody `AddFilm` jako argument przekazując obiekt `FilmModel`.
6. Zobaczy typ i komunikat rzuconego wyjątku.

#### Zadanie 6

1. Zmień implementację metody `AddFilm` w następujący sposób:
    1. Złap wyjątki rzucane w momencie wywoływania metody `SaveChanges`.
    1. Gdy złapany zostanie typ wyjątku spowodowany uzupełnieniem właściwości `ID`, do właściwości `ID` przypisz `0` i ponów zapis do bazy wywołując metodę `SaveChanges`.

#### Zadanie 7

1. W klasie `FilmManager` w metodzie `RemoveFilm` należy:
    1. Utworzyć obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Pobrać obiekt typu `FilmModel` za pomocą metody `Single` lub `SingleOrDefault`. Obiekt pobierz na podstawie właściwości `ID` modelu i parametru metody.
    1. Usunąć pobrany model z bazy przy pomocy metody `Remove`, która powinna być wywołana na właściwość `Films` kontekstu.
    1. Zatwierdzić zmiany metodą `SaveChanges`.
	
#### Zadanie 8

1. W klasie `FilmManager` zmień implementację metody `GetFilm` w następujący sposób:
    1. Utworzyć obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Pobrać obiekt typu `FilmModel` za pomocą metody `SingleOrDefault`. Obiekt pobierz na podstawie właściwości `ID` modelu i parametru metody.
    

#### Zadanie 9
1. W klasie `FilmManager` w metodzie `ChangeTitle` należy:
    1. Utworzyć obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Pobrać obiekt typu `FilmModel` za pomocą metody `Single`. Obiekt pobierz na podstawie właściwości `ID` modelu i parametru metody.
    1. Zmodyfikować właściwość `Title`, na wartość `title` z parametru.
    1. Zatwierdź zmiany metodą `SaveChanges`.

#### Zadanie 10

1. Sprawdź działanie metody `ChangeTitle` z argumentem `null` przekazanym w miejsce parametru `newTitle`.
1. Zobacz rzucony wyjątek.
1. Zmień implementację metody w następujący sposób:
    1. Jeśli właściwość `Title` parametru równa się `null` przypisz do właściwości tekst `Brak Tytułu`.

#### Zadanie 11

1. W klasie `FilmManager` w metodzie `UpdateFilm` należy:
    1. Utwórz obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Zaktualizować obiekt przekazany w parametrze metody, używając metody `Update` właściwości `Films` kontekstu.
    1. Zatwierdź zmiany metodą `SaveChanges`.

#### Zadanie 12

1. W klasie `FilmManager` zmień implementację metody `GetFilms` w następujący sposób:
    1. Utworzyć obiekt kontekstu o nazwie `context` w deklaracji `using`.
    1. Pobrać listę obiektów typu `FilmModel` za pomocą metody `ToList`.


#### Zadanie 13

1. W kontrolerze `Film` utwórz akcję `Add`, wywoływaną tylko na żądanie `get`.
1. Akcja powinna wyświetlać formularz typu `FilmModel`, kierowany na akcję `Add`, zbudowany na podstawie modelu `FilmModel`.
1. W kontrolerze `Home` utwórz akcję `Add`z parametrem typu `FilmModel`, wywoływaną tylko na żądanie `post`.

#### Zadanie 14

1. W akcji `Index` pobierz wszystkie filmy z tabeli `Films`.
1. filmy przekaż do widoku przez model.
1. W widoku wyświetl listę filmów w tabeli `<table>`.
1. Nad tabelą utwórz link kierujący na akcję `Add`, która pozwoli dodać nowy film.

#### Zadanie 15

1. W kontrolerze `Film` utwórz akcję o nazwie `Remove` typu `get`, która przyjmie parametr typu `int` o nazwie `id`, którym będzie klucz główny filmu do usunięcia.
    1. Akcja powinna pobrać film o podanym `id` i przekazać go do widoku przez model.
    1. Dla akcji `Remove` utwórz widok i wyświetl wszystkie informacje o filmie oraz przycisk z tekstem `Potwierdź Usunięcie`, kierujący na akcję `RemoveConfirm` typu `post`.
    1. W widoku wyświetl również przycisk pozwalający wrócić do akcji `Index`.
1. W kontrolerze utwórz akcję typu `post` o nazwie `RemoveConfirm`, która przyjmuje parametr typu `int` o nazwie `id`.
    1. Akcja powinna usuwać encję o podanym `id` z bazy danych.
    1. Przed usunięciem sprawdź czy film o podanym `id` istnieje w bazie.
    1. Po usunięciu filmu akcja powinna przekierować na akcję `Index`.
1. W widoku `Index` przy każdym filmie w tabeli utwórz przycisk kierujący na akcję `Remove` z `id` danego filmu.

#### Zadanie 16

1. W kontrolerze `Film` utwórz dwie akcje o nazwie `Edit`:
1. Akcja typu `get` z parametrem `id` typu `int` powinna pobrać film o podanym identyfikatorze i przekazać go do widoku przez model.
1. Utwórz widok dla akcji `Edit`, który wyświetli formularz edycji. Formularz w przeciwieństwie do formularza dodawania powinien również zawierać ukryte pole `ID`.
1. Formularz powinien być typu `post` i kierować na akcję `Edit`.
1. Akcja typu `post` z parametrem typu `FilmModel` o nazwie `filmModel`.