using Liste.Business.Abstract;
using Liste.DataAccess.Abstract;
using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.Business.Concrete
{
    public class ListeManager : IListeService
    {
        private IListeRepository _listeRepository;
        public ListeManager(IListeRepository listeRepository)
        {
            _listeRepository = listeRepository;
        }
        public SinifListesi CreateSinif(SinifListesi sinifListesi)
        {
            return _listeRepository.CreateSinif(sinifListesi);
        }

        public void DeleteHotel(int id)
        {
            _listeRepository.DeleteHotel(id);
        }

        public List<SinifListesi> GetAllSinif()
        {
            return _listeRepository.GetAllSinif();
        }

        public SinifListesi GetSinifById(int id)
        {
            if (id > 0)
            {
                return _listeRepository.GetSinifById(id);
            }
            throw new Exception("id i den küçük olamaz");
        }

        public SinifListesi UpdateSinif(SinifListesi sinifListesi)
        {
           return _listeRepository.UpdateSinif(sinifListesi);
        }
    }
}
