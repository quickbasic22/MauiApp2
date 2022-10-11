# MauiApp2

Creates property Note from private Note note; (Field) using attributes


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
