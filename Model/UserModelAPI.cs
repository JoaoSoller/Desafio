using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCarros.Model
{
    class UserModelApi
    {
      
        public String user{ get; set; }

        public String password{ get; set; }

        public UserModelApi(string user, string password, string token)
        {
            this.user = user;
            this.password = password;
        }

        public UserModelApi()
        {
        }

    }

}
