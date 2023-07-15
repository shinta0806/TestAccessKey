using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml;
using TestAccessKey.Views;

namespace TestAccessKey.ViewModels;

public partial class MainViewModel : ObservableRecipient
{
    public MainViewModel()
    {
        ButtonCloseClickedCommand = new RelayCommand(ButtonCloseClicked);
    }

    public RelayCommand ButtonCloseClickedCommand
    {
        get;
    }

    private void ButtonCloseClicked()
    {
        App.MainWindow.Close();
    }
}
