using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Licenca1
{
    public int IdLic1 { get; set; }

    public DateTime? DatIzdv1 { get; set; }

    public DateTime? DatIstk1 { get; set; }

    public string? NazLic1 { get; set; }

    public int? IdSud2 { get; set; }

    public virtual Sudija3? IdSud2Navigation { get; set; }
}
