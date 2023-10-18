using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Passkey
{
    public int Id { get; set; }

    public string Keystring { get; set; } = null!;

    public virtual ICollection<Keypad> Keypads { get; set; } = new List<Keypad>();
}
