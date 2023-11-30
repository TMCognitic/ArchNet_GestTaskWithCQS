using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchNet_GestTask.Models.Entities
{
    public class Tache
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public bool Cloturee { get; set; }
        public int? PersonneId { get; set; }
    }
}
