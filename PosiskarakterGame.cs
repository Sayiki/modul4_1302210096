using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210096
{
    internal class PosiskarakterGame
    {
        public enum posisi
        {
            Berdiri,
            Tengkurap,
            jongkok,
            Terbang
        }

        public enum tombol
        {
            TombolW,
            TombolS,
            TombolX
        }

        public class gantiPosisi
        {
            public posisi posisisebelum, posisisesudah;
            public tombol trigger;

            public gantiPosisi(posisi sebelum, posisi sesudah, tombol trigger)
            {
                this.posisisebelum = sebelum;
                this.posisisesudah = sesudah;
                this.trigger = trigger;
            }
            gantiPosisi[] arrgantiposisi =
            {
                new gantiPosisi(posisi.jongkok, posisi.Berdiri, tombol.TombolW),
                new gantiPosisi(posisi.Berdiri, posisi.Terbang, tombol.TombolW),
                new gantiPosisi(posisi.Terbang, posisi.jongkok, tombol.TombolX),
                new gantiPosisi(posisi.Terbang, posisi.Berdiri, tombol.TombolS),
                new gantiPosisi(posisi.Berdiri, posisi.jongkok, tombol.TombolS),
                new gantiPosisi(posisi.jongkok, posisi.Tengkurap, tombol.TombolS),
                new gantiPosisi(posisi.Tengkurap, posisi.jongkok, tombol.TombolW)
            };

        }




    }
}
