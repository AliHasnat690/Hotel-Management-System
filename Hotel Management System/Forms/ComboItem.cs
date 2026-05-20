using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System.Forms
{
    public class ComboItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ComboItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
