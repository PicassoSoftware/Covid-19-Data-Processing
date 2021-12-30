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


        [HttpPost("calisma-saaatleri")]

        public async Task<ActionResult> AddCalismaSaaatleri(CalismaSaati element)
        {
            await _repository.AddCalismaSaaatleri(element);
            return NoContent();
        }
        
        [HttpPost("personel")]

        public async Task<ActionResult> AddPersonel(Personel element)
        {
            await _repository.AddPersonel(element);
            return NoContent();
        }
        



        [HttpGet("ilaca-gore-covid/{ilac}")]

        public async Task<ActionResult> IlacaGoreCovid(string ilac)
        {
            return Ok(await _repository.IlacaGoreCovid(ilac));
        }

        [HttpPut("personel/{tc}")]

        public async Task<ActionResult> UpdatePersonel(string tc, Personel element)
        {
            await _repository.UpdatePersonel(tc, element);
            return NoContent();
        }

        [HttpPut("calisma-saati/{tc}")]

        public async Task<ActionResult> UpdateCalismaSaati(string tc, CalismaSaati element)
        {
            await _repository.UpdateCalismaSaati(tc, element);
            return NoContent();
        }


        [HttpPut("hastalik-kaydi/{tc}")]

        public async Task<ActionResult> UpdateHastalikKaydi(string tc, HastalikKaydi element)
        {
            await _repository.UpdateHastalikKaydi(tc, element);
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

        public async Task<ActionResult> AsiyaGoreCovidBilgisi()
        {
            return Ok(await _repository.AsiyaGoreCovidBilgisi());
        }

        [HttpGet("kan-grubu-covid-bilgisi")]

        public async Task<ActionResult> KanGrubuCovidBilgisi()
        {
            return Ok(await _repository.KanGrubuCovidBilgisi());
        }

        [HttpGet("temas-bagimlilari")]

        public async Task<ActionResult> TemasBagimlilari()
        {
            return Ok(await _repository.TemasBagimlilari());
        }

        


    }
}