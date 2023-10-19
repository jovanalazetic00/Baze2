using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Sudija3
{
    public int IdSud2 { get; set; }

    public string? ImeSud2 { get; set; }

    public string? PrzSud2 { get; set; }

    public string? TipSud2 { get; set; }

    public virtual ICollection<Licenca1> Licenca1s { get; set; } = new List<Licenca1>();

    public virtual ZaStazu1? ZaStazu1 { get; set; }

    public virtual ZaTakmicare1? ZaTakmicare1 { get; set; }
}
