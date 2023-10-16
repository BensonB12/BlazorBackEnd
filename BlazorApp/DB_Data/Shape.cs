﻿using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Shape
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Numsides { get; set; }

    public virtual ICollection<Button> Buttons { get; set; } = new List<Button>();

    public virtual ICollection<Display> Displays { get; set; } = new List<Display>();
}
