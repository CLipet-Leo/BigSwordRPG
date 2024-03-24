using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSwordRPG_C_
{
    public class Music
    {
        private string test;
        private int NoteDo;
        private int NoteRe;
        private int NoteMi;
        private int NoteFa;
        private int NoteSol;
        private int NoteLa;
        private int NoteSi;
        List<string> partition;

        public Music()
        {
            NoteDo = 261;
            NoteRe = 293;
            NoteMi = 329;
            NoteFa = 349;
            NoteSol = 392;
            NoteLa = 440;
            NoteSi = 493;

            partition = new List<string>
        {
            "Do", "Fa", "Sol", "Do",
            "Do", "Fa", "Sol", "Do",
            "Ré", "Sol", "La", "Ré",
            "Ré", "Sol", "La", "Ré"
        };

        }

        public void PlayBeepSelectMenu()
        {
            Console.Beep(NoteLa, 100);
        }

        public void PlayEnterMenu()
        {
            Console.Beep(NoteDo, 100);
        }

        public void PlayMusic()
        {
            for (int i = 0; i < partition[i].Length; i++)
            {
                switch (partition[i])
                {
                    case "Do":
                        Console.Beep(NoteDo, 1500);
                        break;
                    case "Fa":
                        Console.Beep(NoteFa, 1500);
                        break;
                    case "Sol":
                        Console.Beep(NoteSol, 1500);
                        break;
                    case "La":
                        Console.Beep(NoteLa, 1500);
                        break;
                    case "Si":
                        Console.Beep(NoteSi, 1500);
                        break;
                    case "Re":
                        Console.Beep(NoteRe, 1500);
                        break;
                    case "Mi":
                        Console.Beep(NoteMi, 1500);
                        break;
                }
            }
        }
    }
}
