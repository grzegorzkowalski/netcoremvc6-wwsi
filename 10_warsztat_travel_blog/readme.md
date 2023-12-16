### Warsztat Travel Blog cześć 1.

####  Zadanie 1
1. Naszym zadaniem jest zamiana statycznej strony typu single page na dynamiczną aplikację wielostronicową.
1. W folderze `projekt_statyczny` mamy gotową stronę html o tematyce podróżniczej. Jest to strona statyczna bez komunikacji, pobierania danych, możliwości wysyłki formularza itd.
1. Naszym zadaniem jest wykorzystać statyczny kontent i przerobić stronę, żeby na etapie końcowym naszego warsztatu była w pełni dynamicznym blokiem z pobieraniem danych z api, możliwością przesłania formularza i wykorzystaniem innym możliwości .NET Core.
1. Stwórz nowy projekt .NET Core Web App `TravelBlog`.
1. Wybierz framework .NET 6 i typ uwierzytelniania Individual Accounts.
1. Wykonaj migrację danych.
1. Sprawdź czy baza danych z odpowiednimi tabelami została utworzona.
1. Przetestuj czy projekt się uruchamia.

####  Zadanie 2
1. Otwórz `projekt_statyczny` i zapoznaj się z jego wyglądem i budową.
1. Zmień budowę layoutu aplikacji `TravelBlog`. Zaimplementuj kod html w pliku `_Layout.cshtml`. Style, obrazki umieść w odpowiednich miejscach w folderze `wwwroot`. Pamiętaj o dodaniu wszystkich zasobów, takich jak style, fonty, pliki graficzne.
1. Menu aplikacji zamień na partial i dodaj do layoutu.
1. Aplikację podzielimy na następujące podstrony:
	1. Strona główna
	1. Aktualności
	1. O mnie
	1. Galeria 
	1. Kontakt
1. Stwórz `Stronę główną`.
1. Dodaj do niej treści.
1. Stwórz stronę `Aktualności`.
1. Dodaj do niej treści.
1. Stwórz stronę `O mnie`.
1. Dodaj do niej treści.
1. Stwórz stronę `Galeria`.
1. Dodaj do niej treści.

#### Uwaga w wersji alternatywnej w odpowiedzi na wasze potrzeby zamiast używać podejścia Code First, proszę użyć podejścia Database first.
W pliku sample.sql dodany jest kod wykorzystywany w prezentacji. Może stanowić podstawę do napisania swojej bazy.
		
####  Zadanie 3
1. Stwórz folder `Models`.
1. Dodaj model `Email`, który będzie reprezentował dane przesłane w formularzu kontaktowym.
1. Dodaj model do klasy contextu.
1. Zrób migrację i zrób aktualizację bazy danych.
1. Stwórz stronę `Kontakt` z silnie typowanym formularzem, który będzie dodawał do bazy wpisy przesłane przez użytkowników,
1. Po przesłaniu poprawnie formularza, ukryj formularz i wyświetl informację, że formularz został wysłany poprawnie i niedługo odpowiemy.

####  Zadanie 4
1. Stwórz nowy kontroler o nazwie `CMS`.
1. Stwórz model `GalleryItem`, który będzie reprezentował pojedyńczy element galerii.
1. Dodaj model do klasy contextu.
1. Zrób migrację i aktualizację bazy danych.
1. Stwórz odpowiednie podstrony do dodawania, edycji, usuwania, wyświetlania pojedyńczego elementu galerii jak i listy. 
1. Dodaj asynchroniczne repozytorium do obsługi podstawowych operacji crudowych.
1. Zmodyfikuj widok `Galeria`, żeby wykorzystywał listę elementów galerii dodanych dynamicznie.

  		   
