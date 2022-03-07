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

            var notes = Enum.GetValues(typeof(Note)).Cast<Note>().ToList();

            foreach (var note in notes)
            {
                var noteName = note.GetName();
                var majorKey = new Key { Name = noteName + " Major", Tone = KeyTone.Major, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var dorianKey = new Key { Name = noteName + " Dorian (mellow, smooth, Santana)", Tone = KeyTone.Dorian, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var phrygianKey = new Key { Name = noteName + " Phrygian (exotic, creepy)", Tone = KeyTone.Phrygian, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var lydianKey = new Key { Name = noteName + " Lydian (floaty, spacy)", Tone = KeyTone.Lydian, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var mixolydianKey = new Key { Name = noteName + " Mixolydian (rock, irish)", Tone = KeyTone.HarmonicMinor, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var minorKey = new Key { Name = noteName + " Minor", Tone = KeyTone.Minor, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };
                var locrianKey = new Key { Name = noteName + " Locrian", Tone = KeyTone.Locrian, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };

                var harmonicMinorKey = new Key { Name = noteName + " Harmonic Minor", Tone = KeyTone.HarmonicMinor, Root = note, Notes = new List<Note>(), Chords = new List<Chord>() };

                majorKey.Root = note;
                majorKey.Chords.Add(new Chord(note, ChordTone.Major));
                majorKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Minor));
                majorKey.Chords.Add(new Chord(note.AddStep(2), ChordTone.Minor));
                majorKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Major));
                majorKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Major));
                majorKey.Chords.Add(new Chord(note.AddStep(4.5), ChordTone.Minor));
                majorKey.Chords.Add(new Chord(note.AddStep(5.5), ChordTone.Diminished));

                majorKey.Notes = majorKey.Chords.Select(c => c.Root).ToList();

                dorianKey.Root = note;
                dorianKey.Chords.Add(new Chord(note, ChordTone.Minor));
                dorianKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Minor));
                dorianKey.Chords.Add(new Chord(note.AddStep(1.5), ChordTone.Major));
                dorianKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Major));
                dorianKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Minor));
                dorianKey.Chords.Add(new Chord(note.AddStep(4.5), ChordTone.Diminished));
                dorianKey.Chords.Add(new Chord(note.AddStep(5), ChordTone.Major));

                dorianKey.Notes = dorianKey.Chords.Select(c => c.Root).ToList();

                phrygianKey.Root = note;
                phrygianKey.Chords.Add(new Chord(note, ChordTone.Minor));
                phrygianKey.Chords.Add(new Chord(note.AddStep(.5), ChordTone.Major));
                phrygianKey.Chords.Add(new Chord(note.AddStep(1.5), ChordTone.Major));
                phrygianKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Minor));
                phrygianKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Diminished));
                phrygianKey.Chords.Add(new Chord(note.AddStep(4), ChordTone.Major));
                phrygianKey.Chords.Add(new Chord(note.AddStep(5), ChordTone.Minor));

                phrygianKey.Notes = phrygianKey.Chords.Select(c => c.Root).ToList();

                lydianKey.Root = note;
                lydianKey.Chords.Add(new Chord(note, ChordTone.Major));
                lydianKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Major));
                lydianKey.Chords.Add(new Chord(note.AddStep(2), ChordTone.Minor));
                lydianKey.Chords.Add(new Chord(note.AddStep(3), ChordTone.Diminished));
                lydianKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Major));
                lydianKey.Chords.Add(new Chord(note.AddStep(4.5), ChordTone.Minor));
                lydianKey.Chords.Add(new Chord(note.AddStep(5.5), ChordTone.Minor));

                lydianKey.Notes = lydianKey.Chords.Select(c => c.Root).ToList();

                mixolydianKey.Root = note;
                mixolydianKey.Chords.Add(new Chord(note, ChordTone.Major));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Minor));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(2), ChordTone.Diminished));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Major));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Minor));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(4.5), ChordTone.Minor));
                mixolydianKey.Chords.Add(new Chord(note.AddStep(5), ChordTone.Major));

                mixolydianKey.Notes = mixolydianKey.Chords.Select(c => c.Root).ToList();

                minorKey.Root = note;
                minorKey.Chords.Add(new Chord(note, ChordTone.Minor));
                minorKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Diminished));
                minorKey.Chords.Add(new Chord(note.AddStep(1.5), ChordTone.Major));
                minorKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Minor));
                minorKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Minor));
                minorKey.Chords.Add(new Chord(note.AddStep(4), ChordTone.Major));
                minorKey.Chords.Add(new Chord(note.AddStep(5), ChordTone.Major));

                minorKey.Notes = minorKey.Chords.Select(c => c.Root).ToList();

                locrianKey.Root = note;
                locrianKey.Chords.Add(new Chord(note, ChordTone.Diminished));
                locrianKey.Chords.Add(new Chord(note.AddStep(.5), ChordTone.Major));
                locrianKey.Chords.Add(new Chord(note.AddStep(1.5), ChordTone.Minor));
                locrianKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Minor));
                locrianKey.Chords.Add(new Chord(note.AddStep(3), ChordTone.Major));
                locrianKey.Chords.Add(new Chord(note.AddStep(4), ChordTone.Major));
                locrianKey.Chords.Add(new Chord(note.AddStep(5), ChordTone.Minor));

                locrianKey.Notes = locrianKey.Chords.Select(c => c.Root).ToList();

                harmonicMinorKey.Root = note;
                harmonicMinorKey.Chords.Add(new Chord(note, ChordTone.Minor));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(1), ChordTone.Diminished));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(1.5), ChordTone.Augmented));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(2.5), ChordTone.Minor));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(3.5), ChordTone.Major));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(4), ChordTone.Major));
                harmonicMinorKey.Chords.Add(new Chord(note.AddStep(5.5), ChordTone.Diminished));

                harmonicMinorKey.Notes = harmonicMinorKey.Chords.Select(c => c.Root).ToList();

                keys.Add(majorKey);
                keys.Add(dorianKey);
                keys.Add(phrygianKey);
                keys.Add(lydianKey);                
                keys.Add(mixolydianKey);
                keys.Add(minorKey);
                keys.Add(locrianKey);

                keys.Add(harmonicMinorKey);
            }

            return keys;
        }
    }

    public static class NoteExtensions
    {
        public static Note AddStep(this Note note, double step)
        {
            return (Note)(((int)note + (step * 10)) % 60);
        }
    }
}
