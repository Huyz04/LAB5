using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAB5.Models;

public partial class Hoadon
{
    [Key]
    public string Mahd { get; set; }
    [ForeignKey("Khachhang")]
    public string? Makh { get; set; }

    public decimal? Tht { get; set; }

    public DateTime? Ngayhd { get; set; }

   
}
