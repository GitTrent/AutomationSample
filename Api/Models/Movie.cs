﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public IList<Person> CastAndCrew { get; set; }
    }
}