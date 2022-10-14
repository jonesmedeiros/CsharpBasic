namespace Banco;

    class ContaBancaria{
    
        public int Numero { get ; private set;}
        public string _titular;
        public double Saldo{get; set;}
              

        public ContaBancaria(int numero, string titular ){
                Numero = numero;
                Titular = titular; 

        }

            public ContaBancaria(int numero, string titular, double saldo ){
                Numero = numero;
                _titular = titular;
                 Saldo = 0.0;
            }

            public string Titular{
                get{ return _titular;}
                set{ 
                    if (value != null && value.Length > 1) {
                        _titular = value;}

                }
            }


        }
