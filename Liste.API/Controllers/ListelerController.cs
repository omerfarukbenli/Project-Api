using Liste.Business.Abstract;
using Liste.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Liste.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListelerController : ControllerBase
    {
        private IListeService _listeService;
        public ListelerController(IListeService listeService)
        {
            _listeService = listeService;
        }
        [HttpGet]
        public List<SinifListesi> Get()
        {
            return _listeService.GetAllSinif();
        }
        [HttpGet("{id}")] 
        public SinifListesi Get(int id)
        {
            return _listeService.GetSinifById(id);
        }
        [HttpPost] // ekleme
        public SinifListesi Post([FromBody] SinifListesi sinifListesi)
        {
            return _listeService.CreateSinif(sinifListesi);
        }
        [HttpPut] //güncelleme
        public SinifListesi Put([FromBody] SinifListesi sinifListesi)
        {
            return _listeService.UpdateSinif(sinifListesi);
        }
        [HttpDelete("{id}")] //silme
        public void Delete(int id)
        {
            _listeService.DeleteHotel(id);
        }
    }
}
