using ReactiveUI;
using zadanieFilmy.Models;

namespace zadanieFilmy.ViewModels;

public class FilmDetailsViewModel
{
    public string Rezyser { get; set; }
    public string Scenariusz { get; set; }
    public string Gatunek { get; set; }
    public int RokPremiery { get; set; }
    public int CzasTrwania { get; set; }
    public double Ocena { get; set; }
    public string GlownePostacie { get; set; }
    public string Statek { get; set; }
}