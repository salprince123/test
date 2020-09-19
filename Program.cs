
using System;
using System.Collections.Generic;

namespace test2
{
    
    
    class Program
    {
        public static QuanLy add(string key,QuanLy ql, string data)
        {
            switch(key)
            {
                case "sv":
                    {
                        if (ql.listSV == null)
                            ql.listSV = new List<SinhVien>();
                        ql.listSV.Add(new SinhVien(data, "cmd"));
                        break;
                    }
                case "gv":
                    {
                        if (ql.listGV == null)
                            ql.listGV = new List<GiaoVien>();
                        ql.listGV.Add(new GiaoVien(data, "cmd"));
                        break;
                    }
            }
            return ql;
        }
        static void Main(string[] args)
        {
            QuanLy ql = new QuanLy();
            ql.listSV = ql.importDataSV("D:\\LTTQ\\test2\\SV.txt");
            ql.listGV = ql.importDataGV("D:\\LTTQ\\test2\\GV.txt");
            /*Console.WriteLine(ql.find("sv", "9."));
            ql.exportData("sv", "D:\\LTTQ\\test2\\OutputSV.txt");
            ql.exportData("gv", "D:\\LTTQ\\test2\\OutputGV.txt");*/
            switch (args[0])
            {
                case "add":
                    {
                        string data = "";
                        for (int i = 2; i < args.Length - 1; i++)
                            data += args[i]+" ";
                        data += args[args.Length-1];
                        //Console.WriteLine(data);
                        ql = add(args[1], ql,data);
                        Console.WriteLine("add "+ args[1] + " sucessfully!");
                        break;
                    }
                case "find":
                    {                        
                        Console.WriteLine("find key word: "+ args[2] + " sucessfully!");
                        Console.WriteLine(ql.find(args[1], args[2]));
                        break;
                    }
                case "import":
                    {
                        if(args[1]=="gv")
                            ql.listGV=ql.importDataGV(args[2]);
                        if (args[1] == "sv")
                            ql.listSV = ql.importDataSV(args[2]);
                        Console.WriteLine("import sucessfully!");
                        break;
                    }
                case "export":
                    {
                        ql.exportData(args[1], args[2]);
                        Console.WriteLine("export sucessfully!");
                        break;
                    }
                default: Console.WriteLine("error");break;
            }

        }
    }
}
