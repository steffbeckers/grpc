using System.ComponentModel.DataAnnotations;

namespace gRPC.Client.Blazor.Models;

public class GreeterInput
{
    [Required]
    [StringLength(50, ErrorMessage = "Name is too long.")]
    public string Name { get; set; }
}