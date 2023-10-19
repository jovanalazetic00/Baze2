using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class ProizvodjacOpreme1
{
    public int IdProiz1 { get; set; }

    public string? NazProiz1 { get; set; }

    public virtual ICollection<Oprema1> Oprema1s { get; set; } = new List<Oprema1>();
}
