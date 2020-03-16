using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ShorashimSystem
{
    class PromoCodes
    {
        private string promoName;
        private string promoDescription;
        private DateTime promoStartDate;
        private double promoDiscountPercent;
        private DateTime promoEndDate;
        public System.Collections.Generic.List<Purchase> promoCodeInPurchase; //הכלה

        public PromoCodes(string promoName, string promoDescription, DateTime promoStartDate, double promoDiscountPercent, DateTime promoEndDate, bool is_new)
        {
            this.promoName = promoName;
            this.promoDescription = promoDescription;
            this.promoStartDate = promoStartDate;
            this.promoDiscountPercent = promoDiscountPercent;
            this.promoEndDate = promoEndDate;
            promoCodeInPurchase = new List<Purchase>();

            if (is_new == true)
            {
                this.createPromocode();
                Program.promoCodes.Add(this);


            }
        }

        public string getPromoName()
        {
            return this.promoName;
        }

        public string getPromoDescription()
        {
            return this.promoDescription;
        }
        public DateTime getPromoStartDate()
        {
            return this.promoStartDate;
        }

        public double getPromoDiscount()
        {
            return this.promoDiscountPercent;
        }

        public DateTime getPromoEndDate()
        {
            return this.promoEndDate;
        }

        public void createPromocode()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Add_Promo_Code @Promo_Code_Name, @Promo_Description, @Promo_Start_Date, @Promo_Discount_Percent,@Promo_End_Date";
            c.Parameters.AddWithValue("@Promo_Code_Name", this.promoName);
            c.Parameters.AddWithValue("@Promo_Description", this.promoDescription);
            c.Parameters.AddWithValue("@Promo_Start_Date", this.promoStartDate);
            c.Parameters.AddWithValue("@Promo_Discount_Percent", this.promoDiscountPercent);
            c.Parameters.AddWithValue("@Promo_End_Date", this.promoEndDate);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


    }
}
