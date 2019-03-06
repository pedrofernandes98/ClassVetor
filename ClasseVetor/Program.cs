using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseVetor
{
    class Vetor
    {
        private int[] _Vetor;
        
        

        private int _Tamanho;

        public int Tamanho
        {
            get { return Tamanho; }
            //set
            //{
            //    if(value < 0)//Não permite que se atribua um valor menor que zero à dimensão do vetor
            //    {
            //        _Tamanho = 0;
            //    }
            //    else
            //    {
            //        _Tamanho = value;
            //    }
            //}
        }

        

        public void CriaVetor(int x)//Cria um vetor de tamanho "x"
        {
            _Tamanho = x;
            _Vetor = new int[_Tamanho];
        }

        public void RandomizaVetor()//Popula o vetor com valores aleatórios de 1 a 99
        {
            Random x = new Random();

            for(int i = 0; i < _Tamanho; i++)
            {
                _Vetor[i] = x.Next(1, 100);
            }
        }

        public void RandomizaVetor(int Maximo)//Popula o vetor com valores aletórios com um máximo especificado pelo usuário
        {
            Random x = new Random();

            for(int i = 0; i < _Tamanho; i++)
            {
                _Vetor[i] = x.Next(Maximo + 1);
            }
        }

        public void RandomizaVetor(int ValorMinimo,int ValorMaximo)//Popula o vetor com valores aletórios com o mínimo e o máximo inseridos pelo usário
        {
            Random x = new Random();

            for(int i = 0; i < _Tamanho; i++)
            {
                _Vetor[i] = x.Next(ValorMinimo, ValorMaximo + 1);
            }
        }

        public void MostraVetor()//Mostra o Vetor Completo
        {
            Console.Clear();

            Console.Write("Vetor: ");
            for(int i = 0; i < _Tamanho; i++)
            {
                Console.Write("{0,6}", _Vetor[i]);
            }
            Console.ReadKey();
        }

        public void MostraVetor(string texto)//Mostra o vetor Completo com o título inserido pelo usuário
        {
            Console.Clear();

            Console.Write(texto);
            for (int i = 0; i < _Tamanho; i++)
            {
                Console.Write("{0,6}", _Vetor[i]);
            }
            Console.ReadKey();
        }

        public void Add(int novoValor)
        {
            int NovoTamanho = _Tamanho + 1;
            int[] aux = new int[NovoTamanho];

            for(int i = 0; i < _Tamanho; i++)
            {
                aux[i] = _Vetor[i];
            }

            aux[NovoTamanho - 1] = novoValor;

            CriaVetor(NovoTamanho);
            _Tamanho = NovoTamanho;

            for (int i = 0; i < _Tamanho; i++)
            {
                _Vetor[i] = aux[i];
            }

            
            
        }

        public void Add(int novoValor, int posNovoValor)
        {
            Add(novoValor);
            int aux = 0;
            if(posNovoValor != _Tamanho - 1)
            {
                for(int i = 0; i < _Tamanho; i++)
                {
                    if(i == posNovoValor)
                    {
                        aux = _Vetor[i];

                    }
                }

            }
        }

        public int VetorLenght()//Retorna o tamanho do vetor
        {
            return _Tamanho;
        }

        public int IndexOf(int elemento)
        {
            for (int i = 0; i < _Tamanho; i++)
            {
                if (_Vetor[i] == elemento)
                {
                    return i;
                }
            }

            return -1;
        }

        public int ValueOf(int posicao)
        {
            for(int i = 0; i < _Tamanho;i++)
            {
                if(i == posicao)
                {
                    return _Vetor[i];
                }
            }

            return 0;
        }

        public void ChangeValueOf(int posicao,int NovoValor)
        {
            for(int i = 0; i < _Tamanho; i++)
            {
                if(i == posicao)
                {
                    _Vetor[i] = NovoValor;
                }
            }
        }








    }

    class Program
    {
        static void Main(string[] args)
        {
            Vetor vet = new Vetor();

            vet.CriaVetor(10);
            vet.RandomizaVetor(50,70);
            vet.MostraVetor("Meu Vetor de 50 a 70: ");
            vet.Add(17);
            vet.MostraVetor();
            Console.Clear();
            Console.WriteLine(vet.IndexOf(17));
            
            Console.WriteLine(vet.ValueOf(0));
            Console.ReadKey();
            vet.ChangeValueOf(0, 10);
            vet.MostraVetor();

            



        }
    }
}
