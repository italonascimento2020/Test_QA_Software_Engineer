using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wex_QA_Test_API.Models
{
    public class WexProjectModel
    {
        private int codigo;
        private string descricaoProjeto;
        private DateTime dataInicio;

        public WexProjectModel() { }


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

        public string DescricaoProjeto
        {
            get
            {
                return descricaoProjeto;
            }

            set
            {
                descricaoProjeto = value;
            }
        }

        public DateTime DataInicio
        {
            get
            {
                return dataInicio;
            }

            set
            {
                dataInicio = value;
            }
        }
    }
}