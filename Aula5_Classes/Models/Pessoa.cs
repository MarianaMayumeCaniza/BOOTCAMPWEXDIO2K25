using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula5_Classes.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompelto=> $"{Nome} {Sobrenome}".ToUpper();
        
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompelto}, e tenho {Idade} anos.");
        }
    }
}