# EatMe
<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>1</th>
            <th colspan=2>Wyświetlenie menu asystenta głosowego</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu aplikacji użytkownikowi wyświetli się menu z dostępnym opcjami oraz czy aplikacja głosowo zachęci użytkownika do wybrania jednej z dostępnych opcji.</th>
        </tr>
        <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
        <tr>
            <td>1.1</td>
            <td>Pozytywny</td>
            <td>Uruchom aplikację</td>
            <td>Menu zostaję wyświetlone. Asystent głosowy się wita i zachęca głosowo do wprowadzenia funkcji.</td>
            <td>Menu wyświetliło się. Asystent się przywitał i zachęcił do wyboru funkcji.</td>
        </tr>
        <tr>
            <td>1.2</td>
            <td>Pozytywny</td>
            <td>Sprawdź wyświetlane opcje, oczekiwane funkcje menu.
             
Podstawowe funkcje:
- Wikipedia
- Notatka
- Otwórz plik
- Klawiatura
- Google
- Screenshot

Funkcje webowe:
- Strona Uniwersytetu
- Strona wydziału
- Portal edukacyjny
- Portal studenta
- Aktualności
- Wyszukiwarka
- Wsparcie
- Otwórz youtube

Funkcje dodatkowe:
- Pogoda
- Lotto
- Gierka
- Zamknij</td>
            <td>Wymienione opcje się wyświetlają.
 
Podstawowe funkcje:
- Wikipedia
- Notatka
- Otwórz plik
- Klawiatura
- Google
- Screenshot

Funkcje webowe:
- Strona Uniwersytetu
- Strona wydziału
- Portal edukacyjny
- Portal studenta
- Aktualności
- Wyszukiwarka
- Wsparcie
- Otwórz youtube

Funkcje dodatkowe:
- Pogoda
- Lotto
- Gierka
- Zamknij</td>
            <td>Wymienione pola zostały wyświetlone.
 
Podstawowe funkcje:
- Wikipedia
- Notatka
- Otwórz plik
- Klawiatura
- Google
- Screenshot

Funkcje webowe:
- Strona Uniwersytetu
- Strona wydziału
- Portal edukacyjny
- Portal studenta
- Aktualności
- Wyszukiwarka
- Wsparcie
- Otwórz youtube

