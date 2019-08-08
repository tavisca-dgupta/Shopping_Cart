namespace Shopping.com
{
    public class CartDiscount
    {
        public int GetDiscount(int cartValue)
        {
            if (cartValue <= 1000)
            {
                return 5;
            }
            else if (cartValue <= 2000)
            {
                return 10;
            }
            else 
            {
                return 15;
            }
            
        }
    }
}
