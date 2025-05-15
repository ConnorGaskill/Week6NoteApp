using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6NoteApp.Services
{
    public class InMemoryNoteRepository : INoteRepository
    {
        private List<Note> _notes = new();

        public void Add(Note note) => _notes.Add(note);

        public List<Note> GetAll() => _notes;
    }
}