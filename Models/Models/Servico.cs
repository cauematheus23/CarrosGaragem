﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Servico
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public override string? ToString() => $"Id: {Id},\n Descrição: {Descricao}";
    }
}