using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MilenWebSite.Models
{
    public static class TVData
    {

        static TVData()
        {
            TVs = Read();
        }

        public static List<TV> GetAll()
        {
            return TVs;
        }


        public static void Add(TV tv)
        {
            tv.id = TVs.Count;
            TVs.Add(tv);
            Save();
        }

        public static void Delete(int id)
        {
            TVs.Remove(TVs.First(tv => tv.id == id));
            Save();
        }
        public static void Save()
        {
            using (StreamWriter writer = new StreamWriter("./data.txt"))

                foreach (var tv in TVs)
                {
                    writer.Write($"{tv.Name}|{tv.Image}|{tv.id}&|&");
                }
        }
        private static List<TV> Read()
        {
            var tvs = new List<TV>();
            if (File.Exists("./data.txt"))
            {
                using (StreamReader reader = new StreamReader("./data.txt"))
                {
                    string[] tvsRead = reader.ReadToEnd().Split("&|&");

                    foreach (var tv in tvsRead)
                    {
                        var data = tv.Split("|");
                        var newTv = new TV();
                        if (data.Length > 2)
                        {
                            newTv.Name = data[0];
                            newTv.Image = data[1];
                            newTv.id = int.Parse(data[2]);
                            tvs.Add(newTv);
                        }
                    }
                }

            }


            return tvs;
        }

        public static List<TV> TVs { get; set; }
    }
}
