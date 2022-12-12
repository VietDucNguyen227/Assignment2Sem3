﻿using Microsoft.AspNetCore.Mvc;

namespace JwtApiSample.Models.Dto
{
    public class UserLoginDto 
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
