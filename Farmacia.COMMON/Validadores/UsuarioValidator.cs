using Farmacia.COMMON.Entidades;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Validadores
{
    public class UsuarioValidator : AbstractValidator<usuario>
    {
        public UsuarioValidator()
        {

            RuleFor(u => u.Apellidos).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.NomUsuario).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.Nombre).NotNull().NotEmpty().Length(1, 50);
            RuleFor(u => u.Password).NotNull().NotEmpty().Length(1, 50);

        }
    }
}
