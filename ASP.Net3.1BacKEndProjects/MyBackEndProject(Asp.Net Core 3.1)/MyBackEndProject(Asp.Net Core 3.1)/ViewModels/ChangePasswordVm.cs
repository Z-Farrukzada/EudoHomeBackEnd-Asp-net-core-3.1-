using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackEndProject_Asp.Net_Core_3._1_.ViewModels
{
    public class ChangePasswordVm
    {
        [Required,DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(NewPassword))]
        public string CheckPassword { get; set; }
     
    }
}
