using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class Requiredfloor
{
    public int Id { get; set; }

    public int ChosenfloorId { get; set; }

    public int RequiredfloorId { get; set; }

    public virtual Floor Chosenfloor { get; set; } = null!;

    public virtual Floor RequiredfloorNavigation { get; set; } = null!;
}
