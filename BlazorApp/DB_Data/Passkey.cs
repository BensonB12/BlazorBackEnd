using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Passkey
{
    public int Id { get; set; }

    public string Keystring { get; set; } = null!;

    public virtual ICollection<Padlock> Padlocks { get; set; } = new List<Padlock>();
}
