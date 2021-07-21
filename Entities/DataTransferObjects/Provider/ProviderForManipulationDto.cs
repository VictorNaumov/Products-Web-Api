﻿using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    public class ProviderForManipulationDto
    {
        [Required(ErrorMessage = "Provider name is a required field.")]
        [MaxLength(75, ErrorMessage = "Maximum length for the name is 75 characters.")]
        public string Name { get; set; }
    }
}
