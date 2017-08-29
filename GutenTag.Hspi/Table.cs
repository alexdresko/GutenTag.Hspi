using Guten;

namespace GutenTag.Hspi
{
    public class Table : Tag
    {
        public Table(TableClass tableClass) : base("table")
        {
            Add("class", tableClass.Description());
        }
    }
}