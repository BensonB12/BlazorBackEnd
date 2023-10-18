using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class FloorKeypad
{
    public int Id { get; set; }

    public int FloorId { get; set; }

    public int KeypadId { get; set; }

    public virtual Floor Floor { get; set; } = null!;

    public virtual ICollection<GamerLog> GamerLogs { get; set; } = new List<GamerLog>();

    public virtual Keypad Keypad { get; set; } = null!;

    public virtual ICollection<Outcome> Outcomes { get; set; } = new List<Outcome>();
}
