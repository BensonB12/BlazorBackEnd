using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Padlock
{
    public int Id { get; set; }

    public int? DisplayId { get; set; }

    public int? PassId { get; set; }

    public virtual Display? Display { get; set; }

    public virtual ICollection<FloorPadlock> FloorPadlocks { get; set; } = new List<FloorPadlock>();

    public virtual Passkey? Pass { get; set; }
}
