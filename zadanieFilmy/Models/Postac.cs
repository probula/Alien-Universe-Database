namespace zadanieFilmy.Models;

public class Postac
{
    public string ImieINazwisko { get; set; } = "";
    public string Rola { get; set; } = "";
    public string Aktor { get; set; } = "";
    public string Rasa { get; set; } = ""; 
    public int RokUrodzeniaFikcyjny { get; set; }
    public string FunkcjaWZalodze { get; set; } = "";
    public string Charakterystyka { get; set; } = "";
    public string Los { get; set; } = "";
    public string Ciekawostka { get; set; } = "";
}