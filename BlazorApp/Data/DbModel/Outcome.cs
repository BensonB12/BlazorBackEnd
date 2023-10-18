using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data.DbModel
{
    public partial class Outcome
    {
        public int Id { get; set; }

        public int? FloorPadlockId { get; set; }

        public int? FloorId { get; set; }

        public virtual FloorPadlock? FloorPadlock { get; set; }
        public virtual Floor? Floor { get; set; }
    }
}
