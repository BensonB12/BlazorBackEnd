using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class GamerLog
{
    public int Id { get; set; }

    public int? FloorPadlockId { get; set; }

    public int? GamerId { get; set; }

    public virtual FloorPadlock? FloorPadlock { get; set; }

    public virtual Gamer? Gamer { get; set; }
}
