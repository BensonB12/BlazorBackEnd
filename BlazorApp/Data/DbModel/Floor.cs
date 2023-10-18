using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Floor
{
    public int Id { get; set; }

    public virtual ICollection<FloorKeypad> FloorKeypads { get; set; } = new List<FloorKeypad>();

    public virtual ICollection<Outcome> Outcomes { get; set; } = new List<Outcome>();

    public virtual ICollection<Requiredfloor> RequiredfloorChosenfloors { get; set; } = new List<Requiredfloor>();

    public virtual ICollection<Requiredfloor> RequiredfloorRequiredfloorNavigations { get; set; } = new List<Requiredfloor>();
}
