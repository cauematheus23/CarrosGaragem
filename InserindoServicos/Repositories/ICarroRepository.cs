﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICarroRepository
    {
        string InserirCarro(Carro carro);
        bool InserirApenasCarro(Carro carro);
    }
}
