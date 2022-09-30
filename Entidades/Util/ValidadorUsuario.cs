using FluentValidation;
using Parcial.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Util
{
    public class ValidadorUsuario : AbstractValidator<Usuario>
    {
        public ValidadorUsuario()
        {
            RuleFor(usuario => usuario.Username).NotEmpty().NotNull().WithMessage("Ingrese un nombre de usuario valido");
            RuleFor(usuario => usuario.Password).NotEmpty().NotNull().WithMessage("Ingrese una contraseña valida");
            RuleFor(usuario => usuario.NombreCompleto).NotEmpty().NotNull().Matches("[|]").WithMessage("Ingrese un nombre valido");
        }
    }
}
