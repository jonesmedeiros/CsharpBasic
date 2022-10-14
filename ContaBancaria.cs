namespace Banco;

    class ContaBancaria{
    
        public int Numero { get ; private set;}
        public string _titular = string.Empty;
        public double Saldo{get; private set;}
              
        //primeiro Construtor com dois parametros
        public ContaBancaria(int numero, string titular ){
                Numero = numero;
                _titular = titular; 

        }
        //segundo Construtor com três parametros
            public ContaBancaria(int numero, string titular, double depositoInicial){ 
                Numero = numero;
                _titular = titular; 
                 Deposito(depositoInicial);
            }

            public string Titular{
                get{ return _titular;}
                set{ 
                    if (value != null && value.Length > 1) {
                        _titular = value;}
                 }
            }
            //primeiro metodo
            public void Deposito(double quantia){
                Saldo += quantia;
            }
             //segundo metodo
            public void Saque(double quantia){
                Saldo -= quantia + 5.0;
            }
     }
