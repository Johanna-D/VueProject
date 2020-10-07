﻿using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AlloCine
{
    [DataContract]
    public class Tag
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("$")]
        public string Value { get; set; }
    }
}
