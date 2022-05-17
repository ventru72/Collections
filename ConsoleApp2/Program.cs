using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApp2
{
     
   class Program
   {
        static void Arr()
        {
            Console.WriteLine("\nАррр");
        }
        static void Seriliz( worker Seriliz_worker, string Path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(worker), Path);
            Stream fStream = new FileStream(Path, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fStream, Seriliz_worker);
            fStream.Close();
        }
         static void  Get_repository()
        {
            
            List_workers L_workers = new  List_workers();
            L_workers.list = new List<worker>();
            
            L_workers.list.Add (new worker("Том", "Круз", 26));
            L_workers.list.Add(new worker("Ильяс", "Дристович", 41));
            L_workers.list.Add(new worker("Наталья", "Григорьевна", 42));
            L_workers.list.Add(new worker("Антонио", "Бандересня", 36));
            foreach (worker worker in L_workers.list)
            {
               Console.WriteLine (worker.Print());
            }

            
        }
            static void Main(string[] args)
            {
            string Path = $@"E:\Sereliz.xml";
            worker Worker1 = new worker("Котлета ", "Пушистая", 26);
            Console.WriteLine(Worker1.Print());
            Get_repository();
            Seriliz(Worker1, Path); 
            Arr();
            Console.ReadLine();

            }

   }
     
}
  