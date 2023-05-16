# GUIDb
### Passaggi alla creazione del progetto .NET su una applicazione WPF
###### Aprire la cartella su VisualStudio con il file chinook.db gia scaricato e inserito nella cartella ( per trovare il file cliccare il questo link : https://www.sqlitetutorial.net/sqlite-sample-database/#:~:text=the%20following%20link.-,Download%20SQLite%20sample%20database,-In%20case%20you )
###### Creare un file apposta per la classe degli artisti
![image](https://github.com/P4020/GUIDb/assets/117436985/ca00c507-9b3b-4c31-ac97-46595adf15af)
###### Per far si che il file cinook.db funzioni regolarmente inserire : 
``` 
using SQLite;
```
![image](https://github.com/P4020/GUIDb/assets/117436985/ff77fd9a-982f-4af1-ab32-13e3040fa944)
###### E inserire la libreria sqlite-net-pcl così che il programma non dia alcun errore come quando eravamo su Code. Quindi aprire il terminale e inserire il seguente comando :
```
dotnet add package sqlite-net-pcl
```
![image](https://github.com/P4020/GUIDb/assets/117436985/abdb3300-730b-4a1d-8bef-5500f4aeca9e)
### Codice C#
###### Per visualizzare gli artisti che troviamo nel file chinook.db utilizzare il seguente codice e andarlo ad incollare nel MainWondow.xaml.cs:
```
            SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
            List<Artist> tblArtists = cn1.Query<Artist>("select * from artists");
            Console.WriteLine($"In questa tabella ci sono {cn1.Query<Artist>("select * from artists").Count} record!");

            tblArtists = cn1.Query<Artist>("select * from artists").OrderByDescending(x=>x.Name).ToList();
            foreach(var artista in cn1.Query<Artist>("select * from artists"))
            {
                Console.WriteLine($"{artista.Name}");
            }    
 ```
 ![image](https://github.com/P4020/GUIDb/assets/117436985/20b0d871-2815-47e3-9fde-996ed5cbb1d5)

###### è lo stesso codice usato su Code che gira anche sull'applicazione WPF, l'unica cosa che grazie a WPF possiamo andare a vedere per bene a video tutta la tabella.
![image](https://github.com/P4020/GUIDb/assets/117436985/c0e44357-eade-407c-980b-9b4284aec1fa)
###### (Ecco come risulta tutta la tabella)

