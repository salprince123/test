using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace test2
{
    public class SinhVien
    {
        public String id { get; set; }
        public String name { get; set; }
        public String toan { get; set; }
        public String van { get; set; }
        public String anh { get; set; }

        public SinhVien()
        {
            id = name = toan = van = anh = "0";
        }
        public SinhVien(String id0, String name0, String toan0, String van0, String anh0)
        {
            id = id0;
            name = name0;
            toan = toan0;
            van = van0;
            anh = anh0;
        }
        public SinhVien(String full, String key)
        {
            List<String> element = new List<String>();
            switch(key)
            {
                case "cmd": element.AddRange(full.Split(" "));break;
                case "file": element.AddRange(full.Split("_")); break;
            }
            id = element[0];
            name = element[1];
            toan = element[2];
            van = element[3];
            anh = element[4];
        }
        public String toString()
        {
            return (id + " " + name + " " + toan + " " + van + " " + anh);
        }
        public String toStringFull()
        {
            String dtb = tinhDTB();
            return (id + " " + name + " " + toan + " " + van + " " + anh +  " "+dtb);
        }
        public String tinhDTB()
        {
            // make string to float and get average of them
            float dtb = (float.Parse(toan, CultureInfo.InvariantCulture.NumberFormat) + float.Parse(van, CultureInfo.InvariantCulture.NumberFormat) + float.Parse(anh, CultureInfo.InvariantCulture.NumberFormat)) / 3;
            String s = dtb.ToString();
            s = s.Substring(0, 3);
            return s;
        }

    }
}
