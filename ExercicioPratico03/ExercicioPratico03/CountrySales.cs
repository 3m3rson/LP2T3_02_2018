namespace ExercicioPratico03
{
    public class CountrySales
    {
        private double totalRevenue;
        private string name;

        public CountrySales(string name, double totalRevenue)
        {
            this.TotalRevenue = totalRevenue;
            this.Name = name;
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


    }
}