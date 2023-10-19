using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Staza1
{
    public int IdSt1 { get; set; }

    public string? NazSt1 { get; set; }

    public string? DuzinaSt1 { get; set; }

    public int IdTrk1 { get; set; }

    public virtual Trka1 IdTrk1Navigation { get; set; } = null!;
}
