using System.ComponentModel;

namespace GutenTag.Hspi
{
    public enum TdClass
    {
        [Description("tablecolumn")]
        TableColumn,
        [Description("tablecell")]
        TableCell,
        [Description("tableheader")]
        TableHeader
    }
}