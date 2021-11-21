using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Domain.Entities
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
