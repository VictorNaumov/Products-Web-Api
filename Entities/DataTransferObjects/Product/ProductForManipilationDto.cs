﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Entities.Models;

namespace Entities.DataTransferObjects
{
    public class ProductForManipilationDto
    {
        [Required(ErrorMessage = "Product name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the name is 30 characters.")]
        public string Name { get; set; }

        [MaxLength(150, ErrorMessage = "Maximum length for the description is 150 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product name is a required field.")]
        [Range(0, 100000, ErrorMessage = "Range cost from 0$ to 100000$.")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Provider id name is a required field.")]
        public int ProviderId { get; set; }

        [Required(ErrorMessage = "Category id is a required field.")]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public Provider Provider { get; set; }

        [JsonIgnore]
        public Category Category { get; set; }

    }
}
