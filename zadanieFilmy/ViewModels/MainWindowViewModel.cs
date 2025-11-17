using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using zadanieFilmy.Models;
using zadanieFilmy.ViewModels;


namespace zadanieFilmy.ViewModels;

public class MainWindowViewModel : ReactiveObject

{
    
    private readonly FilmCharactersViewModel _charactersVM = new FilmCharactersViewModel();
    public ObservableCollection<Film> Filmy { get; }

    public ObservableCollection<Postac> Postacie { get; } = new ObservableCollection<Postac>();
    public ReactiveCommand<Unit, Unit> PokazInfoPostacie { get; }
    
    [Reactive]
    public Film SelectedFilm { get; set; }
    

    public MainWindowViewModel()
    {
        var filmDetailsVM = new FilmDetailsViewModel();
        Filmy = filmDetailsVM.Filmy;

        SelectedFilm = Filmy.FirstOrDefault();

        PokazInfoPostacie = ReactiveCommand.Create(() =>
        {
            Postacie.Clear();
            if (SelectedFilm == null) return;

            foreach (var p in _charactersVM.Postac)
            {
                if (p.FilmIds.Contains(SelectedFilm.Id))
                    Postacie.Add(p);
            }
        });
    }


    
}