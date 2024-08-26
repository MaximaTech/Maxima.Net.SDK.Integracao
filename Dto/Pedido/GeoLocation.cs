using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class GeoLocation
    {


        private string codUsuario;
        private DateTime data;
        private string provider;
        private float accuracy;
        private double altitude;
        private float bearing;
        private double latitude;
        private double longitude;
        private float speed;
        private long time;
        private string codcli;
        private long numped;
        private double distancia;
        private string codusur;
        private bool possuiJustificativasNaoVenda;
        private string tipo;


        public bool PossuiJustificativasNaoVenda
        {
            get { return possuiJustificativasNaoVenda; }
            set { possuiJustificativasNaoVenda = value; }
        }

        private bool? updateLocationConfirmed;


        public bool? UpdateLocationConfirmed
        {
            get { return updateLocationConfirmed; }
            set { updateLocationConfirmed = value; }
        }


        public string CodUsuario
        {
            get { return codUsuario; }
            set { codUsuario = value; }
        }


        public string CodUsur
        {
            get { return codusur; }
            set { codusur = value; }
        }


        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }


        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }


        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }


        public float Accuracy
        {
            get { return accuracy; }
            set { accuracy = value; }
        }

        [DataMember, IgnoreDataMember]
        public double Altitude
        {
            get { return altitude; }
            set { altitude = value; }
        }

        [DataMember, IgnoreDataMember]
        public float Bearing
        {
            get { return bearing; }
            set { bearing = value; }
        }


        public double Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }


        public double Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        [DataMember, IgnoreDataMember]
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public long Time
        {
            get { return time; }
            set { time = value; }
        }


        public string Codcli
        {
            get { return codcli; }
            set { codcli = value; }
        }


        public long Numped
        {
            get { return numped; }
            set { numped = value; }
        }


        public string NomeUsuario { get; set; }


        public string Cliente { get; set; }

        public short DataAccuracy { get; set; }

        public short CodRCA { get; set; }

        public DateTime DataFim { get; set; }

        public int QtdPedidos { get; set; }


        public GeoLocationCliente LocationCliente { get; set; }


        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }

    public class GeoLocationCliente
    {

        public string Codigo { get; set; }

        public string Cliente { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Telefone { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public bool Positivado { get; set; }

        public bool TitulosAberto { get; set; }

        public long TimeCheckin { get; set; }

        public long TimeCheckout { get; set; }

        public string getCliente()
        {
            return string.Format("{0:N0} - {1}", Codigo, Cliente.ToUpper().Trim());
        }



    }

    public class GeoLocationRCA
    {

        public int Codigo { get; set; }

        public string Nome { get; set; }

        public int CodigoSupervisor { get; set; }

        public string Supervisor { get; set; }

        public string Endereco { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string CEP { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public GeoLocation GeoLocation { get; set; }

    }

    public class GeolocationPedido
    {

        public long Numero { get; set; }

        public DateTime Data { get; set; }

        public int Hora { get; set; }

        public int Minuto { get; set; }

        public string Posicao { get; set; }

        public string CodigoCliente { get; set; }

        public string Cliente { get; set; }

        public decimal Valor { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public double Precisao { get; set; }

        public DateTime DataAberturaPedido { get; set; }

        public DateTime DataFechamentoPedido { get; set; }

        public double Distancia { get; set; }

        public List<GeolocationPedidoQuebrado> PedidosQuebrados { get; set; }

    }

    public class GeolocationConsulta
    {
        public uint CodConsulta { get; set; }
        public string Nome { get; set; }
        public string Resumo { get; set; }
        public string Link { get; set; }
    }

    public class GeolocationConsultaTotais
    {
        public double ValorTotalDentroPrecisao { get; set; }
        public uint QuantidadeTotalDentroPrecisao { get; set; }
        public double ValorTotalForaPrecisao { get; set; }
        public uint QuantidadeTotalForaPrecisao { get; set; }
        public double TotalPostivados { get; set; }
        public double TotalNaoPostivados { get; set; }
    }

    public class GeolocationPedidoQuebrado
    {
        public long Numero { get; set; }
        public decimal Valor { get; set; }

    }





}