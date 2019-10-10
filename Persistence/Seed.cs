using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
       public static void SeedData(DataContext context)
{
    if (!context.Posts.Any())
    {
        var Posts = new List<Post>
        {
            new Post {
                Title = "First post!",
                Date = DateTime.Now.AddDays(-10),
                Body = "Lorem ipsum dolor sit amet, and the stuff with the thing and the doodads eat the pudding sonny."
},
new Post {
    Title = "This is my second post.",
    Date = DateTime.Now.AddDays(-7),
    Body = "Sed ut perspiciatis unde omnis iste natus error sit volaptatum."
},
new Post {
    Title = "Another day, another post",
    Date = DateTime.Now.AddDays(-4),
    Body = "But I must explain to you how all this mistaken idea of denouncing pleasure and ."
}
        };

context.Posts.AddRange(Posts);
context.SaveChanges();
    }
}
    }
}