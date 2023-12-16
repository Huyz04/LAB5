using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LAB5.Models;

public partial class Khachhang
{
    [Key]
    public string Makh { get; set; } 

    public string? Ho { get; set; }

    public string? Ten { get; set; }

    public DateTime? Ngaysinh { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    
}
