using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    public class Guitar : Instrument
    {
        public Guitar()
        {   
            InitializeGuitar();
        }
        
        private void InitializeGuitar()
        {
            //Set Name
            this.Name = "Guitar";
            //Initialize 6 Strings
            InitializeStrings();
            //Initialize 2 Frets
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
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 5 });
            this.InstrumentStrings.Add(new InstrumentString() { StringNumber = 6 });
        }

        private void InitializeFrets()
        {
            this.InstrumentFret.Add(new InstrumentFret() { fretBoardNumer=1});
            this.InstrumentFret.Add(new InstrumentFret() { fretBoardNumer = 2 });
        }


        private void InitializeNotes()
        {
            this.Notes.Add(new InstrumentNote() { NoteName = "A",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 1),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 1) });
            this.Notes.Add(new InstrumentNote()
            {
                NoteName = "A#",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 1),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 2)
            });
            this.Notes.Add(new InstrumentNote()
            {
                NoteName = "Ab",
                InstrumentString = this.InstrumentStrings.Find(x => x.StringNumber == 1),
                InstrumentFret = this.InstrumentFret.Find(x => x.fretBoardNumer == 3)
            });
        }
    }
}
