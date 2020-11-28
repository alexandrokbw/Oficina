namespace Oficina
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbVeiculo
    {
        public int idVeiculo { get; set; }
        public int idCliente { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
    }
}
