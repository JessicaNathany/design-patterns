namespace DesignPatterns._1__Creational._1__Abstract_Factory.Exemplo_1
{
    public class InvestimentAccount
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public string Address { get; set; }
        public double Finance { get; set; }
        public TypeInvestiment TypeInvestiment { get; set; }
    }
    public enum TypeInvestiment
    {
        NationalTreasuryBonds = 1,
        Debentures = 2,
        MultimarketFunds = 3,
        CDB = 4,
        LCI = 5,
        BDR = 6,
        COE = 7,
        LCA = 8,
        CRI = 9,
        CRA = 10,
        FI = 11,
        PP = 12,
    }
}
