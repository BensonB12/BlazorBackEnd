using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class GamerLog
{
    public int Id { get; set; }

    public int FloorKeypadId { get; set; }

    public int GamerId { get; set; }

    public virtual FloorKeypad FloorKeypad { get; set; } = null!;

    public virtual Gamer Gamer { get; set; } = null!;
}
