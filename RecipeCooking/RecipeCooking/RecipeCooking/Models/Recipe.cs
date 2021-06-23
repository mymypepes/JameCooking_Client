using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeCooking.Models
{
    public class Recipe
    {
        public int IdRec { get; set; }
        public int? IdCon { get; set; }
        public int? IdType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public bool? Fof { get; set; }
        public DateTime CreateDate { get; set; }
        public byte Status { get; set; }

    }
}
