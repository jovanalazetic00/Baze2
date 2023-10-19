using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class ZaTakmicare1
{
    public int IdSud2 { get; set; }

    public virtual Sudija3 IdSud2Navigation { get; set; } = null!;

    public virtual ICollection<Ucestvuje1> Ucestvuje1s { get; set; } = new List<Ucestvuje1>();
}
