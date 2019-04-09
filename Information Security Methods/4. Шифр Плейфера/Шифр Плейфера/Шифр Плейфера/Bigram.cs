namespace Øטפנ_Ïכויפונא
{
    public class Bigram
    {
        public string FirstLetter { get; set; }

        public string SecondLetter { get; set; }

        public override string ToString()
        {
            return this.FirstLetter + " " + this.SecondLetter;
        }
    }
}