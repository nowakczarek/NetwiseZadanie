# CatFactsApp (.NET 8)  
Aplikacja konsolowa .NET, która pobiera losowy fakt o kotach z publicznego API (`https://catfact.ninja/fact`) i zapisuje go lokalnie do pliku tekstowego.

## Funkcjonalności

- Pobieranie danych z zewnętrznego API (`catfact.ninja`)
- Zapis danych do pliku `CatFacts.txt` w lokalnym katalogu
- Logowanie przebiegu działania aplikacji
- Obsługa wyjątków
- Rozdzielenie odpowiedzialności (warstwa usług, modeli i logiki)
- Wzorzec Dependency Injection
- Wstrzykiwanie `HttpClient` przez `IHttpClientFactory`

---

## Wymagania

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (lub nowszy)
- System: Windows / macOS / Linux

---

## Jak uruchomić
git clone https://github.com/nowakczarek/NetwiseZadanie
cd NetwiseZadanie
