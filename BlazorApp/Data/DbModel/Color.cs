using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Color
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? HexValueInt { get; set; }

    public virtual ICollection<Button> Buttons { get; set; } = new List<Button>();

    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
