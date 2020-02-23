using Enumerations;
using NonMotorizedVehicles;


namespace Structures
{
    public struct Tricycle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        private bool isMoving;
        public bool Moving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
        public bool Moving()
        {
            return Moving(this.isMoving);
        }
    }

    public struct Bicycle 
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get; set; }
        private bool isMoving;
        public bool Moving(bool isMoving)
        {
            this.isMoving = isMoving;
            return this.isMoving;
        }
        public bool Moving()
        {
            return Moving(this.isMoving);
        }
    }

}
