using System;

namespace ObligatoriskeOpgave_sem._3
{
    public class Car
    {
        private int _id;
        private string _model;
        private int _price;
        private string _licensePlate;

        public Car(int id, string model, int price, string licensePlate)
        {
            

            Id=id;
            Model=model;
            Price=price;
            LicensePlate=licensePlate; 
        }

        public int Id
        {
            get => _id;
            set => _id = value;
            /*{
                if (_id != value)
                {

                    Id = value;
                } 
            }*/
        }

        public string Model
        {
            get => _model;
            set
            {
                if (value.Length >= 4)
                {
                    _model = value; 

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Price
        {
            get => _price;
            set
            {
                if (value > 0) 
                {
                    _price = value;
                }


                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public string LicensePlate
        {
            get => _licensePlate;
            set
            {
                if (value.Length >= 2 && value.Length <= 7)
                {
                    {
                        _licensePlate = value;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
