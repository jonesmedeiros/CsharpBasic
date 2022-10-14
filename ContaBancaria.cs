namespace Banco;

    class ContaBancaria{
    
        public int NumeroConta { get ; private set;}
        public string _titular = string.Empty;
        private double _saldo;
        public double Saque{get; private set;}
        public double Deposito{get; private set;}
        public double Taxa {get; private set;}

        public ContaBancaria(){ 

        }

            public ContaBancaria(double saldo, string titular ){
                _titular = titular;
                _saldo = saldo;
            }

            public string Titular{
                get{ return _titular;}
                set{ 
                    if (value != null && value.Length > 1) {
                        _titular = value;}

                }
            }


        }
