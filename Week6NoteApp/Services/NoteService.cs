using System;
using System.Collections.Generic;
using System.Linq;

public class NoteService
{
    private readonly INoteRepository _repository;
    private readonly ILogger _logger;

    public NoteService(INoteRepository repository, ILogger logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public void AddNote(string text)
    {
        var note = new Note { Text = text, CreatedAt = DateTime.Now };
        _repository.Add(note);
        _logger.Log($"Note added: {text}");
    }

    public List<Note> GetAllNotes()
    {
        return _repository.GetAll();
    }
}