﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWasmMiniProject.Models;

public class PersonModel
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

}
