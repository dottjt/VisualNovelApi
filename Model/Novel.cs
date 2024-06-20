using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisualNovelApi.Model;

public class Novel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public List<Chapter> Chapters { get; set; } = default!;
}

public class Chapter
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public List<Slide> Slides { get; set; } = default!;
}

public class Slide
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    [Required]
    public int SlideOrder { get; set; }
    
    [Required]
    public string SlideText { get; set; } = default!;

    public Character Character { get; set; } = default!;
}

public class Character
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
    
    public string Name { get; set; } = default!;
    
    public CharacterVariation CharacterVariation { get; set; } = default!;
}


public class CharacterVariation
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public string AvatarUrl { get; set; } = default!;
}
