using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Abastractions
{
    public abstract class ApiBase<T>
    {
        private readonly IApiMaxima _api;
        public abstract string VersaoAPI { get; set; }
        public abstract string EndPoint { get; set; }

        public ApiBase(IApiMaxima apiMaxima)
        {
            _api = apiMaxima;
        }

        internal virtual async Task<List<B>> Get<B>(string path)
        {
            RetornoApiMaxima retornoApiMaxima = await _api.Get(VersaoAPI, $"{EndPoint}/{path}");
            if (retornoApiMaxima != null && retornoApiMaxima.Data != null)
                return JsonConvert.DeserializeObject<List<B>>(retornoApiMaxima.Data.ToString());
            else
                return new List<B>();
        }

        internal virtual async Task<B> GetObjList<B>(string path)
        {
            RetornoApiMaxima retornoApiMaxima = await _api.Get(VersaoAPI, $"{EndPoint}/{path}");
            if (retornoApiMaxima != null && retornoApiMaxima.Data != null)
                return JsonConvert.DeserializeObject<B>(retornoApiMaxima.Data.ToString());
            else
                return default(B);
        }

        internal virtual async Task<List<B>> Get<B>(string path, string param)
        {
            RetornoApiMaxima retornoApiMaxima = await _api.Get(VersaoAPI, $"{EndPoint}/{path}?{param}");
            if (retornoApiMaxima != null && retornoApiMaxima.Data != null)
                return JsonConvert.DeserializeObject<List<B>>(retornoApiMaxima.Data.ToString());
            else
                return new List<B>();
        }

        internal abstract void DefinirCamposDefault(List<T> list);

        internal virtual async Task<ResponseApiMaxima<T>> Incluir(List<T> listItemsIncluir)
        {
            DefinirCamposDefault(listItemsIncluir);

            if (!listItemsIncluir.Any())
                return new ResponseApiMaxima<T>();

            int totalItensInserir = listItemsIncluir.Count();
            ResponseApiMaxima<T> retorno = new ResponseApiMaxima<T>();

            retorno.ErrosValidacao.AddRange(ValidarDados(listItemsIncluir));
            retorno.ErrosValidacao.AddRange(await ValidarChavesEstrangeiras(listItemsIncluir));

            if (!listItemsIncluir.Any())
                return retorno;

            var resultEnvioApi = await _api.Post(VersaoAPI, EndPoint, listItemsIncluir);

            if (resultEnvioApi.Sucesso)
            {
                retorno.ItensInserido = listItemsIncluir;
                retorno.TotalItensNaoInserido = totalItensInserir - listItemsIncluir.Count();
            }
            else
            {
                retorno.ErrosValidacao.Add(resultEnvioApi.Error.ToString());
            }

            return retorno;
        }

        internal virtual async Task<ResponseApiMaxima<T>> Alterar(List<T> listItensAlterar, bool ignoreValidacao = false)
        {
            if (!listItensAlterar.Any())
                return new ResponseApiMaxima<T>();

            int totalItensAlterado = listItensAlterar.Count();
            ResponseApiMaxima<T> retorno = new ResponseApiMaxima<T>();

            retorno.ErrosValidacao.AddRange(ValidarDados(listItensAlterar, alterando: true));
            if (!ignoreValidacao)
            {
                retorno.ErrosValidacao.AddRange(await ValidarChavesPrimarias(listItensAlterar));
                retorno.ErrosValidacao.AddRange(await ValidarChavesEstrangeiras(listItensAlterar));
            }

            if (!listItensAlterar.Any())
                return retorno;

            var resultEnvioApi = await _api.Put(VersaoAPI, EndPoint, listItensAlterar);
            if (resultEnvioApi.Sucesso)
            {
                retorno.TotalItensNaoInserido = totalItensAlterado - listItensAlterar.Count();
                retorno.ItensInserido = listItensAlterar;
            }
            else
            {
                retorno.ErrosValidacao.Add(resultEnvioApi.Error.ToString() + "\n");
            }

            return retorno;
        }

        internal virtual async Task<RetornoApiMaxima> Deletar(string[] list)
        {
            var result = await _api.Delete(VersaoAPI, EndPoint, list);
            return result;
        }

        internal virtual async Task<RetornoApiMaxima> Deletar(List<T> list)
        {
            var result = await _api.Delete(VersaoAPI, EndPoint, list);
            return result;
        }

        internal virtual async Task<RetornoApiMaxima> DeletarComParametros(string[] param, string path = null)
        {
            var rota = string.IsNullOrEmpty(path) ? $"{EndPoint}/{String.Join('/', param)}" : $"{EndPoint}/{path}/{String.Join('/', param)}";
            return await _api.Delete(VersaoAPI, rota);
        }

        private async Task<List<string>> ValidarChavesEstrangeiras(List<T> listItensInserir)
        {
            List<string> errosResult = new List<string>();
            List<PropertyInfo> listPropertysFKs = typeof(T)
                .GetProperties()
                .Where(s => s.GetCustomAttributes(true).Where(p => p is PropriedadeFKAttribute).Any())
                .ToList();

            Dictionary<PropertyInfo, List<ValidaChave>> dicDadosConsulta = new Dictionary<PropertyInfo, List<ValidaChave>>();

            foreach (var itemFk in listPropertysFKs)
                dicDadosConsulta[itemFk] = new List<ValidaChave>();

            foreach (var item in listItensInserir)
            {
                foreach (var itemFk in listPropertysFKs)
                {
                    PropriedadeFKAttribute propFk = (PropriedadeFKAttribute)
                        itemFk.GetCustomAttributes(true).Where(p => p is PropriedadeFKAttribute).FirstOrDefault();
                    if (propFk != null)
                    {
                        var valorCampo = itemFk.GetValue(item);
                        if (!string.IsNullOrEmpty(valorCampo?.ToString()) && !(propFk.IgnorarValorZero && valorCampo.ToString() == "0"))
                        {
                            dicDadosConsulta[itemFk].Add(new ValidaChave() { Chave = valorCampo.ToString().Replace("'", "") });
                        }
                    }
                }
            }

            foreach (var item in dicDadosConsulta)
            {
                PropriedadeFKAttribute propFk = (PropriedadeFKAttribute)
                    item.Key.GetCustomAttributes(true).Where(p => p is PropriedadeFKAttribute).FirstOrDefault();
                var propPk = propFk
                    .Type?.GetProperties()
                    .Where(s => s.GetCustomAttributes(true).Where(p => p is PropriedadePKAttribute).Any())
                    .FirstOrDefault();

                JsonPropertyAttribute jsonProperty = (JsonPropertyAttribute)
                    propPk?.GetCustomAttributes(true).Where(p => p is JsonPropertyAttribute).FirstOrDefault();
                var nomeColunaPK = jsonProperty?.PropertyName ?? propPk.Name;

                List<ValidaChave> validaChavesEnvio = item.Value.GroupBy(c => c.Chave).Select(s => s.First()).ToList();
                try
                {
                    int contador = 0;

                    do
                    {
                        var listaEnvio = validaChavesEnvio.Skip(contador).Take(500).ToList();

                        if (listaEnvio == null || listaEnvio.Count <= 0)
                            break;
                        contador += 500;

                        if (listaEnvio.Any())
                        {
                            string method = $"ValidarChaves/Localizar?entidade={propFk.Tabela}&colunaPK={nomeColunaPK}";
                            RetornoApiMaxima retornoApi = await _api.Post<List<ValidaChave>>("v3", method, listaEnvio);
                            List<ValidaChave> validaChavesRetorno = JsonConvert.DeserializeObject<List<ValidaChave>>(retornoApi.Data.ToString());
                            var validaChavesDiferenca = listaEnvio.Select(s => s.Chave).ToArray().Except(validaChavesRetorno.Select(s => s.Chave)).ToList();

                            foreach (var chave in validaChavesDiferenca)
                            {
                                errosResult.Add($"Não foi possível localizar a dependência {item.Key.Name} com o código: {chave}\n");
                                listItensInserir.RemoveAll(c => c.GetType().GetProperty(item.Key.Name).GetValue(c)?.ToString().Equals(chave) ?? false);
                            }
                        }
                    } while (true);
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e);
                    throw;
                }
            }

            return errosResult;
        }

        class ValidaChave
        {
            public string Chave { get; set; }
        }

        private async Task<List<string>> ValidarChavesPrimarias(List<T> list)
        {
            List<string> errosResult = new List<string>();
            List<string> errosItem = new List<string>();
            List<T> listRemove = new List<T>();
            var properties = typeof(T).GetProperties();

            foreach (var item in list)
            {
                var listPKs = properties
                    .Where(s => s.GetCustomAttributes(true).Where(p => p is PropriedadePKAttribute).Any())
                    .OrderBy(o => (o.GetCustomAttributes(true).Where(p => p is PropriedadePKAttribute).First() as PropriedadePKAttribute).Index)
                    .ToList();
                List<string> parametros = new List<string>();

                foreach (var itemPK in listPKs)
                {
                    PropriedadePKAttribute propPK = (PropriedadePKAttribute)
                        itemPK.GetCustomAttributes(true).Where(p => p is PropriedadePKAttribute).FirstOrDefault();
                    if (propPK != null)
                    {
                        var valorCampo = itemPK.GetValue(item);
                        if (!string.IsNullOrEmpty(valorCampo?.ToString()))
                        {
                            parametros.Add(valorCampo.ToString());
                        }
                        else
                        {
                            errosItem.Add($"O valor do campo PK: {itemPK.Name} não foi informado \n");
                        }
                    }
                }

                if (errosItem.Any())
                {
                    listRemove.Add(item);
                    errosResult.AddRange(errosItem);
                    errosItem.Clear();
                }
                else
                {
                    RetornoApiMaxima retornoApi = await _api.Get(VersaoAPI, EndPoint, string.Join("/", parametros));
                    if (retornoApi != null)
                    {
                        var existe = JsonConvert.DeserializeObject<List<object>>(retornoApi.Data.ToString());
                        if (!existe.Any())
                        {
                            listRemove.Add(item);
                            errosResult.Add($"Não foi possível localizar o registro para o(s) codigo(s): {string.Join(" - ", parametros)}\n");
                        }
                    }
                }
            }

            listRemove.ForEach(l => list.Remove(l));

            return errosResult;
        }

        private List<string> ValidarDados(List<T> list, bool alterando = false)
        {
            List<string> errosResult = new List<string>();
            var properties = typeof(T).GetProperties();
            ValidationContext validationContext = new ValidationContext(typeof(T));
            List<T> listRemove = new List<T>();

            foreach (var item in list)
            {
                List<string> errosItem = new List<string>();

                foreach (var property in properties)
                {
                    ICollection<ValidationResult> resultsErros = new List<ValidationResult>();

                    var validateAtts = property.GetCustomAttributes(false).Where(c => c is ValidationAttribute).Cast<ValidationAttribute>().ToList();
                    var isPropriedadePK =
                        property.GetCustomAttributes(true).Where(c => c is PropriedadePKAttribute).Cast<PropriedadePKAttribute>().ToList().Count() > 0;

                    var valorDaProperty = property.GetValue(item);
                    if (alterando)
                    {
                        validateAtts.RemoveAll(r => r is CampoObrigatorioAoInserirAttribute);
                        if (valorDaProperty == null)
                            continue;
                    }

                    validationContext.MemberName = property.Name;
                    validationContext.DisplayName = property.Name;

                    Validator.TryValidateValue(valorDaProperty, validationContext, resultsErros, validateAtts);

                    if (resultsErros.Any())
                    {
                        listRemove.Add(item);
                        errosItem.Add($"Propriedade: {property.Name} - Erro: {resultsErros.First().ErrorMessage}\n");
                    }

                    if (string.IsNullOrEmpty(valorDaProperty?.ToString()) && isPropriedadePK)
                    {
                        listRemove.Add(item);
                        errosItem.Add($"Propriedade PK: {property.Name} - Campo e obrigatório\n");
                    }
                }

                if (errosItem.Any())
                {
                    var idDoItem = properties.Where(s => s.GetCustomAttributes(true).Where(p => p is PropriedadePKAttribute).Any()).FirstOrDefault();
                    if (idDoItem != null)
                        errosItem.Insert(0, $"{idDoItem.Name}: {idDoItem.GetValue(item)} \n");

                    errosResult.AddRange(errosItem);
                }
            }

            listRemove.ForEach(l => list.Remove(l));

            return errosResult;
        }
    }
}
