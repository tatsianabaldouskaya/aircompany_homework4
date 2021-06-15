using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;

        public PassengerPlane(Plane plane, int passengersCapacity)
            :base(_model, _maxSpeed, _maxFlightDistance, _maxLoadCapacity)
  
        {
            _passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            var passengerPlane = obj as PassengerPlane;
            return passengerPlane != null &&
                   base.Equals(obj) &&
                   _passengersCapacity == passengerPlane._passengersCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = 751774561;
            hashCode *= -1521134295 + base.GetHashCode();
            hashCode *= -1521134295 + _passengersCapacity.GetHashCode();
            return hashCode;
        }

        public int GetPassengersCapacity()
        {
            return _passengersCapacity;
        }

       
        public override string ToString()
        {
            return base.ToString().Replace("}",", passengersCapacity=" + _passengersCapacity +'}');
        }       
        
    }
}