Funkcje dodatkowe:
- Pogoda
- Lotto
- Gierka
- Zamknij</td>
        </tr>
        <tr>
            <td>1.3</td>
            <td>Pozytywny</td>
            <td>W przypadku braku reakcji ze strony użytkownika</td>
            <td>Asystent poinformuje o oczekiwaniu na wybranie funkcji</td>
            <td>Asystent prosi o wybranie funkcju "Podaj nazwę funkcji. Słucham Cię"</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>2</th>
            <th colspan=2>Funkcje podstawowe - korzystanie z funkcji "Wikipedia"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji wikipedia program prawidłowo przetworzy i pobierze hasło od użytkownika, następnie pobierze liczbę zdań od użytkownika. Podyktuje treść. Daną treść będzie można następnie zapisać do nowego pliku. </th>
        </tr>
        <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
        <tr>
            <td>2.1</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Wikipedia"</td>
            <td>Po wybraniu funkcju aplikacja pobiera od użytkownika hasło oraz ilość zdań które ma dyktować.
            Następnie program dyktuje treść.</td>
            <td>Po wybraniu funkcju aplikacja prosi o:
            - podanie hasła,
            - podanie ilosći zdań.
            Pogram pobiera dane z wikipedi i dyktuje fragment</td>
        </tr>
          <tr>
            <td>2.2</td>
            <td>Pozytywny</td>
            <td>Zapisywanie do pliku</td>
            <td>Po odsłuchaniu fragmentu z wikipedii mamy możliwość zapisać treść do pliku, program pyta czy chcemy zapisać plik tak/nie, następnie prosi o podanie tytułu</td>
            <td>Po wybraniu opcji program poprosił o podanie tytułu pliku i zapisał nowy plik o tym tytule.</td>
        </tr>
          <tr>
            <th colspan=2>Uwagi</th>
            <th colspan=3>W przypadku problemu z pobraniem hasla od użytkownika asystent mówi komunikat Spróbuj jeszcze raz i wraca do podstawowych funkcji</th>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>3</th>
            <th colspan=2>Funkcje podstawowe - korzystanie z funkcji "Notatka"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji notatka program pobierze od użytkownika tytuł notatki oraz treść notatki. Następnie program ma za zadanie zapisać notatkę do nowego pliku.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Notatka"</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
          <tr>
            <th colspan=2>Uwagi</th>
            <th colspan=3>W przypadku zapisywania pliku brakuje kodowania znaków specjalnych dla języka polskiego</th>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>4</th>
            <th colspan=2>Funkcje podstawowe - korzystanie z funkcji "Otwórz plik" lub "Otwórz notatkę"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji otwórz plik, otwórz notatkę program pobierze nazwę wybranego przez użytkownika pliku, notatki oraz otworzy go.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Otwórz plik" lub "Otwórz notatkę"</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>5</th>
            <th colspan=2>Funkcje podstawowe - korzystanie z funkcji "Wyszukiwarka"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji wyszukiwarka program prawidłowo przetworzy i pobierze haslo wyszkiwania, które następnie wyszuka w domyślnej przeglądarce użytkownika.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Wyszukiwarka"</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>6</th>
            <th colspan=2>Funkcje podstawowe - korzystanie z funkcji "Screenshot"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji screenshot asystent wykona screenshot ekrany i poprosi użytkownika o podanie nazwy pliku, jaki ma zostać utworzony, po czym zapiszę plik.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Screenshot"</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>7</th>
            <th colspan=2>Korzystanie z funkcji  NET - wyświetlanie wybranych stron inernetowych</th>
            <th colspan=2>Test sprawdza czy po wybraniu funkcji z kategorii Net program otworzy przeglądarkę z właściwą stroną. </th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td>7.1</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Strona Uniwersytetu"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Strona Uniwersytetu" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://ug.edu.pl/"</td>
        </tr>
         <tr>
            <td>7.2</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Strona wydziału"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Strona wydziału" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://wzr.ug.edu.pl/"</td>
        </tr>
         <tr>
            <td>7.3</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Portal edukacyjny"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Portal edukacyjny" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://pe.ug.edu.pl/"</td>
        </tr>
         <tr>
            <td>7.4</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Portal studenta"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Portal studenta" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://ps.ug.edu.pl/"</td>
        </tr>
         <tr>
            <td>7.5</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Rozkład zajęć"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Rozkład zajęć" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://wzr.ug.edu.pl/studia/index.php?str=462"</td>
        </tr>
         <tr>
            <td>7.6</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Aktualności"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Aktualności" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://www.dlastudenta.pl/"</td>
        </tr>
         <tr>
            <td>7.7</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Wsparcie"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Wsparcie" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://www.stackoverflow.com"</td>
        </tr>
         <tr>
            <td>7.8</td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Otwórz YouTube"</td>
            <td>Po wywołaniu funkcju, program powininen otworzyć odpowiedni adres w domyślnej przeglądarce.</td>
            <td>Po wywołaniu funkcji haslem "Otwórz Youtube" program otwiera domyślną przeglądarkę i przenosi nas pod adres: "https://www.youtube.com"</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>8</th>
            <th colspan=2>Funkcje dodatkowe - Korzystanie z funkcji "Pogoda"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji Pogoda i podaniu wybranego przez użytkownika miasta program prawidłowo przetworzy i pobierze miasto oraz przekarze dane pogodowe dla danej miejscowosci.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Pogoda" + wybrane miasto</td>
            <td>Program po wywołaniu funkcji i po podaniu miasta przekazuje dane odnośnie pogody.</td>
            <td>Program po wywołaniu funkcji pogoda i podaniu miasta pobrał i przekazał głosowo aktualną informację o pogodzie</td>
        </tr>
         <tr>
            <td colspan=2>Uwagi</td>
            <td colspan=3>W przypadku problemu z pobraniem hasła - zarówno przy dydktowaniu hasła wikipedii czy w przypadku tworzenia notatki program wraca do podstawowych funkcji</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>9</th>
            <th colspan=2>Funkcje dodatkowe - Korzystanie z funkcji "Klawiatura"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji Klawiatura program prawidłowo przetworzy i pobierze symbol klawisza przekazywany ustnie przez użytkownika.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Klawiatura"</td>
            <td>?</td>
            <td>?</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>10</th>
            <th colspan=2>Funkcje dodatkowe - Korzystanie z funkcji "Lotto"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji Lotto program zleci użytkownikowi wybranie po kolei 6 kolejnych różnych cyfr z zakresu od 1-49, po czym wylosuje liczby i zestawi je z liczbami użytkownika. </th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Lotto"</td>
            <td>?</td>
            <td>?</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>11</th>
            <th colspan=2>Funkcje dodatkowe - Korzystanie z funkcji "Gierka"</th>
            <th colspan=2>Test sprawdza czy po uruchomieniu funkcji gra program zleci użytkownikowi odgadnięcie liczby z zakresy 1-100, program poinformuje jeśli zgadywana liczba większa lub mniejsza od poszukiwanej. Program poinformuje użytkownia w momencie odgadnięcia liczby.</th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Gierka"</td>
            <td>?</td>
            <td>?</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>ID</th>
            <th colspan=2>Nazwa</th>
            <th colspan=2>Opis</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <th>12</th>
            <th colspan=2>Funkcje dodatkowe - Korzystanie z funkcji "Zamykanie programy"</th>
            <th colspan=2>Test sprawdza czy po wywołaniu funkcji "Zamknij" program skończy działanie. </th>
        </tr>
      <tr>
            <td></td>
            <td>Typ testu</td>
            <td>Opis Kroku</td>
            <td>Oczekiwany wynik</td>
            <td>Rzeczywisty wynik</td>
        </tr>
      <tr>
            <td></td>
            <td>Pozytywny</td>
            <td>Wybierz głosowo funkcje pod hasłem "Zamykanie programy"</td>
            <td>?</td>
            <td>?</td>
        </tr>
    </tbody>
</table>
