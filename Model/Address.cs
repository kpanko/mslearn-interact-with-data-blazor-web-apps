using System.ComponentModel.DataAnnotations;

namespace BlazingPizza
{
    public class Address
    {
        public int Id { get; set; }

        [Required,
         MinLength(3,
            ErrorMessage = "Please use a Name longer than 3 letters."),
         MaxLength(100,
            ErrorMessage = "Please use a Name shorter than 100 letters.")]
        public string Name { get; set; } = default!;

        [Required,
         MinLength(5,
            ErrorMessage = "Please use a Address longer than 5 letters."),
         MaxLength(100,
            ErrorMessage = "Please use a Address shorter than 100 letters.")]
        public string Line1 { get; set; } = default!;

        [MaxLength(100)]
        public string? Line2 { get; set; }

        [Required,
         MinLength(3,
            ErrorMessage = "Please use a City longer than 3 letters."),
         MaxLength(50,
            ErrorMessage = "Please use a City shorter than 50 letters.")]
        public string City { get; set; } = default!;

        [Required,
         MinLength(3,
            ErrorMessage = "Please use a Region longer than 3 letters."),
         MaxLength(20,
            ErrorMessage = "Please use a Region shorter than 20 letters.")]
        public string Region { get; set; } = default!;

        [Required,
         RegularExpression(@"^([0-9]{5})$",
            ErrorMessage = "Please use a valid Postal Code with five numbers.")]
        public string PostalCode { get; set; } = default!;
    }
}
