using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp2.Models;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace MauiApp2.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor("NoteSummary")]           
        private Note note;
        [ObservableProperty]
        [NotifyPropertyChangedFor("NameDetails")]
        private string name;
        [ObservableProperty]
        [NotifyPropertyChangedFor("NameDetails")]
        private string description;
        public ObservableCollection<Note> Notes { get; set; }
        public string NameDetails => name + " " + description;
        public string NoteSummary => $"{Note.Name} {Note.Description} {Note.NoteDate}";
        public MainPageViewModel()
        {
            Notes = Note.GetNotes();
            
        }

        [RelayCommand]
        void Submit()
        {
            Debug.WriteLine("Hello World");
        }
    }
}
