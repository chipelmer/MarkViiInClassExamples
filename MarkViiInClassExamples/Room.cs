using System;
using System.Collections.Generic;
using System.Text;

namespace MarkViiInClassExamples
{
    class Room
    {
        public Room(string name, House containingHouse)
        {
            Name = name;
            containingHouse.Rooms.Add(this);
        }

        public string Name { get; set; }
        public int NumberOfWindows { get; set; }
        public string Description { get; set; }
    }
}
