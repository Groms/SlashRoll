using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SlashRoll.DataModel
{
    public class Roll
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public int Result { get; set; }
    }
}
