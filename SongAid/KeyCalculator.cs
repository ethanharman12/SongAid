using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongAid
{
    public static class KeyCalculator
    {
        public static List<Key> CalculateKeys()
        {
            var keys = new List<Key>();

            var noteNames = Enum.GetNames(typeof(Note));

            foreach (var noteName in noteNames)
            {
                var note = (Note)Enum.Parse(typeof(Note), noteName);
                var majorKey = new Key { Name = noteName.Replace('s', '\u266F').Replace('f', '\u266D') + " Major", Tone = Tone.Major, Root = note, Notes = new List<Note>() };
                var minorKey = new Key { Name = noteName.Replace('s', '\u266F').Replace('f', '\u266D') + " Minor", Tone = Tone.Minor, Root = note, Notes = new List<Note>() };

                majorKey.Root = note;
                majorKey.Notes.AddRange(note.AddStep(0));
                majorKey.Notes.AddRange(note.AddStep(20));
                majorKey.Notes.AddRange(note.AddStep(40));
                majorKey.Notes.AddRange(note.AddStep(50));
                majorKey.Notes.AddRange(note.AddStep(70));
                majorKey.Notes.AddRange(note.AddStep(90));
                majorKey.Notes.AddRange(note.AddStep(110));

                minorKey.Root = note;
                minorKey.Notes.AddRange(note.AddStep(0));
                minorKey.Notes.AddRange(note.AddStep(20));
                minorKey.Notes.AddRange(note.AddStep(30));
                minorKey.Notes.AddRange(note.AddStep(50));
                minorKey.Notes.AddRange(note.AddStep(70));
                minorKey.Notes.AddRange(note.AddStep(80));
                minorKey.Notes.AddRange(note.AddStep(100));

                keys.Add(majorKey);
                keys.Add(minorKey);
            }

            return keys;
        }
    }

    public static class NoteExtensions
    {
        public static List<Note> AddStep(this Note note, int step)
        {
            var notes = new List<Note>();

            var intValue = ((int)note + step) % 120;
            var tensPlace = intValue / 10;

            notes.Add((Note)(tensPlace * 10));
            var equivalent = (tensPlace * 10) + 1;
            if (Enum.IsDefined(typeof(Note), equivalent))
            {
                notes.Add((Note)equivalent);
            }

            return notes;
        }
    }
}
