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

        [HttpPost("hastalik-semptom")]

        public async Task<ActionResult> AddHastalikSemptom(HastalikSemptom element)
        {
            await _repository.AddHastalikSemptom(element);
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

        public async Task<ActionResult> AddCalismaSaati(PostCalismaSaati posted_element)
        {
            CalismaSaati element = new CalismaSaati();
            element.TC = posted_element.TC;
            element.HaftaninGunleri = posted_element.HaftaninGunleri;
            element.Personel = posted_element.Personel;

            TimeSpan buffer;
            if (TimeSpan.TryParseExact(posted_element.Baslangic, @"hh\:mm", null, out buffer)) element.Baslangic = buffer; else return BadRequest();


            if (TimeSpan.TryParseExact(posted_element.Bitis, @"hh\:mm", null, out buffer)) element.Bitis = buffer; else return BadRequest();


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

        [HttpPost("hobi")]

        public async Task<ActionResult> AddHobi(Hobi element)
        {
            await _repository.AddHobi(element);
            return NoContent();
        }




























        [HttpDelete("personel/{tc}")]

        public async Task<ActionResult> DeletePersonel(string tc)
        {
            await _repository.DeletePersonel(tc);
            return NoContent();
        }

        [HttpDelete("hastalik-semptom/{semptom}/{hastalik_id}")]

        public async Task<ActionResult> DeleteHastalikSemptom(string semptom, int hastalik_id)
        {
            await _repository.DeleteHastalikSemptom(semptom, hastalik_id); ;
            return NoContent();
        }

        [HttpDelete("hobi/{tc}/{hobi_ismi}")]

        public async Task<ActionResult> DeleteHobi(string tc, string hobi_ismi)
        {
            await _repository.DeleteHobi(tc, hobi_ismi);
            return NoContent();
        }

        [HttpDelete("temasli/{temasli_tc}/{covid_id}")]

        public async Task<ActionResult> DeleteTemasli(string temasli_tc, int covid_id)
        {
            await _repository.DeleteTemasli(temasli_tc, covid_id);
            return NoContent();
        }

        [HttpDelete("kronik/{covid_id}/{hastalik}")]

        public async Task<ActionResult> DeleteKronik(int covid_id, string hastalik)
        {
            await _repository.DeleteKronik(covid_id, hastalik);
            return NoContent();
        }

        [HttpDelete("covid-semptom/{covid_id}/{semptom}")]

        public async Task<ActionResult> DeleteCovidSemptom(int covid_id, string semptom)
        {
            await _repository.DeleteCovidSemptom(covid_id, semptom);
            return NoContent();
        }

        [HttpDelete("calisma-saati/{tc}/{haftanin_gunleri}/{baslangic_str}")]

        public async Task<ActionResult> DeleteCalismaSaati(string tc, int haftanin_gunleri, string baslangic_str)
        {
            TimeSpan baslangic;
            if (TimeSpan.TryParseExact(baslangic_str, @"hh\:mm", null, out baslangic))
                Console.WriteLine(baslangic.ToString("c"));
            await _repository.DeleteCalismaSaati(tc, haftanin_gunleri, baslangic);
            return NoContent();
        }

        [HttpDelete("hastalik-kaydi")]

        public async Task<ActionResult> DeleteHastalikKaydi(int id)
        {
            await _repository.DeleteHastalikKaydi(id);
            return NoContent();
        }

        [HttpDelete("recete/{hastalik_id}/{ilac}")]

        public async Task<ActionResult> DeleteRecete(int hastalik_id, string ilac)
        {
            await _repository.DeleteRecete(hastalik_id, ilac);
            return NoContent();
        }

        [HttpDelete("asi/{tc}/{asi_olma_tarihi}")]

        public async Task<ActionResult> DeleteAsi(string tc, DateTime asi_olma_tarihi)
        {
            await _repository.DeleteAsi(tc, asi_olma_tarihi);
            return NoContent();
        }

        [HttpDelete("covid-kaydi/{tc}/{baslangic_tarihi}")]

        public async Task<ActionResult> DeleteCovidKaydi(string tc, DateTime baslangic_tarihi)
        {
            await _repository.DeleteCovidKaydi(tc, baslangic_tarihi);
            return NoContent();
        }





























        [HttpPut("personel/{tc}")]

        public async Task<ActionResult> UpdatePersonel(string tc, Personel element)
        {
            await _repository.UpdatePersonel(tc, element);
            return NoContent();
        }

        [HttpPut("hastalik-semptom/{semptom}/{hastalik_id}")]

        public async Task<ActionResult> UpdateHastalikSemptom(string semptom, int hastalik_id, HastalikSemptom element)
        {
            await _repository.UpdateHastalikSemptom(semptom, hastalik_id, element); ;
            return NoContent();
        }

        [HttpPut("hobi/{tc}/{hobi_ismi}")]

        public async Task<ActionResult> UpdateHobi(string tc, string hobi_ismi, Hobi element)
        {
            await _repository.UpdateHobi(tc, hobi_ismi, element);
            return NoContent();
        }

        [HttpPut("temasli/{temasli_tc}/{covid_id}")]

        public async Task<ActionResult> UpdateTemasli(string temasli_tc, int covid_id, Temasli element)
        {
            await _repository.UpdateTemasli(temasli_tc, covid_id, element);
            return NoContent();
        }

        [HttpPut("kronik/{covid_id}/{hastalik}")]

        public async Task<ActionResult> UpdateKronik(int covid_id, string hastalik, Kronik elemenet)
        {
            await _repository.UpdateKronik(covid_id, hastalik, elemenet);
            return NoContent();
        }

        [HttpPut("covid-semptom/{covid_id}/{semptom}")]

        public async Task<ActionResult> UpdateCovidSemptom(int covid_id, string semptom, CovidSemptom element)
        {
            await _repository.UpdateCovidSemptom(covid_id, semptom, element);
            return NoContent();
        }

        [HttpPut("calisma-saati/{tc}/{haftanin_gunleri}/{baslangic_str}")]

        public async Task<ActionResult> UpdateCalismaSaati(string tc, int haftanin_gunleri, string baslangic_str, PostCalismaSaati posted_element)
        {
            TimeSpan buffer, baslangic = new TimeSpan();
            if (TimeSpan.TryParseExact(baslangic_str, @"hh\:mm", null, out buffer))
                baslangic = buffer;

            CalismaSaati element = new CalismaSaati();
            element.TC = posted_element.TC;
            element.HaftaninGunleri = posted_element.HaftaninGunleri;
            element.Personel = posted_element.Personel;

            if (posted_element.Baslangic.Length == 0) element.Baslangic = new TimeSpan(1,1,1); 
            else if (TimeSpan.TryParseExact(posted_element.Baslangic, @"hh\:mm", null, out buffer)) element.Baslangic = buffer; 
            else return BadRequest();

            if (posted_element.Bitis.Length == 0) element.Bitis = new TimeSpan(1,1,1); 
            else if (TimeSpan.TryParseExact(posted_element.Bitis, @"hh\:mm", null, out buffer)) element.Bitis = buffer; 
            else return BadRequest();

            await _repository.UpdateCalismaSaati(tc, haftanin_gunleri, baslangic, element);
            return NoContent();
        }

        [HttpPut("hastalik-kaydi")]

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

        public async Task<ActionResult> UpdateAsi(string tc, DateTime asi_olma_tarihi, Asi element)
        {
            await _repository.UpdateAsi(tc, asi_olma_tarihi, element);
            return NoContent();
        }

        [HttpPut("covid-kaydi/{id}")]

        public async Task<ActionResult> UpdateCovidKaydi(int id, CovidKaydi element)
        {
            await _repository.UpdateCovidKaydi(id, element);
            return NoContent();
        }




































        [HttpGet("egitim-covid-istatistik")]

        public ActionResult EgitimCovidIstatistikBilgisi()
        {
            return Ok(_repository.EgitimCovidIstatistikBilgisi());
        }

        [HttpGet("en-yaygin-hastalik-bilgisi")]

        public ActionResult EnYayginHastalikBilgisi()
        {
            return Ok(_repository.EnYayginHastalikBilgisi());
        }


        [HttpGet("sehir-hastalik-bilgisi/{sehir}")]

        public ActionResult SehirHastalikBilgisi(string sehir)
        {
            return Ok(_repository.SehirHastalikBilgisi(sehir));
        }

        [HttpGet("yaygin-ilac-covid-bilgisi")]

        public ActionResult YayginIlacCovidBilgisi()
        {
            return Ok(_repository.YayginIlacCovidBilgisi());
        }

        [HttpGet("ilaca-gore-covid/{ilac}")]

        public ActionResult IlacaGoreCovid(string ilac)
        {
            return Ok(_repository.IlacaGoreCovid(ilac));
        }

        [HttpGet("biontech-ve-hastalik-covid-bilgisi/{hastalik}")]

        public ActionResult BiontechVeHastalikCovidBilgisi(string hastalik)
        {
            return Ok(_repository.BiontechVeHastalikCovidBilgisi(hastalik));
        }








        [HttpGet("asiya-gore-covid-bilgisi")]

        public ActionResult AsiyaGoreCovidBilgisi()
        {
            return Ok(_repository.AsiyaGoreCovidBilgisi());
        }

        [HttpGet("kan-grubu-covid-bilgisi")]

        public ActionResult KanGrubuCovidBilgisi()
        {
            return Ok(_repository.KanGrubuCovidBilgisi());
        }

        [HttpGet("temas-bagimlilari")]

        public ActionResult TemasBagimlilari()
        {
            return Ok(_repository.TemasBagimlilari());
        }

        [HttpGet("kronik-covid-suresi-bilgisi/{kronik}")]

        public ActionResult KronikCovidSuresiBilgisi(string kronik)
        {
            return Ok(_repository.KronikCovidSuresiBilgisi(kronik));
        }

        [HttpGet("asi-etkinlik-bilgisi")]

        public ActionResult AsiEtkinlikBilgisi()
        {
            return Ok(_repository.AsiEtkinlikBilgisi());
        }


        [HttpGet("asisiz-en-uzun-covid-bilgisi")]

        public ActionResult AsisizEnUzunCovidBilgisi()
        {
            return Ok(_repository.AsisizEnUzunCovidBilgisi());
        }

        [HttpGet("covid-istatistik-bilgisi")]

        public ActionResult CovidIstatistikBilgisi()
        {
            return Ok(_repository.CovidIstatistikBilgisi());
        }

        [HttpGet("covid-belirtileri")]

        public ActionResult CovidBelirtileri()
        {
            return Ok(_repository.CovidBelirtileri());
        }




        [HttpGet("haftasonu-covid-bilgisi")]

        public ActionResult HaftasonuCovidBilgisi()
        {
            return Ok(_repository.HaftasonuCovidBilgisi());
        }

        [HttpGet("hastalananlarin-covid-bilgisi")]

        public ActionResult HastalananlarinCovidBilgisi()
        {
            return Ok(_repository.HastalananlarinCovidBilgisi());
        }



    }
}