using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LAB5.Models;

public partial class Monan
{
    [Key]
    public string Mama { get; set; }

    public string? Tenma { get; set; }

    public decimal? Dongia { get; set; }

    public string? Loaima { get; set; }

}
