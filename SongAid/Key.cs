using System.Collections.Generic;

namespace SongAid
{
    public class Key
    {
        public KeyTone Tone;
        public string Name;
        public List<Note> Notes;
        public Note Root;
        public List<Chord> Chords;
    }

    public enum KeyTone
    {
        Major,
        Dorian,
        Phrygian,
        Lydian,
        Mixolydian,
        Minor,
        Locrian,        
        
        HarmonicMinor        
    }
}
