﻿using System;
using Cinephile.Core.Rest.Dtos.ImageConfigurations;
using Cinephile.Core.Rest.Dtos.Movies;
using Refit;

namespace Cinephile.Core.Rest
{
    [Headers("Content-Type: application/json")]
    public interface IRestApiClient
    {
        [Get("/movie/upcoming?api_key={apiKey}&language={language}&page={page}")]
        IObservable<MovieDto> FetchUpcomingMovies(string apiKey, int page, string language);

        [Get("/configuration?api_key={apiKey}")]
        IObservable<ImageConfigurationDto> FetchImageConfiguration(string apiKey);

        [Get("/genre/movie/list?api_key={apiKey}&language={language}")]
        IObservable<GenresDto> FetchGenres(string apiKey, string language);
   }
}