using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoArraysCollection.Conta
{
    public class Clientes
    {
        public string Cpf { get; set; }

        private string _nome;
        public string Nome
        {
            get 
            {
                return _nome;
            }
            set 
            {
                if(value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracters. ");
                }
                _nome = value;
            }
        }

        public string Profissao { get; set; }
        public static int TotalClientesCadastrados { get; set; }

        public Clientes()
        {
            TotalClientesCadastrados = TotalClientesCadastrados + 1;
        }

    }
}
