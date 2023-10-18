using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class RequiredFloor
{
    public int Id { get; set; }

    public int ChosenFloorId { get; set; }

    public int RequiredFloorId { get; set; }

    public virtual Floor ChosenFloor { get; set; } = null!;

    public virtual Floor RequiredFloorNavigation { get; set; } = null!;
}
