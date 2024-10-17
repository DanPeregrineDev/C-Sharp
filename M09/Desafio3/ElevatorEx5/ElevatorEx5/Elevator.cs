namespace ElevatorEx5
{
    public class Elevator
    {
        // Properties
        private int currentFloor;
        private int totalFloors;
        private int maxCapacity;
        private int currentPeopleInside;
        
        // Gets
        
        public int GetCurrentFloor() { return currentFloor; }
        public int GetTotalFloors() { return totalFloors; }
        public int GetMaxCapacity() { return maxCapacity; }
        public int GetCurrentPeopleInside() { return currentPeopleInside; }
    
        // Constructor
        public Elevator(int maxCapacity, int totalFloors)
        {
            this.maxCapacity = maxCapacity;
            this.totalFloors = totalFloors;
        
            this.currentFloor = 0;
            this.currentPeopleInside = 0;
        }
    
        // Methods

        public void AddPerson(Elevator elevator)
        {
            if (elevator.currentPeopleInside + 1 <= elevator.maxCapacity)
            {
                elevator.currentPeopleInside ++;
            }
        }

        public void RemovePerson(Elevator elevator)
        {
            if (elevator.currentPeopleInside >= 1)
            {
                elevator.currentPeopleInside --;
            }
        }

        public void IncreaseFloor(Elevator elevator)
        {
            if (elevator.currentFloor + 1 <= elevator.totalFloors)
            {
                elevator.currentFloor ++;
            }
        }

        public void DecreaseFloor(Elevator elevator)
        {
            if (elevator.currentFloor >= 1)
            {
                elevator.currentFloor --;
            }
        }

    }
}