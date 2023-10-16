using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Button
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Proportion { get; set; }

    public int? FontId { get; set; }

    public int? ColorId { get; set; }

    public int? ShapeId { get; set; }

    public virtual Color? Color { get; set; }

    public virtual ICollection<DisplayBtn> DisplayBtns { get; set; } = new List<DisplayBtn>();

    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();

    public virtual Font? Font { get; set; }

    public virtual Shape? Shape { get; set; }
}
