using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigClipboard.Models
{
    public class ClipboardData
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        public ClipboardDataType Type { get; set; }
        public TextDataFormat Format { get; set; }
        public object Data { get; set; }
    }
}
