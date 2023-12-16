using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAB5.Models;

public partial class Account
{
    [Key]
    public string Username { get; set; } = null!;
    [ForeignKey("Khachhang")]
    public string? Makh { get; set; }

    public string? Password { get; set; }

}
