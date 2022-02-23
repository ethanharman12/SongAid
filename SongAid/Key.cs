using System.Collections.Generic;

namespace SongAid
{
    public class Key
    {
        public Tone Tone;
        public string Name;
        public List<Note> Notes;
        public Note Root;
    }

    public enum Tone
    {
        Major,
        Minor
    }
}
