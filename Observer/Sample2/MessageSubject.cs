using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Observer.Sample2
{
    public class Post
    {
        public string Message { get; set; }
    }

    public class PostMessageEventArgs : EventArgs
    {
        public Post Post { get; set; }
    }
    public class MessageSubject
    {
        public void onPublisher(Post post)
        {
            MessagePublisher?.Invoke(this,
                new PostMessageEventArgs{ Post =new Post{ Message = post.Message } });
        }
        public event EventHandler<PostMessageEventArgs> MessagePublisher;
    }
   
}
