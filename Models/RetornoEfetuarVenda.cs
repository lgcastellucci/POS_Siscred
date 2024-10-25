
namespace POS_Siscred.Models
{
    public class RetornoEfetuarVenda
    {
        public string response_code { get; set; }
        public string response_message { get; set; }
        public string reference_id { get; set; }
        public string merchant_id { get; set; }
        public string amount { get; set; }
        public string installments { get; set; }
        public string authorization { get; set; }
        public string date { get; set; }
    }

}
