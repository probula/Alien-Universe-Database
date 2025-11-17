using System.Collections.ObjectModel;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using zadanieFilmy.Models;

namespace zadanieFilmy.ViewModels;

public class FilmDetailsViewModel
{
       public ObservableCollection<Film> Filmy { get; } = new()
        {
            new Film
            {
                TytulOryginalny = "Alien",
                TytulPolski = "Obcy – ósmy pasażer Nostromo",
                RokPremiery = 1979,
                Rezyser = "Ridley Scott",
                Scenariusz = "Dan O’Bannon",
                Gatunek = "Sci-Fi / Horror",
                CzasTrwania = 117,
                Ocena = 8.5,
                GlownePostacie = "Ellen Ripley, Dallas, Ash, Lambert, Kane",
                Statek = "USCSS Nostromo",
                OpisFabuly = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
                Ciekawostka = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne.",
                Id = 1
            },
            new Film
            {
                TytulOryginalny = "Aliens",
                TytulPolski = "Obcy – decydujące starcie",
                RokPremiery = 1986,
                Rezyser = "James Cameron",
                Scenariusz = "James Cameron, David Giler, Walter Hill",
                Gatunek = "Sci-Fi / Akcja / Horror",
                CzasTrwania = 137,
                Ocena = 8.4,
                GlownePostacie = "Ellen Ripley, Hicks, Newt, Bishop, Vasquez",
                Statek = "USS Sulaco",
                OpisFabuly = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
                Ciekawostka = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł, który jest liczbą mnogą słowa „Alien” – symbolicznie zapowiadając, że tym razem potworów będzie więcej.",
                Id = 2
            },
            new Film
            {
                TytulOryginalny = "Alien³",
                TytulPolski = "Obcy³",
                RokPremiery = 1992,
                Rezyser = "David Fincher",
                Scenariusz = "David Giler, Walter Hill, Larry Ferguson",
                Gatunek = "Sci-Fi / Horror",
                CzasTrwania = 114,
                Ocena = 6.5,
                GlownePostacie = "Ellen Ripley, Dillon, Clemens, Morse, Andrews",
                Statek = "E.E.V. z USS Sulaco (katastrofa)",
                OpisFabuly = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
                Ciekawostka = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu.",
                Id = 3
            },
            new Film
            {
                TytulOryginalny = "Alien: Resurrection",
                TytulPolski = "Obcy: Przebudzenie",
                RokPremiery = 1997,
                Rezyser = "Jean-Pierre Jeunet",
                Scenariusz = "Joss Whedon",
                Gatunek = "Sci-Fi / Horror",
                CzasTrwania = 109,
                Ocena = 6.2,
                GlownePostacie = "Ellen Ripley (klon), Call, Johner, Christie, Dr. Gediman",
                Statek = "USM Auriga",
                OpisFabuly = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
                Ciekawostka = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała.",
                Id = 4
            },
            new Film
            {
                TytulOryginalny = "Prometheus",
                TytulPolski = "Prometeusz",
                RokPremiery = 2012,
                Rezyser = "Ridley Scott",
                Scenariusz = "Jon Spaihts, Damon Lindelof",
                Gatunek = "Sci-Fi / Thriller",
                CzasTrwania = 124,
                Ocena = 7.0,
                GlownePostacie = "Elizabeth Shaw, David, Charlie Holloway, Meredith Vickers",
                Statek = "USCSS Prometheus",
                OpisFabuly = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
                Ciekawostka = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni.",
                Id = 5
            },
            new Film
            {
                TytulOryginalny = "Alien: Covenant",
                TytulPolski = "Obcy: Przymierze",
                RokPremiery = 2017,
                Rezyser = "Ridley Scott",
                Scenariusz = "John Logan, Dante Harper",
                Gatunek = "Sci-Fi / Horror",
                CzasTrwania = 122,
                Ocena = 6.4,
                GlownePostacie = "Daniels, David, Walter, Oram, Tennessee",
                Statek = "USCSS Covenant",
                OpisFabuly = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
                Ciekawostka = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku.",
                Id = 6
            }
            
        };
        [Reactive]
        public Film SelectedFilm { get; set; }
}