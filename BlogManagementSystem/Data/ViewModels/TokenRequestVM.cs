﻿using System.ComponentModel.DataAnnotations;

namespace BlogManagementSystem.Data.ViewModels
{
    public class TokenRequestVM
    {
        [Required]
        public string Token { get; set; }

        [Required]
        public string RefreshToken { get; set; }
    }
}
