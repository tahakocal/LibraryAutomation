﻿using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class Member : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
