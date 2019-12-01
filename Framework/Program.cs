using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var starttime = DateTime.Now;
            var stringlist = new List<string>();
            for (int i = 0; i < 5000000; i++)
            {
                stringlist.Add(JsonSerializer.Serialize(new Shared.DataModel
                {
                    ID = Guid.NewGuid(),
                    Counter = i + 1,
                    Name = $"name{new Random().Next(50000).ToString()}",
                    DateTime = DateTime.Now
                }));
            }
            var model = new List<Shared.DataModel>();
            foreach (var item in stringlist)
            {
                model.Add(JsonSerializer.Deserialize<Shared.DataModel>(item));
            }
            stringlist.Clear();
            model.Clear();
            //foreach (var item in model)
            //{
            //    Console.WriteLine($"no:{item.Counter}, id:{item.ID.ToString()}, name:{item.Name}, date:{item.DateTime.ToString()}.");
            //}
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedMilliseconds);
            Console.WriteLine($"{starttime.Hour}:{starttime.Minute}:{starttime.Second}:{starttime.Millisecond}");
            Console.ReadLine();
        }
    }
}
