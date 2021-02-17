using System;
using System.ComponentModel.DataAnnotations;

namespace SqlEncryption.Model
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string SocialSecurityNumber { get; set; }

    }
}