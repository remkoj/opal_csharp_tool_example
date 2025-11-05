
using System.ComponentModel.DataAnnotations;

namespace OpalDemoTool.Tools.Greetings;

public class GreetingsParameters
{
    [Required]
    [MinLength(1)]
    [MaxLength(255)]
    public string Name { get; set; } = string.Empty;
}