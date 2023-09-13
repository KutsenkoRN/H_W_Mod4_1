using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod4_1.ReqresApiHw
{
    internal class UserCreatedResponse
    {
        public string Name { get; set; }

        public string Job { get; set; }

        public int? Id { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
