using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.Id = long.MinValue;
        }

        [JsonProperty("Id")]
        public long Id { get; set; }
    }
}
