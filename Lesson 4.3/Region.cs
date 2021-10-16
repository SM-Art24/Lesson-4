using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_4._3
{
    public class Region
    {
        public string Name;
        public int area;
        public TypePeople inregion;
        public Region(string Name, int area, TypePeople inregion)
        {
            this.Name = Name;
            this.area = area;
            this.inregion = inregion;
        }
    }
}
