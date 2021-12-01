using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Infrastructure.Data
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Id = long.MinValue;
        }

        [JsonProperty("Id")]
        [ForeignKey("Id")]
        public long Id { get; set; }
    }
}
