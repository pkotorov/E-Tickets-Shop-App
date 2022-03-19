﻿using eTicketsShop.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace eTicketsShop.Data.ValidationModels
{
    public class MovieValidationModel
    {
        public int Id { get; set; }

        [Display(Name = "Movie")]
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required.")]
        public string ImageUrl { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required.")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required.")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required.")]
        public MovieCategory MovieCategory { get; set; }
    }
}
