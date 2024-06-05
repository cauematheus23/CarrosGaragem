﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Carro_Servico
    {
        public readonly static string SELECT = "SELECT * from TB_CARROSERVICO cs inner join TB_CARRO c ON cs.PlacaCarro = c.Placa inner join TB_SERVICO s ON cs.IdServico = s.Id";
        public int Id { get; set; }
        public Carro Carro { get; set; }    
        public Servico Servico { get; set; }
        public bool Status { get; set; }

        public override string? ToString() => $"Id: {Id}\nCarro: {Carro.Placa}\nServiço: {Servico.Id}\nStatus: {Status}";
    }
}
