using System.ComponentModel.DataAnnotations;

namespace asp_net_labs_2_2.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Не указан логин")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
