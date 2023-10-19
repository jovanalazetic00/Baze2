using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Oprema1
{
    public int IdOp1 { get; set; }

    public string? VelOp1 { get; set; }

    public string? VrstOp1 { get; set; }

    public int IdProiz1 { get; set; }

    public virtual ProizvodjacOpreme1 IdProiz1Navigation { get; set; } = null!;
}
