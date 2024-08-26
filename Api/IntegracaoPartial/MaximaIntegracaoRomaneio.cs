using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {


        /// <summary>
        /// Buscar romaneios por faixa de datas e ids de filiais.
        /// </summary>
        /// <returns>Uma lista de romaneios</returns>
        public async Task<List<RomaneioMaxima>> BuscarRomaneios(DateTime dtInicio, DateTime dtFim, List<string> idsFiliais)
        {
            var idsFiliaisFormatadas = string.Join(",", idsFiliais);
            var retornado = await _romaneioMaximaApi.GetObjList<RomaneioApi>($"consultar?dataSaidaInicio={dtInicio:dd-MM-yy}&dataSaidaFim={dtFim:dd-MM-yy}&idsFiliais=&{idsFiliaisFormatadas}");
            return retornado.RomaneioMaximas;
        }

    }
}


