using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAB5.Models;

public partial class Cthd
{
    [Key]
    public string Mahd { get; set; }

    [ForeignKey("Monan")]
    public string Mama { get; set; }
    public string? Mak { get; set; }

    public int? Sl { get; set; }


}
   
