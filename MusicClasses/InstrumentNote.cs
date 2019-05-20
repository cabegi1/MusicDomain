using System;
using System.Collections.Generic;
using System.Text;

namespace Music
{
    internal class InstrumentNote
    {
        internal string NoteName { get; set; }
        internal InstrumentString InstrumentString { get; set; }
        internal InstrumentFret InstrumentFret { get; set; }
    }
}
