using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Outcome
{
    public int Id { get; set; }

    public int FloorKeypadId { get; set; }

    public int FloorId { get; set; }

    public virtual Floor Floor { get; set; } = null!;

    public virtual FloorKeypad FloorKeypad { get; set; } = null!;
}
