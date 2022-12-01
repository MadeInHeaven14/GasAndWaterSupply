namespace GasAndWaterSupply.Data
{
    public class Project
    {
        public string Department { get; set; }
        public string Customer { get; set; }
        public string Developer { get; set; }
        public string Designer { get; set; }
        public List<Document> Documents { get; set; }
    }
}
