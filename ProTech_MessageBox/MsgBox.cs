using ProTech_MessageBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProTech_MessageBox.frm_msg;

namespace ProTech_Controls
{
    public abstract class ProTechMessageBox
    {
        public static DialogResult Show(bool is_right,string text)
        {
            DialogResult result;
            using (var msgForm = new frm_msg(is_right, text))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Show(bool is_right, string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new frm_msg(is_right, text, caption))
                result = msgForm.ShowDialog();
            return result;
        }

        public static DialogResult Show(bool is_right, string text, string caption, buttons_type _Type)
        {
            DialogResult result;
            using (var msgForm = new frm_msg(is_right, text, caption , _Type))
                result = msgForm.ShowDialog();
            return result;
        }
    }
}
