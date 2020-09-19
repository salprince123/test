using System;
using System.Collections.Generic;
using System.Text;

namespace test2
{
    public class GiaoVien
    {
        public String id { get; set; }
        public String name { get; set; }
        
        public GiaoVien()
        {
            id = name = "0";
        }
        public GiaoVien(String id0, String name0)
        {
            id = id0;
            name = name0;
        }
        public GiaoVien(String full)
        {
            List<String> element = new List<String>();
            element.AddRange(full.Split("_"));
            id = element[0];
            name = element[1];
        }
        public String toString()
        {
            return (id + " " + name );
        }
    }

}
