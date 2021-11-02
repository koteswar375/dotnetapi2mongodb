using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        //Data Annotations
        [Required]
        public string Name { get; init; }

        [Required]
        public decimal Price { get; init; }
    }
}