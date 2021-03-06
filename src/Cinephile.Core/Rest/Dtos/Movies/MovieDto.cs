﻿using System;
using System.Collections.Generic;

namespace Cinephile.Core.Rest.Dtos.Movies
{
    public class MovieDto
    {
        public int Page { get; set; }
        public IList<MovieResult> Results { get; set; }
        public MovieDates Dates { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
}
