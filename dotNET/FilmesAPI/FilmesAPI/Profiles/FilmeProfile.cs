using FilmesApi.Data.Dtos;
using FilmesApi.Models;
using AutoMapper;

namespace FilmesAPI.Profiles;

public class FilmeProfile : Profile
{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
    }
}
