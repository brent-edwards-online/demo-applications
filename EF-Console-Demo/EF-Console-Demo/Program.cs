using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace EF_Console_Demo
{
    class PlayList
    {
        public PlayList()
        {
            Videos = new List<Video>();
        }
        public int PlayListId { get; set; }
        public string Name { get; set; }

        public ICollection<Video> Videos { get; set; }
    }

    class Video
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class MeContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new MeContext())
            {
                var v = new Video() { Title = "Jack Reacher", Description = "Jack Reacher" };
                ctx.Videos.Add(v);
            }


            Console.WriteLine("Finished");
            Console.ReadKey();
        }
    }
}
