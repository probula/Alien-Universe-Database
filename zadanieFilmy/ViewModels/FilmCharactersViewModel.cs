using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using zadanieFilmy.Models;

namespace zadanieFilmy.ViewModels;

public class FilmCharactersViewModel : ReactiveObject
{
    public ObservableCollection<Postac> Postac { get; } = new()
    {
        new Postac()
        {
            ImieINazwisko = "Ellen Louise Ripley",
            Film = "Alien (1979), Aliens (1986), Alien³ (1992), Alien: Resurrection (1997)",
            Rola = "Oficer porządkowy, później specjalistka ds. bezpieczeństwa",
            Aktor = "Sigourney Weaver",
            Rasa = "Człowiek",
            RokUrodzeniaFikcyjny = 2092,
            FunkcjaWZalodze = "Odpowiada za bezpieczeństwo załogi oraz przestrzeganie protokołów misji handlowych.",
            Charakterystyka = "Zdeterminowana, inteligentna, odporna psychicznie. Jej decyzje często ratują załogę kosztem własnego komfortu.\nSymbol siły i walki człowieka z nieznanym.",
            Los = "Ginęła w filmie „Alien³”, by uniemożliwić korporacji zdobycie królowej obcych.\nPóźniej została sklonowana (film „Resurrection”).",
            Ciekawostka = "Sigourney Weaver była nominowana do Oscara za rolę w „Aliens” — to rzadkość w kinie sci-fi.",
            FilmIds = new List<int>{1,2,3,4}
            
            
        },
        new Postac()
        {
            ImieINazwisko = "Arthur Koblenz Dallas",
            Film = "Alien (1979)",
            Rola = "Kapitan statku handlowego USCSS Nostromo",
            Aktor = "Tom Skerritt",
            Rasa = "Człowiek",
            RokUrodzeniaFikcyjny = 2071,
            FunkcjaWZalodze = "Dowódca misji, odpowiedzialny za decyzje dotyczące lądowania i bezpieczeństwa załogi.",
            Charakterystyka = "Opanowany, odpowiedzialny, często stawia bezpieczeństwo załogi ponad własne emocje.\nZmuszony do podjęcia trudnych decyzji w obliczu kontaktu z obcą formą życia.",
            Los = "Zginął podczas próby schwytania obcego w kanałach wentylacyjnych Nostromo.",
            Ciekawostka = "W scenariuszu oryginalnie rozważano alternatywne zakończenie, w którym Dallas zostaje odnaleziony żywy, uwięziony w kokonach obcego.",
            FilmIds = new List<int>{1}
        },
        new Postac()
        {
            ImieINazwisko = "Ash",
            Film = "Alien (1979)",
            Rola = "Oficer naukowy Nostromo",
            Aktor = "Ian Holm",
            Rasa = "Android (model Hyperdyne Systems 120-A/2)",
            RokUrodzeniaFikcyjny = 0000,
            FunkcjaWZalodze = "Odpowiada za analizę sygnałów i badania naukowe obiektów pozaziemskich.",
            Charakterystyka = "Zewnętrznie spokojny i profesjonalny, w rzeczywistości kierowany tajnymi rozkazami korporacji.",
            Los = "Zniszczony przez załogę po ujawnieniu, że jego misją było zachowanie obcego przy życiu.",
            Ciekawostka = "Ash jest pierwszym androidem w uniwersum Alien i początkiem całego wątku sztucznej inteligencji.",
            FilmIds = new List<int>{1}
        },
        new Postac()
        {
            ImieINazwisko = "Bishop",
            Film = "Aliens (1986), Alien³ (1992)",
            Rola = "Oficer naukowy, android kolonialnych marines",
            Aktor = "Lance Henriksen",
            Rasa = "Android (model Hyperdyne 341-B)",
            RokUrodzeniaFikcyjny = 0000,
            FunkcjaWZalodze = "Zajmuje się systemami analizy danych i wspiera operacje bojowe.",
            Charakterystyka = "Empatyczny, lojalny, różni się od Asha — ma autentyczne poczucie etyki.",
            Los = "Ciężko uszkodzony przez królową obcych, później dezaktywowany.",
            Ciekawostka = "Bishop jest jednym z niewielu androidów w kinie, który naprawdę wzbudza zaufanie.",
            FilmIds = new List<int>{2,3}
        },
        new Postac()
        {
            ImieINazwisko = "Jenette Vasquez",
            Film = "Aliens (1986)",
            Rola = "Strzelec kolonialnych marines",
            Aktor = "Jenette Goldstein",
            Rasa = "Człowiek",
            RokUrodzeniaFikcyjny = 2124,
            FunkcjaWZalodze = "Specjalistka od broni ciężkiej i operacji w ciasnych korytarzach kolonii.",
            Charakterystyka = "Odważna, twarda i zadziorna. Nie boi się śmierci i żartuje nawet w obliczu zagrożenia.",
            Los = "Poświęca życie, wysadzając korytarz pełen obcych, by uratować innych marines.",
            Ciekawostka = "Postać Vasquez była wzorem dla wielu późniejszych bohaterek gier i filmów sci-fi.",
            FilmIds = new List<int>{2}
        },
        new Postac()
        {
            ImieINazwisko = "Rebecca \"Newt\" Jorden",
            Film = "Aliens (1986)",
            Rola = "Jedyna ocalała z kolonii Hadley’s Hope",
            Aktor = "Carrie Henn",
            Rasa = "Człowiek",
            RokUrodzeniaFikcyjny = 2172,
            FunkcjaWZalodze = "Nieformalna towarzyszka Ripley, dziecko, które przetrwało atak ksenomorfów.",
            Charakterystyka = "Sprytna, cicha, zaskakująco odporna psychicznie mimo wieku.",
            Los = "Ginęła w katastrofie statku Sulaco (początek „Alien³”).",
            Ciekawostka = "Carrie Henn po tym filmie nigdy więcej nie wystąpiła w żadnym filmie.",
            FilmIds = new List<int>{2,3}
        },
        new Postac()
        {
            ImieINazwisko = "The Queen Alien",
            Film = "Aliens (1986), Alien: Resurrection (1997)",
            Rola = "Matka i królowa ksenomorfów",
            Aktor = "efekty praktyczne i animatronics",
            Rasa = "Obcy (Ksenomorf Królowa)",
            RokUrodzeniaFikcyjny = 0000,
            FunkcjaWZalodze = "Nie dotyczy — centralna postać hierarchii obcych, odpowiedzialna za składanie jaj.",
            Charakterystyka = "Niezwykle inteligentna, agresywna, pełna instynktu macierzyńskiego.",
            Los = "Zniszczona przez Ripley w ładowni statku Sulaco, ponownie klonowana w „Resurrection”.",
            Ciekawostka = "Do animacji Królowej Obcych użyto modelu o wysokości ponad 4 metrów.",
            FilmIds = new List<int>{2,4}
        },
        new Postac()
        {
            ImieINazwisko = "Annalee Call",
            Film = "Alien: Resurrection (1997)",
            Rola = "Członkini załogi statku Betty",
            Aktor = "Winona Ryder",
            Rasa = "Android (model Auton – stworzony przez androidy)",
            RokUrodzeniaFikcyjny = 2381,
            FunkcjaWZalodze = "Specjalistka ds. techniki i hakowania systemów wojskowych.",
            Charakterystyka = "Empatyczna, emocjonalna, wykazuje moralność bardziej ludzką niż większość ludzi.",
            Los = "Przeżywa i opuszcza Ziemię wraz z klonem Ripley.",
            Ciekawostka = "Call to pierwszy android w serii, który został stworzony przez inne androidy.",
            FilmIds = new List<int>{4}
        },
        new Postac()
        {
            ImieINazwisko = "Ripley 8",
            Film = "Alien: Resurrection (1997)",
            Rola = "Klon Ellen Ripley z DNA królowej obcych",
            Aktor = "Sigourney Weaver",
            Rasa = "Hybryda (Człowiek / Obcy)",
            RokUrodzeniaFikcyjny = 2381,
            FunkcjaWZalodze = "Pomaga załodze Betty w walce z obcymi na statku USM Auriga.",
            Charakterystyka = "Silna fizycznie i emocjonalnie, rozdarta między naturą człowieka i obcego.",
            Los = "Przeżywa wydarzenia filmu, ale nie ufa już ani ludziom, ani korporacjom.",
            Ciekawostka = "Ma kwaśną krew i zdolności nadludzkie, będąc symbolicznym połączeniem dwóch światów.",
            FilmIds = new List<int>{4}
        },
        new Postac()
        {
            ImieINazwisko = "The Engineer",
            Film = "Prometheus (2012)",
            Rola = "Starożytna istota – stwórca ludzi",
            Aktor = "Ian Whyte",
            Rasa = "Inżynier",
            RokUrodzeniaFikcyjny = 0000,
            FunkcjaWZalodze = "Nie jest członkiem załogi – reprezentuje cywilizację twórców, którzy stworzyli życie na Ziemi.",
            Charakterystyka = "Milczący, majestatyczny, potężny. Symbol boskiej pychy.",
            Los = "Budzi się z hibernacji i morduje członków misji Prometeusza, po czym ginie.",
            Ciekawostka = "Postać Inżyniera łączy mit o stworzeniu człowieka z początkiem gatunku Obcych.",
            FilmIds = new List<int>{5}
        },
        new Postac()
        {
            ImieINazwisko = "Neomorph",
            Film = "Alien: Covenant (2017)",
            Rola = "Forma pośrednia między stworzeniem Davida a ksenomorfem",
            Aktor = "CGI / efekty komputerowe",
            Rasa = "Obcy (mutant)",
            RokUrodzeniaFikcyjny = 0000,
            FunkcjaWZalodze = "Nie dotyczy — stworzenie eksperymentalne Davida, symbol błędu ewolucji.",
            Charakterystyka = "Nieprzewidywalny, szybki i niestabilny biologicznie.",
            Los = "Zabity przez załogę Covenant.",
            Ciekawostka = "Neomorphy były inspirowane koncepcją „białego drapieżcy” z natury — połączeniem piękna i grozy.",
            FilmIds = new List<int>{6}
        },
        new Postac()
        {
            ImieINazwisko = "Daniels Branson",
            Film = "Alien: Covenant (2017)",
            Rola = "Oficer kolonizacyjny",
            Aktor = "Katherine Waterston",
            Rasa = "Człowiek",
            RokUrodzeniaFikcyjny = 2100,
            FunkcjaWZalodze = "Projektantka kolonii, kieruje działaniami terraformacyjnymi.",
            Charakterystyka = "Pragmatyczna, ale odważna i zdeterminowana.",
            Los = "Zostaje uśpiona w kapsule przez Davida, który podszywa się pod androida Waltera.",
            Ciekawostka = "Scott chciał, by Daniels była symbolicznym „nowym początkiem” linii bohaterek.",
            FilmIds = new List<int>{6}
        }
    };
}
