public class BankBase{

// tüm bankalara aynı propları tanımlamak geriye tüm bankaların bankbase sınıfından kalıtılmasını sağladık
// bunu yaparak, aslında aynı propların birden fazla class içerisinde olmamasını sağladık!!
    public string Url { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
}