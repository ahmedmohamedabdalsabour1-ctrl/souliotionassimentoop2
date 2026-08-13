namespace assimentoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region one 
            /*
             * class refrance type   large object   use null       inheritance     
             * struct value type     small object   not use null   notinheritance
             * Classes are more suitable for large applications because they are better for complex objects
             * support encapsulation and shared references 
             * and allow objects to be modified through multiple references
             * Structs are better for small
             * simple data values*/
            #endregion
            #region two
            /*
             *a) Parent class Shipment
             * b)Child class ExpressShipment
             *c)inherint TrackingCode
             * d)Inheritance allows code reuse, reduces code duplication, and makes the program easier to maintain and extend.
             */
            #endregion
            // =========================
            // 1. Create Delivery Center
            // =========================

            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();

            DeliveryCenter center =
                new DeliveryCenter();

            center.CenterName = centerName;


            // =========================
            // 2. Standard Shipment
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== Standard Shipment =====");

            Console.Write("Tracking Code: ");
            string tracking1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight1 =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 =
                int.Parse(Console.ReadLine());

            DeliveryAddress address1 =
                new DeliveryAddress(
                    city1,
                    street1,
                    building1);

            StandardShipment standard =
                new StandardShipment(
                    tracking1,
                    description1,
                    weight1,
                    fee1,
                    address1);


            // =========================
            // 3. Express Shipment
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== Express Shipment =====");

            Console.Write("Tracking Code: ");
            string tracking2 = Console.ReadLine();

            Console.Write("Description: ");
            string description2 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight2 =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee2 =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city2 = Console.ReadLine();

            Console.Write("Street: ");
            string street2 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building2 =
                int.Parse(Console.ReadLine());

            Console.Write("Extra Fee: ");
            decimal extraFee =
                decimal.Parse(Console.ReadLine());

            DeliveryAddress address2 =
                new DeliveryAddress(
                    city2,
                    street2,
                    building2);

            ExpressShipment express =
                new ExpressShipment(
                    tracking2,
                    description2,
                    weight2,
                    fee2,
                    address2,
                    extraFee);


            // =========================
            // 4. International Shipment
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== International Shipment =====");

            Console.Write("Tracking Code: ");
            string tracking3 = Console.ReadLine();

            Console.Write("Description: ");
            string description3 = Console.ReadLine();

            Console.Write("Weight: ");
            decimal weight3 =
                decimal.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee3 =
                decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city3 = Console.ReadLine();

            Console.Write("Street: ");
            string street3 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building3 =
                int.Parse(Console.ReadLine());

            Console.Write("Destination Country: ");
            string country =
                Console.ReadLine();

            Console.Write("Customs Fee: ");
            decimal customsFee =
                decimal.Parse(Console.ReadLine());

            DeliveryAddress address3 =
                new DeliveryAddress(
                    city3,
                    street3,
                    building3);

            InternationalShipment international =
                new InternationalShipment(
                    tracking3,
                    description3,
                    weight3,
                    fee3,
                    address3,
                    country,
                    customsFee);


            // =========================
            // 5. Add Shipments
            // =========================

            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            // =========================
            // 6. Print All Shipments
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== All Shipments =====");

            center.PrintAllShipments();


            // =========================
            // 7. Search
            // =========================

            Console.WriteLine();
            Console.Write("Enter Tracking Code to search: ");

            string searchCode =
                Console.ReadLine();

            Shipment found =
                center[searchCode];

            if (found != null)
            {
                Console.WriteLine();
                Console.WriteLine("Shipment Found:");
                found.PrintShipment();
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }


            // =========================
            // 8. Remove Shipment
            // =========================

            Console.WriteLine();
            Console.Write("Enter Tracking Code to remove: ");

            string removeCode =
                Console.ReadLine();

            bool removed =
                center.RemoveShipment(removeCode);

            if (removed)
            {
                Console.WriteLine(
                    "Shipment removed successfully.");
            }
            else
            {
                Console.WriteLine(
                    "Shipment not found.");
            }


            // =========================
            // 9. Print Remaining
            // =========================

            Console.WriteLine();
            Console.WriteLine("===== Remaining Shipments =====");

            center.PrintAllShipments();

        }
    }
}
