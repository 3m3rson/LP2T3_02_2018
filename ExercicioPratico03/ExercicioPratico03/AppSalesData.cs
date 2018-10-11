namespace ExercicioPratico03
{
    class AppSalesData
    {
        private long appCode, companyId, downloads;
        private string appName, companyName, companyCountry;
        private double price;

        public AppSalesData()
        {

        }

        public AppSalesData(long appCode, long companyId, long downloads, string appName, string companyName, string companyCountry, double price)
        {
            this.AppCode = appCode;
            this.CompanyId = companyId;
            this.Downloads = downloads;
            this.AppName = appName;
            this.CompanyName = companyName;
            this.CompanyCountry = companyCountry;
            this.Price = price;
        }

        public long AppCode
        {
            get
            {
                return appCode;
            }

            set
            {
                appCode = value;
            }
        }

        public string AppName
        {
            get
            {
                return appName;
            }

            set
            {
                appName = value;
            }
        }

        public string CompanyCountry
        {
            get
            {
                return companyCountry;
            }

            set
            {
                companyCountry = value;
            }
        }

        public long CompanyId
        {
            get
            {
                return companyId;
            }

            set
            {
                companyId = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }

        public long Downloads
        {
            get
            {
                return downloads;
            }

            set
            {
                downloads = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}