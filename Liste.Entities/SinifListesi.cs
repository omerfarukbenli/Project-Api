using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.Entities
{
    public class SinifListesi
    {

        public int Id { get; set; }


        public string Ad { get; set; }


        public string Soyad { get; set; }

        public int Yas { get; set; }


        public string Okulu { get; set; }


        public string Alani { get; set; }

    }
}
