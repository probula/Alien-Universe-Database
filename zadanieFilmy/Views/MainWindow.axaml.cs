using Avalonia.Controls;
using Avalonia.ReactiveUI;
using zadanieFilmy.Models;
using zadanieFilmy.ViewModels;

namespace zadanieFilmy.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
    }
}