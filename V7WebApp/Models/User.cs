using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace V7WebApp.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }

        [JsonPropertyName("date started")]
        public DateTime DateStarted { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public string NativeLanguage { get; set; }
        public int Level { get; set; }


        public override string ToString()
        {
            return JsonSerializer.Serialize<User>(this);
        }
    }
}