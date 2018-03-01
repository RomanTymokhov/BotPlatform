//------------------------------------------------------------------------------
// <автоматически создаваемое>
//     Этот код создан программой.
//     //
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторного создания кода.
// </автоматически создаваемое>
//------------------------------------------------------------------------------

namespace KunaService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TickerLine", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.RciveData")]
    public partial class TickerLine : object
    {
        
        private int atField;
        
        private KunaService.Ticker tickerField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int at
        {
            get
            {
                return this.atField;
            }
            set
            {
                this.atField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.Ticker ticker
        {
            get
            {
                return this.tickerField;
            }
            set
            {
                this.tickerField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ticker", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.RciveData")]
    public partial class Ticker : object
    {
        
        private decimal amountField;
        
        private decimal buyField;
        
        private decimal highField;
        
        private decimal lastField;
        
        private decimal lowField;
        
        private decimal sellField;
        
        private decimal volField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal buy
        {
            get
            {
                return this.buyField;
            }
            set
            {
                this.buyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal high
        {
            get
            {
                return this.highField;
            }
            set
            {
                this.highField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal last
        {
            get
            {
                return this.lastField;
            }
            set
            {
                this.lastField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal sell
        {
            get
            {
                return this.sellField;
            }
            set
            {
                this.sellField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal vol
        {
            get
            {
                return this.volField;
            }
            set
            {
                this.volField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderBook", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.RciveData")]
    public partial class OrderBook : object
    {
        
        private KunaService.Order[] asksField;
        
        private KunaService.Order[] bidsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.Order[] asks
        {
            get
            {
                return this.asksField;
            }
            set
            {
                this.asksField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.Order[] bids
        {
            get
            {
                return this.bidsField;
            }
            set
            {
                this.bidsField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.RciveData")]
    public partial class Order : object
    {
        
        private decimal avg_priceField;
        
        private System.DateTime createdAtField;
        
        private decimal executedVolumeField;
        
        private KunaService.MarketPair marketPairField;
        
        private uint orderIdField;
        
        private KunaService.OrderState orderStateField;
        
        private KunaService.OrderType orderTypeField;
        
        private decimal priceField;
        
        private decimal remainingVolumeField;
        
        private KunaService.OrderSide sideField;
        
        private uint tradesCountField;
        
        private decimal volumeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal avg_price
        {
            get
            {
                return this.avg_priceField;
            }
            set
            {
                this.avg_priceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime createdAt
        {
            get
            {
                return this.createdAtField;
            }
            set
            {
                this.createdAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal executedVolume
        {
            get
            {
                return this.executedVolumeField;
            }
            set
            {
                this.executedVolumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.MarketPair marketPair
        {
            get
            {
                return this.marketPairField;
            }
            set
            {
                this.marketPairField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint orderId
        {
            get
            {
                return this.orderIdField;
            }
            set
            {
                this.orderIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.OrderState orderState
        {
            get
            {
                return this.orderStateField;
            }
            set
            {
                this.orderStateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.OrderType orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal remainingVolume
        {
            get
            {
                return this.remainingVolumeField;
            }
            set
            {
                this.remainingVolumeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.OrderSide side
        {
            get
            {
                return this.sideField;
            }
            set
            {
                this.sideField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint tradesCount
        {
            get
            {
                return this.tradesCountField;
            }
            set
            {
                this.tradesCountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MarketPair", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.Enums")]
    public enum MarketPair : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        btcuah = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ethuah = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        bchuah = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        wavesuah = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        xrpuah = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        gbguah = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        golgbg = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        kunbtc = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        bchbtc = 8,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        rmcbtc = 9,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        rbtc = 10,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        arnbtc = 11,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        evrbtc = 12,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        b2bbtc = 13,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderState", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.Enums")]
    public enum OrderState : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        wait = 0,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderType", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.Enums")]
    public enum OrderType : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        limit = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        market = 1,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="OrderSide", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.Enums")]
    public enum OrderSide : int
    {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        buy = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        sell = 1,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Trade", Namespace="http://schemas.datacontract.org/2004/07/CunaWrapper.DataLevel.RciveData")]
    public partial class Trade : object
    {
        
        private System.DateTime createdAtField;
        
        private decimal fundsField;
        
        private KunaService.MarketPair marketPairField;
        
        private decimal priceField;
        
        private uint tradeIdField;
        
        private decimal volumeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime createdAt
        {
            get
            {
                return this.createdAtField;
            }
            set
            {
                this.createdAtField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal funds
        {
            get
            {
                return this.fundsField;
            }
            set
            {
                this.fundsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public KunaService.MarketPair marketPair
        {
            get
            {
                return this.marketPairField;
            }
            set
            {
                this.marketPairField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public uint tradeId
        {
            get
            {
                return this.tradeIdField;
            }
            set
            {
                this.tradeIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal volume
        {
            get
            {
                return this.volumeField;
            }
            set
            {
                this.volumeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KunaService.IKunaServise")]
    public interface IKunaServise
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKunaServise/GetTimestamp", ReplyAction="http://tempuri.org/IKunaServise/GetTimestampResponse")]
        System.Threading.Tasks.Task<string> GetTimestampAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKunaServise/GetTickerline", ReplyAction="http://tempuri.org/IKunaServise/GetTickerlineResponse")]
        System.Threading.Tasks.Task<KunaService.TickerLine> GetTickerlineAsync(string marketPair);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKunaServise/GetOrderBook", ReplyAction="http://tempuri.org/IKunaServise/GetOrderBookResponse")]
        System.Threading.Tasks.Task<KunaService.OrderBook> GetOrderBookAsync(string marketPair);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKunaServise/GetTrade", ReplyAction="http://tempuri.org/IKunaServise/GetTradeResponse")]
        System.Threading.Tasks.Task<KunaService.Trade[]> GetTradeAsync(string marketPair);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface IKunaServiseChannel : KunaService.IKunaServise, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class KunaServiseClient : System.ServiceModel.ClientBase<KunaService.IKunaServise>, KunaService.IKunaServise
    {
        
    /// <summary>
    /// Реализуйте этот разделяемый метод для настройки конечной точки службы.
    /// </summary>
    /// <param name="serviceEndpoint">Настраиваемая конечная точка</param>
    /// <param name="clientCredentials">Учетные данные клиента.</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public KunaServiseClient(EndpointConfiguration endpointConfiguration) : 
                base(KunaServiseClient.GetBindingForEndpoint(endpointConfiguration), KunaServiseClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KunaServiseClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(KunaServiseClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KunaServiseClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(KunaServiseClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public KunaServiseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> GetTimestampAsync()
        {
            return base.Channel.GetTimestampAsync();
        }
        
        public System.Threading.Tasks.Task<KunaService.TickerLine> GetTickerlineAsync(string marketPair)
        {
            return base.Channel.GetTickerlineAsync(marketPair);
        }
        
        public System.Threading.Tasks.Task<KunaService.OrderBook> GetOrderBookAsync(string marketPair)
        {
            return base.Channel.GetOrderBookAsync(marketPair);
        }
        
        public System.Threading.Tasks.Task<KunaService.Trade[]> GetTradeAsync(string marketPair)
        {
            return base.Channel.GetTradeAsync(marketPair);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IKunaServise))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IKunaServise))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IKunaServise))
            {
                return new System.ServiceModel.EndpointAddress("http://kunaservice/KunaServise.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IKunaServise))
            {
                return new System.ServiceModel.EndpointAddress("https://kunaservice.azurewebsites.net/KunaServise.svc");
            }
            throw new System.InvalidOperationException(string.Format("Не удалось найти конечную точку с именем \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IKunaServise,
            
            BasicHttpsBinding_IKunaServise,
        }
    }
}
