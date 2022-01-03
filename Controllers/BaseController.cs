using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Covid_19_Data_Processing.Data;
using Covid_19_Data_Processing.DTOs;
using Covid_19_Data_Processing.Models;
using Microsoft.AspNetCore.Mvc;


namespace Covid_19_Data_Processing.Controllers
{

    [ApiController]
    public class BaseController : ControllerBase
    {
        private readonly IBaseRepo _repository;        //Get Repository

        public BaseController(IBaseRepo repository)
        {
            _repository = repository;
        }


        [HttpPost("asi")]

        public async Task<ActionResult> AddAsi(Asi element)
        {
            await _repository.AddAsi(element);
            return NoContent();
        }

        [HttpPost("temasli")]

        public async Task<ActionResult> AddTemasli(Temasli element)
        {
            await _repository.AddTemasli(element);
            return NoContent();
        }

        [HttpPost("covid-semptom")]

        public async Task<ActionResult> AddCovidSemptom(CovidSemptom element)
        {
            await _repository.AddCovidSemptom(element);
            return NoContent();
        }


        [HttpPost("hastalik-kaydi")]

        public async Task<ActionResult> AddHastalikKaydi(PostHastalikKaydi element)
        {
            await _repository.AddHastalikKaydi(element);
            return NoContent();
        }

        [HttpPost("recete")]

        public async Task<ActionResult> AddRecete(Recete element)
        {
            await _repository.AddRecete(element);
            return NoContent();
        }

        [HttpPost("covid-kaydi")]

        public async Task<ActionResult> AddCovidKaydi(PostCovidKaydi element)
        {
            await _repository.AddCovidKaydi(element);
            return NoContent();
        }


        [HttpPost("calisma-saaati")]

        public async Task<ActionResult> AddCalismaSaati(CalismaSaati element)
        {
            await _repository.AddCalismaSaati(element);
            return NoContent();
        }
        
        [HttpPost("personel")]

        public async Task<ActionResult> AddPersonel(Personel element)
        {
            await _repository.AddPersonel(element);
            return NoContent();
        }

        [HttpPost("kronik")]

        public async Task<ActionResult> AddKronik(Kronik element)
        {
            await _repository.AddKronik(element);
            return NoContent();
        }
        



        [HttpGet("ilaca-gore-covid/{ilac}")]

        public ActionResult IlacaGoreCovid(string ilac)
        {
            return Ok( _repository.IlacaGoreCovid(ilac));
        }

        [HttpPut("personel/{tc}")]

        public async Task<ActionResult> UpdatePersonel(string tc, Personel element)
        {
            await _repository.UpdatePersonel(tc, element);
            return NoContent();
        }

        [HttpPut("calisma-saati/{tc}")]

        public async Task<ActionResult> UpdateCalismaSaati(string tc, int haftanin_gunleri, TimeSpan baslangic, CalismaSaati element)
        {
            await _repository.UpdateCalismaSaati(tc, haftanin_gunleri, baslangic, element);
            return NoContent();
        }


        [HttpPut("hastalik-kaydi/{id}")]

        public async Task<ActionResult> UpdateHastalikKaydi(int id, HastalikKaydi element)
        {
            await _repository.UpdateHastalikKaydi(id, element);
            return NoContent();
        }

        [HttpPut("recete/{hastalik_id}/{ilac}")]

        public async Task<ActionResult> UpdateRecete(int hastalik_id, string ilac, Recete element)
        {
            await _repository.UpdateRecete(hastalik_id, ilac, element);
            return NoContent();
        }

        [HttpPut("asi/{tc}/{asi_olma_tarihi}")]

        public async Task<ActionResult> UpdateAsi(string tc, string asi_olma_tarihi, Asi element)
        {
            DateTime oDate = Convert.ToDateTime(asi_olma_tarihi);

            await _repository.UpdateAsi(tc, oDate, element);
            return NoContent();
        }

        [HttpPut("covid-kaydi/{tc}/{baslangic_tarihi}")]

        public async Task<ActionResult> UpdateCovidKaydi(string tc, DateTime baslangic_tarihi, CovidKaydi element)
        {
            await _repository.UpdateCovidKaydi(tc, baslangic_tarihi, element);
            return NoContent();
        }


        [HttpGet("asiya-gore-covid-bilgisi")]

        public ActionResult AsiyaGoreCovidBilgisi()
        {
            return Ok(_repository.AsiyaGoreCovidBilgisi());
        }

        [HttpGet("kan-grubu-covid-bilgisi")]

        public ActionResult KanGrubuCovidBilgisi()
        {
            return Ok( _repository.KanGrubuCovidBilgisi());
        }

        [HttpGet("temas-bagimlilari")]

        public ActionResult TemasBagimlilari()
        {
            return Ok( _repository.TemasBagimlilari());
        }

        [HttpGet("kronik-covid-suresi-bilgisi/{kronik}")]

        public ActionResult KronikCovidSuresiBilgisi(string kronik)
        {
            return Ok( _repository.KronikCovidSuresiBilgisi(kronik));
        }

        [HttpGet("biontech-ve-hastalik-covid-bilgisi/{hastalik}")]

        public ActionResult BiontechVeHastalikCovidBilgisi(string hastalik)
        {
            return Ok( _repository.BiontechVeHastalikCovidBilgisi(hastalik));
        }
        [HttpGet("asi-etkinlik-bilgisi")]

        public ActionResult AsiEtkinlikBilgisi()
        {
            return Ok( _repository.AsiEtkinlikBilgisi());
        }
        [HttpGet("egitim-covid-istatistik")]

        public ActionResult EgitimCovidIstatistikBilgisi()
        {
            return Ok( _repository.EgitimCovidIstatistikBilgisi());
        }

        [HttpGet("asisiz-en-uzun-covid-bilgisi")]

        public ActionResult AsisizEnUzunCovidBilgisi()
        {
            return Ok( _repository.AsisizEnUzunCovidBilgisi());
        }

        [HttpGet("covid-istatistik-bilgisi")]

        public ActionResult CovidIstatistikBilgisi()
        {
            return Ok( _repository.CovidIstatistikBilgisi());
        }

        [HttpGet("covid-belirtileri")]

        public ActionResult CovidBelirtileri()
        {
            return Ok( _repository.CovidBelirtileri());
        }

        [HttpGet("sehir-hastalik-bilgisi/{sehir}")]

        public ActionResult SehirHastalikBilgisi(string sehir)
        {
            return Ok( _repository.SehirHastalikBilgisi(sehir));
        }

        [HttpGet("en-yaygin-hastalik-bilgisi")]

        public ActionResult EnYayginHastalikBilgisi()
        {
            return Ok( _repository.EnYayginHastalikBilgisi());
        }

        [HttpGet("haftasonu-covid-bilgisi")]

        public ActionResult HaftasonuCovidBilgisi()
        {
            return Ok( _repository.HaftasonuCovidBilgisi());
        }

        [HttpGet("hastalananlarin-covid-bilgisi")]

        public ActionResult HastalananlarinCovidBilgisi()
        {
            return Ok( _repository.HastalananlarinCovidBilgisi());
        }

        [HttpGet("yaygin-ilac-covid-bilgisi")]

        public ActionResult YayginIlacCovidBilgisi()
        {
            return Ok( _repository.YayginIlacCovidBilgisi());
        }


    }
}