using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public abstract class Instrument
    {
        #region Properties
        public string Name { get; set; }

        internal List<InstrumentNote> Notes { get; set; } = new List<InstrumentNote>();

        internal List<InstrumentString> InstrumentStrings { get; set; } = new List<InstrumentString>();

        internal List<InstrumentFret> InstrumentFret { get; set; } = new List<Music.InstrumentFret>();
        #endregion

        #region Methods
        public void Play(string noteName)
        {
            //Get Note to play
            InstrumentNote note=this.Notes.Find(x => x.NoteName == noteName);
            //Play Note on Console
            Console.WriteLine(this.Name + " is playing Note: " + noteName + " String: " + note.InstrumentString.StringNumber + " Fret: " + note.InstrumentFret.fretBoardNumer);
        }
        #endregion

    }
}
