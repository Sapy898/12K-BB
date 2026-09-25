using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    // Készíts egy Book nevű recordot!

    // A record az alábbi adatokat tárolja:
    // - Title : string – public, immutable
    // - Author : string – public, immutable
    // - Pages : int – public, immutable
    // - Price : int – public, mutable
    internal record Book(string Title, string Author,int Pages)
    {
        public double Price { get; set; } 

        // Készíts egy public függvényt, amely paraméterként kap egy százalékos kedvezményt, és ennek megfelelően csökkenti a könyv árát!
        public void UpdatePrice(double percent)
        {
            Price *= (100-percent)/ 100;
        }
        // Készíts egy public függvényt, amely kiszámolja és visszaadja, hogy 3 darab könyv megvásárlása összesen mennyibe kerülne!
        public double GetPrice() 
        { 
            return Price * 3; 
        }
        


        

        // Példányosíts két Student objektumot:
        // "Nagy Anna", "12.A", 2008, 4.7
        // "Kiss Bence", "12.B", 2007, 3.8

        // Módosítsd az egyik tanuló átlagát!
        // Próbáld meg az Average értékét közvetlenül módosítani a Program.cs file-ból!
        // Írd ki mindkét tanuló nevét és szöveges értékelését!


        // 3. feladat – VideoGame

        

        // Példányosíts két VideoGame objektumot:
        // "Cyberpunk 2077", "CD Projekt", 2020, 19990, 8.6
        // "Red Dead Redemption 2", "Rockstar Games", 2018, 18990, 9.6

        // Állapítsd meg a függvény segítségével, hogy a játékok hány évesek 2026-ban!
        // Vizsgáld meg, hogy 15000 Ft-ból megvásárolhatók-e!
        // Módosítsd az egyik játék árát!

        // Próbáld meg a Program.cs file-ból közvetlenül kiírni a ReleaseYear és Price értékét!
        // Figyeld meg, hogy mely adatok érhetők el közvetlenül és melyek nem!


        // 4. feladat – Employee

        // Készíts egy Employee nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Name : string – public, immutable
        // - Position : string – public, immutable
        // - Salary : int – private, mutable
        // - WorkedHours : int – private, mutable
        // - OvertimeHours : int – private, mutable

        // Készíts egy private függvényt, amely kiszámolja az órabért!
        // Az órabér kiszámításához a fizetést oszd el 160-nal!

        // Készíts egy public függvényt, amely a private órabérszámító függvény segítségével kiszámolja a túlórákért járó összeget!
        // Egy túlóra az alap órabér 150%-át érje!

        // Készíts egy public függvényt, amely paraméterként kap egy ledolgozott óraszámot!
        // Ha a dolgozó eléri a 160 órát, az ezen felüli órákat az OvertimeHours értékéhez adja hozzá!

        // Példányosíts két Employee objektumot:
        // "Kovacs Peter", "Developer", 650000, 155, 0
        // "Szabo Eva", "Designer", 580000, 160, 4

        // Az első dolgozóhoz adj hozzá 15 ledolgozott órát!
        // Számítsd ki mindkét dolgozó túlórájáért járó összeget!

        // Próbáld meg a private adatokat közvetlenül elérni a Program.cs file-ból!


        // 5. feladat – FootballPlayer

        // Készíts egy FootballPlayer nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Name : string – public, immutable
        // - Nationality : string – public, immutable
        // - BirthYear : int – private, immutable
        // - Team : string – private, mutable
        // - Goals : int – protected, mutable
        // - Matches : int – protected, mutable

        // Készíts egy public függvényt, amely egy lejátszott mérkőzés után eggyel növeli a Matches értékét, és paraméterként kapja, hogy a játékos hány gólt szerzett a mérkőzésen!
        // A kapott gólszámot adja hozzá a Goals értékéhez!

        // Készíts egy public függvényt, amely kiszámolja a játékos meccsenkénti gólátlagát!

        // Készíts egy private függvényt, amely eldönti, hogy a játékos átigazolható-e!
        // A játékos akkor igazolható át, ha legalább 10 mérkőzést játszott.

        // Készíts egy public függvényt, amely paraméterként kap egy új csapatnevet!
        // A Team értékét csak akkor módosítsa, ha a private függvény szerint a játékos átigazolható!

        // Példányosíts két FootballPlayer objektumot:
        // "Daniel Kovacs", "Hungarian", 2001, "Budapest FC", 8, 12
        // "Adam Nagy", "Hungarian", 2005, "Lake United", 3, 6

        // Mindkét játékosnál rögzíts egy új mérkőzést!
        // Az első játékos 2 gólt, a második játékos 1 gólt szerezzen!

        // Számítsd ki a játékosok meccsenkénti gólátlagát!
        // Próbáld meg mindkét játékost átigazolni egy új csapatba!

        // Vizsgáld meg, hogy a public, private és protected adatok közül
        // melyek érhetők el közvetlenül a Program.cs file-ból!


        // 6. feladat – Movie + with expression

        // Készíts egy Movie nevű recordot!

        // A record az alábbi adatokat tárolja:
        // - Title : string – public, immutable
        // - Director : string – public, immutable
        // - Genre : string – protected, immutable
        // - ReleaseYear : int – private, immutable
        // - Rating : double – private, mutable
        // - ViewerCount : int – protected, mutable

        // Készíts egy private függvényt, amely eldönti, hogy érvényes-e egy értékelés!
        // Egy értékelés akkor érvényes, ha 0 és 10 közé esik.

        // Készíts egy public függvényt, amely paraméterként kap egy új értékelést!
        // Csak akkor módosítsa a Rating értékét, ha a private függvény szerint az értékelés érvényes!

        // Készíts egy protected függvényt, amely eldönti, hogy a film népszerű-e!
        // A film akkor számít népszerűnek, ha legalább 1000000 nézője van.

        // Készíts egy public függvényt, amely visszaad egy szöveges összefoglalót a filmről!
        // Az összefoglaló tartalmazza a film címét, rendezőjét, megjelenési évét és értékelését!

        // Példányosíts egy Movie objektumot:
        // "Interstellar", "Christopher Nolan", "SciFi", 2014, 8.7, 2500000

        // Próbáld meg közvetlenül módosítani a Title értékét!
        // Figyeld meg, hogy az immutable tulajdonság miatt miért nem lehetséges!

        // Próbáld meg közvetlenül elérni a private ReleaseYear és Rating értékeket!
        // Próbáld meg közvetlenül elérni a protected Genre és ViewerCount értékeket!
        // Figyeld meg, hogy ezek közül melyek érhetők el a Program.cs file-ból!

        // Módosítsd a film értékelését 9.0-ra a megfelelő függvény segítségével!

        // Készíts egy új Movie objektumot az eredeti alapján a "with" expression segítségével!
        // Az új objektum Title értéke legyen "Interstellar Extended"!

        // Készíts még egy másolatot a "with" expression segítségével!
        // Ennél a Director értéke legyen "John Smith"!

        // Írd ki az eredeti objektum és a két új objektum adatait!
        // Ellenőrizd, hogy az eredeti objektum immutable értékei nem változtak meg!
    }
}
