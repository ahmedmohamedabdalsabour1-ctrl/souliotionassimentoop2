using System;
using System.Collections.Generic;
using System.Text;

namespace assimentoop2
{
    public class DeliveryCenter
    {
        public string CenterName;
        private Shipment[] shipments = new Shipment[20];
        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                {
                    return null;
                }

                return shipments[index];
            }
            set
            {
                if (index < 0 || index >= shipments.Length)
                {
                    return;
                }

                shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null &&
                        shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return null;
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            Console.WriteLine(CenterName );

            bool found = false;

            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    found = true;

                    Console.WriteLine();
                    shipments[i].PrintShipment();
                }
            }

            if (!found)
            {
                Console.WriteLine("No shipments found.");
            }
        }
    

}
}
