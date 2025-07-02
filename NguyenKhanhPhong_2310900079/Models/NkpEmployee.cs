using System;
using System.Collections.Generic;

namespace NguyenTrongHung_2310900039.Models;

public partial class NkpEmployee
{
    public int NkpEmpId { get; set; }

    public string? NkpEmpName { get; set; }

    public string? NkpEmpLevel { get; set; }

    public DateOnly? NkpEmpStartDate { get; set; }

    public bool? NkpEmpStatus { get; set; }
}