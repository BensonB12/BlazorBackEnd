using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Keypad
{
    public int Id { get; set; }

    [Required]
    public int? DisplayId { get; set; }

    [Required]
    public int? PassId { get; set; }

    public virtual Display Display { get; set; } = null!;

    public virtual ICollection<FloorKeypad> FloorKeypads { get; set; } = new List<FloorKeypad>();

    public virtual Passkey Pass { get; set; } = null!;
}
