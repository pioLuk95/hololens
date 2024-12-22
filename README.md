
# HoloLens project

Tutaj w repo wrzucam całe źródła projektu jakie mam.

Tutaj link do Trello, w którym umieściłem rzeczy, które już zrobiłem i niektóre z tych które trzeba zrobić. Są też jakieś opcjonalne.

https://trello.com/invite/660d8350253ce3cca2b1bdd8/ATTIb6df8218e805b99966a7535cd3ea5ce94902711A

Możecie tam sobie zaznaczać zadania, przerzucać etc.

# Szczegóły projektu

Moje stanowisko było takie:

- Win10
- Visual Studio 2019 v16.11.42
- Unity Hub 3.10.0 + Edytor 2019.4.40f1
- HoloLens Emulator 10.1.17763.134


# Elementy zrobione

Zrobione przeze mnie rzeczy są w Trello, także można podejrzeć.

W skrócie: Mamy utworzony projekt na frameworku MRTK. Jest dodana obsługa Gaze (kursora) oraz Spatial Awerness (mapowanie pokoju). Aktualnie jest tam umieszczona statycznie tarcza do Darta. Tarcza ma dodany Collider w kształcie koła, który trzeba tylko bardziej dopasować do kształu tarczy.

Utworzony jest element DartSpawnManager - jest to niewidoczny element, pod który podpięty jest customowy skrypt. Ten skrypt powinien na gesty "pinch" tworzyć statyczny obiekt rzutki Dartowej. Tutaj zadanie ma ktoś inny, bo uruchamiając apkę w Unity - działa. Kliknięcie myszy robi nową rzutkę. Gorzej z emulatorem, bo tam rzutka pojawia się tylko, jeśli zmienicie input na klawiaturę, a nie "ludzki". To jest pewnie kwestia researchu na temat tego jak symulować dobrze gesty w emulatorze (Gdzie i tak faktycznie wyjdzie to w praniu na fizycznych hololensach).


# Instalacja

WAŻNE!!!!!!

Z racji problemów GIT'a z jednym z dużych plików, trzeba go przerzucić ręcznie. Nie wiem czy jest na 100% potrzebny - można sprawdzić.

Plik pobieramy z dysku: https://drive.google.com/file/d/1gD8j8jhvwR8NuTIgf1ncdbWKwUNIgmlT/view?usp=sharing

I wrzucamy do projektu: Library->PlayerDataCache->WindowsStoreApps->Data-> i tu wkleić


To tyle - działamy


