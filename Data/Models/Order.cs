using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models {
    public class Order {
        [BindNever]
        public int Id { get; set; }
        [Display(Name ="Введите имя")]
        [StringLength(15)]
        [Required(ErrorMessage ="Длинна имени не менее 2 символов")]
        public string Name { get; set; }
        [Display(Name = "фамилия")]
        [StringLength(15)]
        [Required(ErrorMessage = "Длинна фамилии не менее 2 символов")]
        public string Surname { get; set; }
        [Display(Name = "адрес")]
        [StringLength(20)]
        [Required(ErrorMessage = "Длинна адреса не менее 2 символов")]
        public string Address { get; set; }
        [Display(Name = "номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20)]
        [Required(ErrorMessage = "Длинна номера телефона не менее 10 символов")]
        public string Phone { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Длинна номера телефона не менее 5 символов")]
        public string Email { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }




    }
}
