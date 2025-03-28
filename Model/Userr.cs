// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using MauiApp2.Model;
//
//    var userr = Userr.FromJson(jsonString);

namespace MauiApp2.Model
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Userr
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("current_term_registration")]
        public List<CurrentTermRegistration> CurrentTermRegistration { get; set; }

        [JsonProperty("previous_terms_registration")]
        public List<PreviousTermsRegistration> PreviousTermsRegistration { get; set; }
    }

    public partial class CurrentTermRegistration
    {
        [JsonProperty("course_id")]
        public string CourseId { get; set; }

        [JsonProperty("course_name")]
        public string CourseName { get; set; }

        [JsonProperty("credit")]
        public long Credit { get; set; }

        [JsonProperty("grade")]
        public string Grade { get; set; }
        public bool IsSelected { get; set; } = false; // สถานะการเลือกวิชา

    }

    public partial class PreviousTermsRegistration
    {
        [JsonProperty("term")]
        public string Term { get; set; }

        [JsonProperty("courses")]
        public List<CurrentTermRegistration> Courses { get; set; }
    }

    public partial class Profile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }
    }

    public partial class Userr
    {
        public static List<Userr> FromJson(string json) => JsonConvert.DeserializeObject<List<Userr>>(json, MauiApp2.Model.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<Userr> self) => JsonConvert.SerializeObject(self, MauiApp2.Model.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
