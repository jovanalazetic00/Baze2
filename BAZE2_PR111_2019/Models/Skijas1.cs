using System;
using System.Collections.Generic;

namespace BAZE2_PR111_2019.Models;

public partial class Skijas1
{
    public int IdSk1 { get; set; }

    public string? ImeSk1 { get; set; }

    public string? PrzSk1 { get; set; }

    public string? RezSk1 { get; set; }

    public string? BrSkiPas1 { get; set; }

    public int? IdDrz1 { get; set; }

    public virtual Drzava1? IdDrz1Navigation { get; set; }

    public virtual ICollection<Ucestvuje1> Ucestvuje1s { get; set; } = new List<Ucestvuje1>();
}
