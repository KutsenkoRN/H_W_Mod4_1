using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_1.ReqresApiHw
{
    internal sealed class CreateUserParametersRequest
    {
        public string Name { get; set; }

        public string Job { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
