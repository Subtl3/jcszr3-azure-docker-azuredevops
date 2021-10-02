# Ćwiczenie 1.

Zapoznaj się z komendami Docker CLI:

`docker run [konto/repo]:[tag]` - Uruchomienie obrazu w tle

`docker run -p [Port_Hosta]:[Port_Kontenera] [Obraz]`

`docker images` - Wyświetlenie listy obrazów

`docker rmi` - Usunięcie obrazu

`docker build [ścieżka]` - Budowanie obrazu na podstawie dockerfile - ścieżka musi być podana do miejsca gdzie znajduje się dockerfile

`docker ps` - Lista uruchomionych kontenerów

`docker ps -a` - Lista wszystkich kontenerów

`docker rm [id_kontenera]` - Usunięcie kontenera - UWAGA: usunięcie uruchomionego kontenera nie zadziała. Należy go wcześniej zastopować.

`docker stop [id_kontenera]` - Zatrzymanie kontenera

`docker system prune --all --volumes` - Usunięcie całej nieużywanej zawartości dockera.


# Ćwiczenie 2.

Wykonaj konteneryzację aplikacji i uruchom aplikację w kontenerze z poziomu docker cli. Stwórz ręcznie plik Dockerfile, lub zastanów się, czy można zrobić to szybciej za pomocą Visual Studio.

1. Stwórz plik Dockerfile w katalogu FootballHub

`FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base` - Ściągamy .net core

`WORKDIR /app` - Definiujemy katalog roboczy

`EXPOSE 80` - Otwieramy port 80 (domyślny dla HTTP)

`EXPOSE 443` - Otwieramy port 443 (domyślny dla HTTPS)

`FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build` - Ściągamy .net core sdk

`WORKDIR /src` - Definiujemy katalog roboczy

`COPY ["FootballHub/FootballHub.csproj", "FootballHub/"]` - Kopiujemy projekt

`RUN dotnet restore "FootballHub/FootballHub.csproj"` - Ściągamy paczki nugetowe

`COPY . .` - Kopiujemy zawartość folderu do katalogu roboczego w kontenerze

`WORKDIR "/src/FootballHub"` - Definiujemy katalog roboczny ponownie

`RUN dotnet build "FootballHub.csproj" -c Release -o /app/build` - Budujemy projekt

`FROM build AS publish` - Przygotowujemy się do opublikowania projektu

`RUN dotnet publish "FootballHub.csproj" -c Release -o /app/publish` - Publikujemy projekt

`FROM base AS final` - Definiujemy ostatni krok

`WORKDIR /app` - Wybieramy katalog roboczy

`COPY --from=publish /app/publish .` - Kopiujemy

`ENTRYPOINT ["dotnet", "FootballHub.dll"]` - Wykonujemy komendę startową

*Zastanów się* - czy możemy zoptymalizować podane kroki?

2. Zbuduj aplikację komendą `docker build .`
3. Upewnij się czy aplikacja została zbudowana: `docker images`
4. Wystartuj aplikację: `docker run [IMAGE_ID] -d`
5. Sprawdź czy aplikacja chodzi `docker ps -a`
6. Spróbuj się połączyć z aplikacją. Czy taki był Twój oczekiwany rezultat?
7. Zastopuj i usuń kontener (z pomocą przyjdzie ściąga z pkt 1)
8. Uruchom ponownie kontener za pomocą `docker run -d -p 8080:80 -p 8081:443 --name=FootballHub [IMAGE_ID]`


# Ćwiczenie 3.

Wykonaj komendę git pull. Na repozytorium powinien pojawić się podstawowy plik docker-compose. Pobierz go, uruchom i zastanów się jak działa. Dodaj do niego bazę danych mssql i uruchom.

Ściąga: https://pastebin.com/iTsJYXcm

Uruchomienie:

`docker-compose up -d`

# Ćwiczenie 4.

Nie wyłączając kontenerów włącz docker desktop i zapoznaj się z funkcjami Docker GUI.

# Ćwiczenie 5 - zadanie domowe/dla chętnych

Skonteneryzuj swój projekt i skonfiguruj uruchamianie go za pomocą docker-compose z poziomu Visual Studio.
