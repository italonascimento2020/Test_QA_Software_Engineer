using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wex_QA_Test_API.Models
{
    public class WexUserModel
    {
        private int codigo;
        private string nome;
        private string login;

        public WexUserModel() { }
         

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }
    }
}