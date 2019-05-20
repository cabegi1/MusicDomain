using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Bass : Instrument
    {
        public Bass()
        {
            InitializeBass();
        }

        private void InitializeBass()
        {
            //Set Name
            this.Name = "Bass";
            //Initialize 4 Strings
            InitializeStrings();
            //Initialize 3 Frets
            InitializeFrets();
            //Initialize Notes
            InitializeNotes();
        }

        private void InitializeStrings()
        {
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 1 });
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 2 });
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 3 });
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 4 });           
        }

        private void InitializeFrets()
        {
            this.InstrumentFret.Add(new InstrumentFret() { fretBoardNumer = 1 });
            this.InstrumentFret.Add(new InstrumentFret() { fretBoardNumer = 2 });
            this.InstrumentFret.Add(new InstrumentFret() { fretBoardNumer = 2 });
        }


        private void InitializeNotes()
        {
            this.Notes.Add(new InstrumentNote()
            {
                NoteName = "A",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 4),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 1)
            });
            this.Notes.Add(new InstrumentNote()
            {
                NoteName = "A#",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 4),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 2)
            });
            this.Notes.Add(new InstrumentNote()
            {
                NoteName = "Ab",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 4),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 3)
            });
        }
    }
}
