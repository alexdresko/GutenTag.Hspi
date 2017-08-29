using Guten;

namespace GutenTag.Hspi
{
    public class Div : Tag
    {
        public Div(string value = null, string id = null) : base("div")
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Add(value);
            }

            if (!string.IsNullOrWhiteSpace(id))
            {
                Add("id", id);
            }
        }
    }
}