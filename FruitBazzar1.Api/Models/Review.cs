﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FruitBazzar1.Api.Models;

public partial class Review
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public string Rating { get; set; }

    public string Comment { get; set; }

    public virtual Customers Customer { get; set; }

    public virtual Products Product { get; set; }
}