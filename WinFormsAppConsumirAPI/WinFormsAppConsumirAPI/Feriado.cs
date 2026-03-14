using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WinFormsAppConsumirAPI
{
    public class Feriado
    {
        [JsonPropertyName("date")]
        public DateTime Date {  get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

    }

    public class CEP
    {
        [JsonPropertyName("cep")]
        public string cep {  get; set; }

        [JsonPropertyName("state")]
        public string state { get; set; }

        [JsonPropertyName("city")]
        public string city { get; set; }

        [JsonPropertyName("neighborhood")]
        public string neighborhood { get; set; }

        [JsonPropertyName("street")]
        public string street { get; set; }

        [JsonPropertyName("service")]
        public string service { get; set; }
    }
}
