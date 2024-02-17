using System.Text.Json.Serialization;

namespace SuperAPI.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Cosmic = 1,
        Mutant = 2,
        Mystic = 3,
        Science = 4,
        Skill = 5,
        Tech = 6
    }
}