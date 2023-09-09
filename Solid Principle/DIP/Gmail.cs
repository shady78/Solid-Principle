namespace Solid_Principle.DIP
{
    public class Gmail : IMessage
    {
        public string Addres = "addresses";
        public string from = "from mail";
        public string ToAddress = "ToAddress";

        public void Send() { /* code */}
    }
}