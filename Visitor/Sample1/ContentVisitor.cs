namespace Visitor.Sample1
{
    //visitor
    public interface ContentVisitor
    {
        void Visit(Content content); 
    }
    //concrete visitor
    public class AddVisitor :ContentVisitor
    {
        public void Visit(Content content)
        {
            var data = content.Data;
            content.Data = data + 100;
        }
    }
    //concrete visitor
    public class MinusVisitor : ContentVisitor
    {
        public void Visit(Content content)
        {
            var data = content.Data;
            content.Data = data - 100;
        }
    }
}