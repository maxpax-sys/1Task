using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Task1_1.Models
{
    public class GuestResponse
    {
       
      
            [Required(ErrorMessage = "Заполните поле имя")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Заполните поле email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Заполните поле Номер телефона")]
            public string Phone { get; set; }

        }
    }

