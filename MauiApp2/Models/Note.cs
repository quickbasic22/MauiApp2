using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime NoteDate { get; set; }
        public bool Complete { get; set; }

        public override string ToString()
        {
            return Name + " " + Description + " " + NoteDate; 
        }

        public static ObservableCollection<Note> GetNotes()
        {
           var Notes = new ObservableCollection<Note>();
            Notes.Add(new Note() { Id = 1, Name = "Mow Yard", Description = "Weed eating with electric Trimmer", NoteDate = DateTime.Now, Complete = false});
            Notes.Add(new Note() { Id = 2, Name = "Clean Refigurator", Description = "Hand wash", NoteDate = DateTime.Now.AddDays(-7), Complete = true });
            Notes.Add(new Note() { Id = 3, Name = "Wash Windows", Description = "Using Car Windshield washer", NoteDate = DateTime.Now.AddDays(14), Complete = false });
            return Notes;
        }
    }
}
