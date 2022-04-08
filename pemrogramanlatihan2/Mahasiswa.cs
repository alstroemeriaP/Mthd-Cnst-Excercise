using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrogramanlatihan2
{
    public class Mahasiswa
    {
        public Mahasiswa()
        {

        }
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }
        public string Nim { get; set; } = default!;
        public string Nama { get; set; } = default!;
    }
}
