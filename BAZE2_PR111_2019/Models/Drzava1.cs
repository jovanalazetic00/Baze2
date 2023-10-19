using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Drzava1
{
    public int IdDrz1 { get; set; }

    public string? NazDrz1 { get; set; }

    public virtual ICollection<Skijas1> Skijas1s { get; set; } = new List<Skijas1>();

    public virtual ICollection<Trka1> Trka1s { get; set; } = new List<Trka1>();
}
