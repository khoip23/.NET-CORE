using System;
using System.Text.Json.Serialization;

namespace blazor_web_server.Models;

public class ProductModel
{
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("price")]
    public double price { get; set; }

    [JsonPropertyName("img")]
    public Uri img { get; set; }

}
