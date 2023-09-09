﻿using Solid_Principle.DIP;
using Solid_Principle.LSP;

namespace Solid_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Notification notification = new Notification();
            //notification.SendGmail();
            //notification.SendHotmail();

            Notification notification = new Notification(new Gmail());
            notification.SendGmail();




            //PostDatabase db = new PostDatabase();
            //List<string> newPosts = new List<string>();
            //newPosts.Add("original post");
            //newPosts.Add("#tag post");
            //newPosts.Add("@mention post");

            //Post postObj;
            //foreach (var post in newPosts)
            //{
            //    if (post.StartsWith("#"))
            //    {
            //        postObj = new TagPost();
            //    }
            //    else if (post.StartsWith("@"))
            //    {
            //        postObj = new MentionPost();
            //    }
            //    else
            //    {
            //        postObj = new Post();
            //    }

            //    string result = postObj.CreatePost(db,post);
            //    Console.WriteLine(result);
            //}
            Console.ReadKey();
        }
    }
}