using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class FloorPadlock
{
    public int Id { get; set; }

    public int FloorId { get; set; }

    public int PadlockId { get; set; }

    public virtual Floor Floor { get; set; } = null!;

    public virtual ICollection<GamerLog> GamerLogs { get; set; } = new List<GamerLog>();

    public virtual Padlock Padlock { get; set; } = null!;
}
