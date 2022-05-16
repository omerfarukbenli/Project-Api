using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.DataAccess.Abstract
{
    public interface IListeRepository
    {
        List<SinifListesi> GetAllSinif();

        SinifListesi GetSinifById(int id);

        SinifListesi CreateSinif(SinifListesi sinifListesi);

        SinifListesi UpdateSinif(SinifListesi sinifListesi);

        void DeleteHotel(int id);
    }
}
