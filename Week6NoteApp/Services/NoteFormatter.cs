using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6NoteApp.Services
{
    public class NoteFormatter : INoteFormatter
    {
        public string Format(List<Note> notes)
        {
            return string.Join("\n", notes.Select(n => $"{n.CreatedAt}: {n.Text}"));
        }
    }

}
