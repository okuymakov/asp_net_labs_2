using System.ComponentModel.DataAnnotations;

namespace asp_net_labs_2_1.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Не указано имя пользователя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не возраст")]
        [Range(18, 65, ErrorMessage = "Возраст должен быть от 18 до 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Не указана эл.почта")]
        [RegularExpression(pattern: @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="E-mail введен некорректно")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Используйте не менее 8 символов")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

    }
}
