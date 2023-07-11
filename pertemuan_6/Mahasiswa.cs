using System;
namespace pertemuan_6
{
	public class Mahasiswa
	{
        private string _namaDepan;
        private string _namaBelakang;

        public string Nim { get; set; }
        public string NamaDepan
        {
            get
            {
                return _namaDepan;
            }
            set
            {
                _namaDepan = value;
            }
        }

        public string NamaBelakang
        {
            get
            {
                return _namaBelakang;
            }
            set
            {
                _namaBelakang = value;
            }
        }


        public string NamaLengkap
        {
            get
            {
                return _namaDepan + ' ' + _namaBelakang;
            }

        }
    }
} 

