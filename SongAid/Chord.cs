using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongAid
{
    public class Chord
    {
        public Note Root { get; set; }
        public ChordTone Tone { get; set; }        
        public List<Note> Notes { get; set; }

        public Chord(Note root, ChordTone tone)
        {
            Tone = tone;
            Root = root;

            Notes = new List<Note> { root };
            if (tone == ChordTone.Major || tone == ChordTone.Augmented)
            {
                Notes.Add(root.AddStep(2));
            }
            else
            {
                Notes.Add(root.AddStep(1.5));
            }

            if (tone == ChordTone.Diminished)
            {
                Notes.Add(root.AddStep(3));
            }
            else if (tone == ChordTone.Augmented)
            {
                Notes.Add(root.AddStep(4));
            }
            else
            {
                Notes.Add(root.AddStep(3.5));
            }            
        }
    }

    public enum ChordTone
    {
        Major,
        Minor,
        Diminished,
        Augmented
    }
}
