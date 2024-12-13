namespace PollinationsLib
{
    public class TextPrompt
    {
        public required string Text { get; set; }
        public int Seed { get; set; }
        public string SystemBehavior { get; set; } = " ";
    }
}
