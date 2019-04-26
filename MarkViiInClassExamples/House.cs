using System;
using System.Collections.Generic;
using System.Text;

namespace MarkViiInClassExamples
{
    class House
    {
        public House()
        {
            Rooms = new List<Room>();
        }

        public List<Room> Rooms { get; set; }
    }
}
