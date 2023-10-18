using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Button
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int Proportion { get; set; }

    public int FontId { get; set; }

    public int ColorId { get; set; }

    public int ShapeId { get; set; }

    public virtual Color Color { get; set; } = null!;

    public virtual ICollection<DisplayBtn> DisplayBtns { get; set; } = new List<DisplayBtn>();

    public virtual Font Font { get; set; } = null!;

    public virtual Shape Shape { get; set; } = null!;
}
