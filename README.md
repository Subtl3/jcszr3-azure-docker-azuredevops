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

# Ćwiczenie 3.

Wykonaj komendę git pull. Na repozytorium powinien pojawić się podstawowy plik docker-compose. Pobierz go, uruchom i zastanów się jak działa. Dodaj do niego bazę danych mssql i uruchom.

# Ćwiczenie 4.

Nie wyłączając kontenerów włącz docker desktop i zapoznaj się z funkcjami Docker GUI.

# Ćwiczenie 5 - zadanie domowe/dla chętnych

Skonteneryzuj swój projekt i skonfiguruj uruchamianie go za pomocą docker-compose z poziomu Visual Studio.
