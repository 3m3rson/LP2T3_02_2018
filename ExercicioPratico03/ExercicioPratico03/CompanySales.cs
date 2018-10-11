namespace ExercicioPratico03
{
    public class CompanySales
    {
        private long id;
        private double totalRevenue;
        private string name, country;

        public long Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public double TotalRevenue
        {
            get
            {
                return totalRevenue;
            }

            set
            {
                totalRevenue = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public CompanySales(long id, double totalRevenue, string name, string country)
        {
            this.Id = id;
            this.TotalRevenue = totalRevenue;
            this.Name = name;
            this.Country = country;
        }
    }
}