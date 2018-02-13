using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtCE.Copier
{
    public class ObjectCopier
    {
        public void CopyObject(TextBox textBox)
        {
            if (textBox.SelectionLength > 0)
                textBox.Copy();


        }
    }
}
