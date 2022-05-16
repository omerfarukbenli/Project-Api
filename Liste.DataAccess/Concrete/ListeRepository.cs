using Liste.DataAccess.Abstract;
using Liste.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste.DataAccess.Concrete
{
    public class ListeRepository : IListeRepository
    {
        public SinifListesi CreateSinif(SinifListesi sinifListesi)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                listeDbContext.SinifListesis.Add(sinifListesi);
                listeDbContext.SaveChanges();
                return sinifListesi;
            }
        }

        public void DeleteHotel(int id)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                var deletedListe = GetSinifById(id);
                listeDbContext.SinifListesis.Remove(deletedListe);
                listeDbContext.SaveChanges();
            }
        }

        public List<SinifListesi> GetAllSinif()
        {
            using (var listeDbContext = new ListeDbContext())
            {
                return listeDbContext.SinifListesis.ToList();
            }
        }

        public SinifListesi GetSinifById(int id)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                return listeDbContext.SinifListesis.Find(id);
            }
        }

        public SinifListesi UpdateSinif(SinifListesi sinifListesi)
        {
            using (var listeDbContext = new ListeDbContext())
            {
                listeDbContext.SinifListesis.Update(sinifListesi);
                listeDbContext.SaveChanges();
                return sinifListesi;
            }
        }
    }
}
