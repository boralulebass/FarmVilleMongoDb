namespace FarmVille.UI.Settings
{
    public interface IDatabaseSettings
    {
        public string HomeCollectionName { get; set; }
        public string AboutUsCollectionName { get; set; }
        public string StatisticCollectionName { get; set; }
        public string EmployeeCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
