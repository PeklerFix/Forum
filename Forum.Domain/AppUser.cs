﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Domain
{
    [Table("AppUser")]     //DODAJEMY ATRYBUTY DAJĄCY NAZWĘ TABELI
    public class AppUser
    {
        [Key]                   // WSKAZUJEMY KLUCZ GÓWNY
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }    
        public IEnumerable<Question>? Questions { get; set; }
        public IEnumerable<Answer>? Answers { get; set; }
        public UserProfile? UserProfile { get; set; }    
    }
}
