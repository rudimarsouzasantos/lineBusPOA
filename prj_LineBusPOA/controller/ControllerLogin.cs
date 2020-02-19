using LineBusPOA.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineBusPOA.controller
{
    class ControllerLogin
    {
        public void CheckLogin(String txtNome, String txtSenha)
        {
            User user = new User(txtNome, txtSenha);
        }

        public Boolean validation(String txtNome, String txtSenha)
        {
            if (txtNome.Equals(null) || txtNome.Equals(String.Empty)
                || txtSenha.Equals(null) || txtSenha.Equals(String.Empty))
            {
                return false;
            }
            else return true;
        }
        
    }
}
