using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record CreateItemDto
    {
        //Data Annotations
        [Required]
        public string Name { get; init; }

        [Required]
        public decimal Price { get; init; }
    }
}