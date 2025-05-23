﻿using System.ComponentModel.DataAnnotations;
using SiteBlazorServer.Models;

namespace SiteBlazorServer.Models;

public class Category
{
    [Key]
    [Required(ErrorMessage = "Id é obrigatório")]
    public int Id { get; set; }

    [Required(ErrorMessage = "the título é obrigatório")]
    [MaxLength(50, ErrorMessage = "Título deve ter no máximo 50 caracteres")]
    [MinLength(5, ErrorMessage = "Título deve ter no mínimo 5 caracteres")]
    public string Title { get; set; } = "";

    public List<Product> Products { get; set; } = new();
}