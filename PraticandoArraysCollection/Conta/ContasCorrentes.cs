﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoArraysCollection.Conta
{
    public class ContasCorrentes
    {
        public Clientes Titular {  get; set; }

        private string Nome_Agencia { get; set; }


        private int _numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value; 
                }
            }
        }

        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public bool Sacer(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor <0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContasCorrentes destino)
        {
            if(saldo < valor) 
            {
                return false;
            }
            if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public int CompareTo(ContasCorrentes ? outro)
        {
            if (outro == null)
            {
                return 1;
            }
            else
            {
                return this.Numero_agencia.CompareTo(outro.Numero_agencia);
            }       
        }

        public ContasCorrentes(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            Titular = new Clientes();
            TotalDeContasCriadas += 1;   
        }

        public ContasCorrentes(int numero_agencia)
        {
            Numero_agencia = numero_agencia;
            Conta = Guid.NewGuid().ToString().Substring(0,8);
            Titular = new Clientes();
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }

        public override string ToString()
        {
            return $" === DADOS DA CONTA === \n" +
                   $"Número da Conta : {this.Conta} \n" +
                   $"Número da Agência : {this.Numero_agencia} \n" +
                   $"Saldo da Conta: {this.Saldo} \n" +
                   $"Titular da Conta: {this.Titular.Nome} \n" +
                   $"CPF do Titular  : {this.Titular.Cpf} \n" +
                   $"Profissão do Titular: {this.Titular.Profissao}\n\n";
        }

    }
}
