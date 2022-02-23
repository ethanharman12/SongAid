using NUnit.Framework;
using SongAid;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SongAidTest
{
    public class KeyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculatedKeys()
        {
            var manualKeys = CreateKeys();
            var calculatedKeys = KeyCalculator.CalculateKeys();

            foreach (var manualKey in manualKeys)
            {
                var calcKey = calculatedKeys.FirstOrDefault(Key => Key.Root == manualKey.Root && Key.Tone == manualKey.Tone);

                Assert.NotNull(calcKey, manualKey.Name);

                Assert.AreEqual(calcKey.Notes.Intersect(manualKey.Notes).Count(), calcKey.Notes.Count);
                Assert.AreEqual(calcKey.Notes.Union(manualKey.Notes).Count(), calcKey.Notes.Count);
            }
        }

        private static List<Key> CreateKeys()
        {
            var keys = new List<Key>();

            keys.Add(new Key
            {
                Name = "C Major",
                Root = Note.C,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.C,
                Note.D,
                Note.E,
                Note.F,
                Note.G,
                Note.A,
                Note.B
            }
            });

            keys.Add(new Key
            {
                Name = "A Minor",
                Root = Note.A,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.C,
                Note.D,
                Note.E,
                Note.F,
                Note.G,
                Note.A,
                Note.B
            }
            });

            keys.Add(new Key
            {
                Name = "G Major",
                Root = Note.G,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.G,
                Note.A,
                Note.B,
                Note.C,
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
            }
            });

            keys.Add(new Key
            {
                Name = "E Minor",
                Root = Note.E,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.G,
                Note.A,
                Note.B,
                Note.C,
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
            }
            });

            keys.Add(new Key
            {
                Name = "D Major",
                Root = Note.D,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.G,
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
            }
            });

            keys.Add(new Key
            {
                Name = "B Minor",
                Root = Note.B,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.G,
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
            }
            });

            keys.Add(new Key
            {
                Name = "A Major",
                Root = Note.A,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
            }
            });

            keys.Add(new Key
            {
                Name = "F# Minor",
                Root = Note.Fs,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
            }
            });

            keys.Add(new Key
            {
                Name = "Gf Minor",
                Root = Note.Gf,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.D,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
            }
            });

            keys.Add(new Key
            {
                Name = "E Major",
                Root = Note.E,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
            }
            });

            keys.Add(new Key
            {
                Name = "C# Minor",
                Root = Note.Cs,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
            }
            });

            keys.Add(new Key
            {
                Name = "Df Minor",
                Root = Note.Df,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.A,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
            }
            });


            keys.Add(new Key
            {
                Name = "B Major",
                Root = Note.B,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
            }
            });

            keys.Add(new Key
            {
                Name = "G# Minor",
                Root = Note.Gs,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
            }
            });

            keys.Add(new Key
            {
                Name = "Af Minor",
                Root = Note.Af,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.E,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
            }
            });

            keys.Add(new Key
            {
                Name = "F# Major",
                Root = Note.Fs,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
            }
            });

            keys.Add(new Key
            {
                Name = "Gf Major",
                Root = Note.Gf,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
            }
            });

            keys.Add(new Key
            {
                Name = "D# Minor",
                Root = Note.Ds,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
            }
            });

            keys.Add(new Key
            {
                Name = "Ef Minor",
                Root = Note.Ef,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.B,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
            }
            });

            keys.Add(new Key
            {
                Name = "C# Major",
                Root = Note.Cs,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C
            }
            });

            keys.Add(new Key
            {
                Name = "Df Major",
                Root = Note.Df,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C
            }
            });

            keys.Add(new Key
            {
                Name = "A# Minor",
                Root = Note.As,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C
            }
            });

            keys.Add(new Key
            {
                Name = "Bf Minor",
                Root = Note.Bf,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.Fs,
                Note.Gf,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C
            }
            });

            keys.Add(new Key
            {
                Name = "G# Major",
                Root = Note.Gs,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
            }
            });

            keys.Add(new Key
            {
                Name = "Af Major",
                Root = Note.Af,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
            }
            });

            keys.Add(new Key
            {
                Name = "F Minor",
                Root = Note.F,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.Cs,
                Note.Df,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
            }
            });

            keys.Add(new Key
            {
                Name = "D# Major",
                Root = Note.Ds,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
            }
            });

            keys.Add(new Key
            {
                Name = "Ef Major",
                Root = Note.Ef,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
            }
            });

            keys.Add(new Key
            {
                Name = "C Minor",
                Root = Note.C,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.Gs,
                Note.Af,
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
            }
            });

            keys.Add(new Key
            {
                Name = "A# Major",
                Root = Note.As,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.A,
            }
            });

            keys.Add(new Key
            {
                Name = "Bf Major",
                Root = Note.Bf,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.A,
            }
            });

            keys.Add(new Key
            {
                Name = "G Minor",
                Root = Note.G,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
                Note.Ds,
                Note.Ef,
                Note.F,
                Note.G,
                Note.A,
            }
            });

            keys.Add(new Key
            {
                Name = "F Major",
                Root = Note.F,
                Tone = Tone.Major,
                Notes = new List<Note>()
            {
                Note.F,
                Note.G,
                Note.A,
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
                Note.E
            }
            });

            keys.Add(new Key
            {
                Name = "D Minor",
                Root = Note.D,
                Tone = Tone.Minor,
                Notes = new List<Note>()
            {
                Note.F,
                Note.G,
                Note.A,
                Note.As,
                Note.Bf,
                Note.C,
                Note.D,
                Note.E
            }
            });

            return keys;
        }
    }
}