using SkateFactory3.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace SkateFactory3.Models;

public class Skateboard
{
    [Key]
    public int Id { get; set; }

    [Required()] // NOT NULL
    [Unicode(false)] // from Microsoft.EntityFrameworkCore namespace (NuGet package needed)
    [StringLength(50)] //NVARCHAR(50)
    public string Name { get; set; } = string.Empty;

    [Required()]
    public float Weight { get; set; }

    [Required()]
    [Range(1, int.MaxValue, ErrorMessage = "The Color field is required")]
    public EColor Color { get; set; }

    [Required()]
    [DisplayName("Skate Type")]
    [Range(1, int.MaxValue, ErrorMessage = "The Skate Type field is required")]
    public ESkateType SkateType { get; set; }

    [Required()]
    [DisplayName("Brake Type")]
    [Range(1, int.MaxValue, ErrorMessage = "The Brake Type field is required")]
    public EBrakeType BrakeType { get; set; }

    [Required()]
    [DisplayName("Shape Type")]
    [Range(1, int.MaxValue, ErrorMessage = "The Shape Type field is required")]
    public EShapeType ShapeType { get; set; }
}