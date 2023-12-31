using AutoMapper;
using Microsoft.AspNetCore.Identity;
using pokemonreview.Dto;
using pokemonreview.Models;

namespace pokemonreview.Helper
{
    public class MatchingProfiles : Profile
    {
        public MatchingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();  
            CreateMap<PokemonDto, Pokemon>();  
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Country, CountryDto>();
            CreateMap<CountryDto, Country>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<OwnerDto, Owner>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<ReviewerDto, Reviewer>();
        }


    }
}