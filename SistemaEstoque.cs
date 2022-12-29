using System;

using SistemaEstoque;

namespace SistemaEstoque;

    public class Item
    {
        public Item()

        {
            this.Nome = " ";
            this.Referencia = 0;
            this.Preco = 0;

        }
        
            private String nome;
            public String Nome
            {
                get { return nome; }
                set { String texto  = value; 
                    nome = texto;}
                
            }
            

           private int referencia;
           public int Referencia
           {
            get { return this.referencia; }
            set { this.referencia = value; }
           }

           private double Preco;
           public double preco
           {
            get { return this.Preco; }
            set { this.Preco = value; }
           }
           
            public void ExibirDadosItem()
        {
            Console.WriteLine("Nome do produto: " + this.Nome);
            Console.WriteLine("Referência do produto: " + this.Referencia);
            Console.WriteLine("Preço do produto: " + this.Preco + " reais");
        }
        
          



    }