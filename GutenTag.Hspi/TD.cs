using GutenTag;

namespace GutenTag.Hspi
{
    public class TD : Tag
    {
        public TD(TdClass tdClass, string value = null) : base("td")
        {
            Add("class", tdClass.Description());

            if (tdClass == TdClass.TableColumn)
            {
                Attributes["align"] = new TagProperty("center");
            }

            if (value != null)
            {
                Add(value);
            }


        }
    }
}