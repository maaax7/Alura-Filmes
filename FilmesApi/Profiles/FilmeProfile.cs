using System;
using AutoMapper;
using FilmesApi.Data.DTOs;
using FilmesApi.Models;

namespace FilmesApi.Profiles;

public class FilmeProfile : Profile
{
	public FilmeProfile()
	{
		CreateMap<CreateFilmeDTO, Filme>();
		CreateMap<UpdateFilmeDTO, Filme>();
		CreateMap<Filme, UpdateFilmeDTO>();
		CreateMap<Filme, ReadFilmeDTO>();
	}
}

