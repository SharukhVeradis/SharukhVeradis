

    class Program
    {

        static void Main(string[] args)
        {

            Order ObjOrder = new Order();

            ObjOrder.OrderNo = "123";
            ObjOrder.OrderValue = "1000";
            ObjOrder.OrederCountry = "India";

            ObjOrder.CreateOrder();
          
        }

        
    } 
    public class Order
    {
        public string OrderNo { get; set; }
        public string OrderValue { get; set; }
        public string OrederCountry { get; set; }

        public string CreateOrder()
        {
            validOrderValue();
            validOrderCountry();
            Console.WriteLine("Order Created For - " + OrderNo);
            // 
            return "Order Created";
        }
        private bool validOrderValue()
        {
            Console.WriteLine("Ordered Value - " + OrderValue);
            //
            return true;
        }

        private bool validOrderCountry()
        {
            Console.WriteLine("Ordered Country - " + OrederCountry);
            //
            return true;
        }
    }
