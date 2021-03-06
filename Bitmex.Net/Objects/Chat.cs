﻿using Newtonsoft.Json;

namespace    Bitmex.Net.Client.Objects
{


    /// <summary>Trollbox Data</summary>

    public class Chat
    {
        [JsonProperty("id")]
        public decimal? Id { get; set; }

        [JsonProperty("date", Required = Required.Always)]

        public System.DateTime Date { get; set; }

        [JsonProperty("user", Required = Required.Always)]

        public string User { get; set; }

        [JsonProperty("message", Required = Required.Always)]

        public string Message { get; set; }

        [JsonProperty("html", Required = Required.Always)]

        public string Html { get; set; }

        [JsonProperty("fromBot")]
        public bool? FromBot { get; set; } = false;

        [JsonProperty("channelID")]
        public decimal? ChannelID { get; set; }


    }

}

