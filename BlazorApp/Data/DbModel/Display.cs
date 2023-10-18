using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Display
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? Proportion { get; set; }

    public int? BtnId { get; set; }

    public int? ShapeId { get; set; }

    public int? ColorId { get; set; }

    public int? FontId { get; set; }

    public virtual Button? Btn { get; set; }

    public virtual Color? Color { get; set; }

    public virtual ICollection<DisplayBtn> DisplayBtns { get; set; } = new List<DisplayBtn>();

    public virtual Font? Font { get; set; }

    public virtual ICollection<Padlock> Padlocks { get; set; } = new List<Padlock>();

    public virtual Shape? Shape { get; set; }
}
