﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Yelp.Api.Model
{
    public class SearchResponse : ResponseBase
    {
        [JsonProperty("region")]
        public Region Region { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("businesses")]
        public IList<Business> Businesses { get; set; }
    }
}