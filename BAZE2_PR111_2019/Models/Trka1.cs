using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Trka1
{
    public int IdTrk1 { get; set; }

    public string? NazTrke1 { get; set; }

    public string? VrTrk1 { get; set; }

    public DateTime? DatTrk1 { get; set; }

    public string? KatTrk1 { get; set; }

    public int? IdDrz1 { get; set; }

    public virtual Drzava1? IdDrz1Navigation { get; set; }

    public virtual ICollection<Staza1> Staza1s { get; set; } = new List<Staza1>();

    public virtual ICollection<Ucestvuje1> Ucestvuje1s { get; set; } = new List<Ucestvuje1>();
}
