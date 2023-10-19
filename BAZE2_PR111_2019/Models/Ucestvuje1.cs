using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Ucestvuje1
{
    public int IdSk1 { get; set; }

    public int IdTrk1 { get; set; }

    public int IdSud2 { get; set; }

    public virtual Skijas1 IdSk1Navigation { get; set; } = null!;

    public virtual ZaTakmicare1 IdSud2Navigation { get; set; } = null!;

    public virtual Trka1 IdTrk1Navigation { get; set; } = null!;
}
