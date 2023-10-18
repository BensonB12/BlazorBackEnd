using System;
using System.Collections.Generic;

namespace BlazorApp.Data.DbModel;

public partial class DisplayBtn
{
    public int Id { get; set; }

    public int DisplayId { get; set; }

    public int BtnId { get; set; }

    public virtual Button Btn { get; set; } = null!;

    public virtual Display Display { get; set; } = null!;
}
