using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VisualNovelApi.Model;

public class Novel
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(200)")]
    [MaxLength(200)]
    public required string Title { get; set; }

    public string? CoverUrl { get; set; }

    public List<Chapter>? Chapters { get; set; }
}

public class Chapter
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(200)")]
    [MaxLength(200)]
    public required string Title { get; set; }

    public int NovelId { get; set; }
    public Novel? Novel { get; set; }

    // public List<Scene> Scenes { get; set; } = default!;
}

// public class Scene
// {
//     [Key]
//     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//     public Guid Id { get; set; }

//     public List<Slide> Slides { get; set; } = default!;
// }

// public class Slide
// {
//     [Key]
//     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//     public Guid Id { get; set; }

//     [Required]
//     public int SlideOrder { get; set; }

//     [Required]
//     public string SlideText { get; set; } = default!;

//     public Character Character { get; set; } = default!;
// }

// public class Character
// {
//     [Key]
//     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//     public Guid Id { get; set; }

//     [Required]
//     public string Name { get; set; } = default!;

//     // public CharacterVariation CharacterVariation { get; set; } = default!;
// }


// public class CharacterVariation
// {
//     [Key]
//     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//     public Guid Id { get; set; }

//     public string AvatarUrl { get; set; } = default!;

//     public string CharacterPosition { get; set; } = default!;
// }
