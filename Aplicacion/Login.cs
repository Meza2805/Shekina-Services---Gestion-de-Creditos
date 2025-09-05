using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Aplicacion
{
    public interface Login
    {
        Task<string> AccederSistema(LoginRequest login);
    }
}
