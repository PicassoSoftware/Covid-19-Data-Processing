using AutoMapper;
using Covid_19_Data_Processing.DTOs;
using Covid_19_Data_Processing.Models;

namespace Library.Profiles
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            // Source -> Target

            CreateMap <PostHastalikKaydi, HastalikKaydi> ();
            CreateMap <PostCovidKaydi, CovidKaydi> ();
        }
    }
}