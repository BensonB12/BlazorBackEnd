using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Data.DbModel;

public partial class FloorPadlock
{
    public int Id { get; set; }

    public int FloorId { get; set; }

    public int PadlockId { get; set; }

    public virtual Floor Floor { get; set; } = null!;

    public virtual ICollection<GamerLog> GamerLogs { get; set; } = new List<GamerLog>();
    public virtual ICollection<Outcome> Outcomes { get; set; } = new List<Outcome>();

    public virtual Padlock Padlock { get; set; } = null!;
}
