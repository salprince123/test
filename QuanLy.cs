using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace test2
{
    
    public class QuanLy
    {
        public List<SinhVien> listSV;
        public List< GiaoVien> listGV;
        public QuanLy()
        {
            listSV = new List<SinhVien>();
            listGV = new List<GiaoVien>();
        }
        public List<SinhVien> importDataSV(String path)
        {
            List<SinhVien> listSV = new List<SinhVien>();
            if (File.Exists(path))
            {
                String[] s = File.ReadAllLines(path);
                for (int i = 0; i < s.Length; i++)
                {
                    SinhVien a = new SinhVien(s[i],"file");
                    listSV.Add(a);
                }
            }
            return listSV;
        }
        public List<GiaoVien> importDataGV(String path)
        {
            List<GiaoVien> listGV = new List<GiaoVien>();
            if (File.Exists(path))
            {
                String[] s = File.ReadAllLines(path);
                for (int i = 0; i < s.Length; i++)
                {
                    GiaoVien a = new GiaoVien(s[i]);
                    listGV.Add(a);
                }
            }
            return listGV;
        }
        public void exportData(String key, String path)
        {
            if (!File.Exists(path))
            {
                var myFile =File.Create(path);
                myFile.Close();
            }
            File.WriteAllText(path, this.toString(key));
        }
        public String toString(String key)
        {
            String result = "";
            switch (key)
            {
                case "sv":
                    {
                        if (listSV != null)
                        {
                            for (int i = 0; i < this.listSV.Count - 1; i++)
                                result += listSV[i].toStringFull() + "\n";
                            result += listSV[listSV.Count - 1].toStringFull();
                        }
                    }
                    break;
                case "gv":
                    {
                        if (listGV != null)
                        {
                            for (int i = 0; i < this.listGV.Count - 1; i++)
                                result += listGV[i].toString() + "\n";
                            result += listGV[listGV.Count - 1].toString();
                        }
                    }
                    break;
            }
            return result;
        }
        public void display(String key)
        {
            switch(key)
            {
                case "SV":
                    {
                        //Console.WriteLine(listSV.Count);
                        foreach (SinhVien s in this.listSV)
                        {
                            Console.WriteLine(s.toStringFull());
                        }
                    }break;
                case "GV":
                    {
                        foreach (GiaoVien s in this.listGV)
                        {
                            Console.WriteLine(s.toString());
                        }
                    }
                    break;
                
            }
        }
        public String find(String key, String findingKeyWord)
        {
            String result="";
            switch(key)
            {
                case "sv":
                    {
                        if (listSV != null)
                        {
                            for (int i = 0; i < this.listSV.Count; i++)
                                if (listSV[i].toString().Contains(findingKeyWord))
                                    result += listSV[i].toString() + "\n";
                        }
                        break;
                    }
                case "gv":
                    {
                        if (listGV != null)
                        {
                            for (int i = 0; i < this.listGV.Count; i++)
                                if (listGV[i].toString().Contains(findingKeyWord))
                                    result += listGV[i].toString() + "\n";
                        }
                        break;
                    }
            }

            return result;
        }
        
        public String selectTop(String key, int number)
        {
            String result = "";
            return result;
        }
    }
}
