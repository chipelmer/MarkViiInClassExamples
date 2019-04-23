using System;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Room kitchen = new Room("kitchen", house);
            kitchen.NumberOfWindows = 2;
            kitchen.Description = "It is clean and has granite countertops.";

            Room diningRoom = new Room("dining room", house);
            diningRoom.NumberOfWindows = 4;
            diningRoom.Description = "It has hardwoods and a large chandelier.";

            Room livingRoom = new Room("living room", house);
            livingRoom.NumberOfWindows = 2;
            livingRoom.Description = "It has carpet and a vaulted ceiling.";

            Room masterBedroom = new Room("master bedroom", house);
            masterBedroom.NumberOfWindows = 2;
            masterBedroom.Description = "It has carpet and a ceiling fan.";

            Realtor realtor = new Realtor();
            Visitor visitor = new Visitor();

            realtor.WelcomeVisitor(visitor);
            
            foreach (Room room in house.Rooms)
            {
                realtor.ShowRoom(room);
            }
        }
    }
}
