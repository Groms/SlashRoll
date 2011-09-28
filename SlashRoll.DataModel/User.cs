using System;
using System.Collections.Generic;

namespace SlashRoll.DataModel
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public virtual IEnumerable<Roll> Rolls { get; set; }
    }
}