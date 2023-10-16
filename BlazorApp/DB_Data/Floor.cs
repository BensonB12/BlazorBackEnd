using System;
using System.Collections.Generic;

namespace BlazorApp.DB_Data;

public partial class Floor
{
    public int Id { get; set; }

    public virtual ICollection<FloorPadlock> FloorPadlocks { get; set; } = new List<FloorPadlock>();

    public virtual ICollection<RequiredFloor> RequiredFloorChosenFloors { get; set; } = new List<RequiredFloor>();

    public virtual ICollection<RequiredFloor> RequiredFloorRequiredFloorNavigations { get; set; } = new List<RequiredFloor>();
}
