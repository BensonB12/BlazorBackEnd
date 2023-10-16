﻿using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Gamer
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateOnly Startdate { get; set; }

    public virtual ICollection<GamerLog> GamerLogs { get; set; } = new List<GamerLog>();
}
