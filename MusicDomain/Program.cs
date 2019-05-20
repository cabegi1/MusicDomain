using Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicDomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate a guitar
            Guitar guitar = new Guitar();

            //Instantiate a bass
            Bass bass = new Bass();

            //Play A# on guitar
            guitar.Play("A#");

            //Play A# on bass
            bass.Play("A#");

            Console.ReadKey();
        }
    }
}
