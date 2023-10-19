using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class ZaStazu1
{
    public int IdSud2 { get; set; }

    public virtual Sudija3 IdSud2Navigation { get; set; } = null!;
}
