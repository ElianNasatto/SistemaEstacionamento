﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IEstacionadoRepository
    {
        int Inserir(Estacionado estacionado);

        bool Alterar(Estacionado estacionado);

        List<Estacionado> ObterTodos();

        bool Apagar(int id);

        Estacionado ObterPelaPlaca(int placa);
    }
}