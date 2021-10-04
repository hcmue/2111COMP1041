using Db4objects.Db4o;
using System;

namespace DB4__NetCore_8._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IObjectContainer db = Db4oEmbedded.OpenFile("pilotdb.yap");
            
            var pl1 = new Pilot(1, "Trần Văn Tèo", 1999);
            db.Store(pl1);

            var pl2 = new Pilot(2, "Trần Văn Tý", 199);
            db.Store(pl2);

            //QBE
            var template = new Pilot(0, null);
            IObjectSet<Pilot> result = db.QueryByExample<Pilot>(template);
            for(int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{result[i].Id} - {result[i].Name} - {result[i].Point}");
            }
            db.Close();
        }
    }
}
