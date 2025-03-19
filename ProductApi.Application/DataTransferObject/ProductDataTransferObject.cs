using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApi.Application.DataTransferObject
{
    public record ProductDataTransferObject
    (
        [Required] int Id,
        [Required] string Name,
        [Required] int Price,
        [Required, Range(1, int.MaxValue)] int Quantity
    );
        
}
