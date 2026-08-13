using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace assimentoop2
{
    public class Shipment
    {
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;

        public string TrackingCode
        {
            get
            {
                return TrackingCode;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    (
                        Console.WriteLine("TrackingCode cannot be empty.");
                }

                TrackingCode = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
      Console.WriteLine("Description cannot be empty.");
                }

                description = value;
            }
        }

        
        public decimal Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine(
                        "Weight must be greater than 0.");
                }

                weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }

            private set
            {
                if (value <= 0)
                {
  Console.WriteLine("Delivery fee cannot be negative.");
                }

                deliveryFee = value;
            }
        }


        public DeliveryAddress Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;

            Destination = new DeliveryAddress(
                "Unknown",
                "Unknown",
                0
            );
        }

        public Shipment(
            string trackingCode,
            string description,
            decimal weight,
            decimal deliveryFee,
            DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public virtual void PrintShipment()
        {
            Console.WriteLine("Tracking Code: " + TrackingCode);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Delivery Fee: " + DeliveryFee);

            Console.WriteLine(
                "Destination: " +
                Destination.GetFullAddress());

            Console.WriteLine(
                "Estimated Cost: " +
                EstimatedCost);
        }

    }
}
