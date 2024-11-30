using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CseHelp.Models.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public string Motive { get; set; }
        public string WrittingMotivation { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}
