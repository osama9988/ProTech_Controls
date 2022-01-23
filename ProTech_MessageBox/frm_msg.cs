using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ProTech_MessageBox
{
   
    public partial class frm_msg : Form
    {

        public frm_msg(string text, bool is_right, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.lbl_caption.Text = "";
            this.isRight = is_right;
            this.MessageBoxButtons = buttons;

        }
        public frm_msg(string text, string caption, bool is_right, MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.lbl_caption.Text = caption;
            this.isRight = is_right;
            this.MessageBoxButtons = buttons;
           
        }
        public enum buttons_count
        {
            btn1 = 1,
            btn2 = 2,
            btn3 = 3
        };

         public enum buttons_type
        {
            OK=0,
            OkCancel = 1,
            OkCancelRety = 2,
            YseNo = 3,
            YseNoRetry = 4,

        };

        //prop
        public bool isRight;
        public buttons_count btn_count1;
        private MessageBoxButtons MessageBoxButtons;
      

        public bool IsRight
        {
            get => isRight;
            set
            {
                isRight = value;
                btn_ar.Visible = isRight;
                btn_en.Visible = !isRight;
                pnl_buttons.RightToLeft = (isRight) ? RightToLeft.Yes : RightToLeft.No;
            }
        }

        public buttons_count Btn_count1
        {
            get => btn_count1;
            set
            {
                btn_count1 = value;

                
            }

        }



        public MessageBoxButtons MessageBoxButtons1
        {
            get => MessageBoxButtons;
            set
            {
                MessageBoxButtons = value;
                if ((MessageBoxButtons == MessageBoxButtons.OK) )
                    Btn_count1 = buttons_count.btn1;

                if ((MessageBoxButtons == MessageBoxButtons.YesNo )|| (MessageBoxButtons == MessageBoxButtons.OKCancel) )
                    Btn_count1 = buttons_count.btn2;

                if ((MessageBoxButtons == MessageBoxButtons.AbortRetryIgnore))
                    Btn_count1 = buttons_count.btn3;
            }
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public frm_msg()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        public frm_msg(bool is_rtl, string text, string caption, buttons_type _Type )
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            textBox1.BackColor = this.BackColor;
            //
            set_rtl(is_rtl);
            textBox1.Text = text;
            set_buttons(is_rtl, _Type);
            lbl_caption.Text = caption;
        }

        public frm_msg(bool is_rtl, string text, string caption)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            textBox1.BackColor = this.BackColor;
            //
            set_rtl(is_rtl);
            textBox1.Text = text;
            set_buttons(is_rtl, buttons_type.OK);
            lbl_caption.Text = caption;
        }

        public  frm_msg(bool is_rtl, string text)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
            textBox1.BackColor = this.BackColor;
            //
            set_rtl(is_rtl);
            textBox1.Text = text;
            set_buttons(is_rtl, buttons_type.OK);
        }

        private void set_buttons(bool _is_rtl, buttons_type _Type)
        {
            int xCenter = (this.pnl_buttons.Width - btn1.Width) / 2;
            int yCenter = (this.pnl_buttons.Height - btn1.Height) / 2;

            if (_Type == buttons_type.OK)
            {
                btn1.Visible = true;
                btn1.Location = new Point(xCenter, yCenter);
                btn1.ImageAlign = (_is_rtl) ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
                btn1.DialogResult = DialogResult.OK;
                btn1.Text = str_ok(_is_rtl);
                btn1.IconColor = btn1.ForeColor = Color.DarkGreen;
            }

            if (_Type == buttons_type.OkCancel)
            {
                btn1.Visible = btn2.Visible = true;
                //OK Button
                btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                //Cancel Button
                btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                btn1.ImageAlign = btn2.ImageAlign = (_is_rtl) ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;

                if (_is_rtl)
                {
                    btn1.DialogResult = DialogResult.Cancel;
                    btn1.Text = str_cancel(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.Ban;
                    btn1.IconColor = btn1.ForeColor = Color.DarkRed;
                    //
                    btn2.DialogResult = DialogResult.OK;
                    btn2.Text = str_ok(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn2.IconColor = btn2.ForeColor = Color.DarkGreen;
                }
                else
                {

                    btn1.DialogResult = DialogResult.OK;
                    btn1.Text = str_ok(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn1.IconColor = btn1.ForeColor = Color.DarkGreen;
                    //
                    btn2.DialogResult = DialogResult.Cancel;
                    btn2.Text = str_cancel(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.Ban;
                    btn2.IconColor = btn2.ForeColor = Color.DarkRed;
                }

            }

            if (_Type == buttons_type.OkCancelRety)
            {
                btn1.Visible = btn2.Visible = btn3.Visible = true;

                //btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                //btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                //btn3.Location = new Point(xCenter + btn2.Width + 5, yCenter);

                btn1.ImageAlign = btn2.ImageAlign = btn3.ImageAlign = (_is_rtl) ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;

                if (_is_rtl)
                {
                    
                    btn1.DialogResult = DialogResult.Retry;
                    btn1.Text = str_Retry(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.Redo;
                    btn1.IconColor = btn1.ForeColor = Color.DarkOrange;
                    //
                    btn2.DialogResult = DialogResult.Cancel;
                    btn2.Text = str_cancel(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.Ban;
                    btn2.IconColor = btn2.ForeColor = Color.DarkRed;
                    //
                    btn3.DialogResult = DialogResult.OK;
                    btn3.Text = str_ok(_is_rtl);
                    btn3.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn3.IconColor = btn3.ForeColor = Color.DarkGreen;

                }
                else
                {

                    btn1.DialogResult = DialogResult.OK;
                    btn1.Text = str_ok(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn1.IconColor = btn1.ForeColor = Color.DarkGreen;
                    //
                    btn2.DialogResult = DialogResult.Cancel;
                    btn2.Text = str_cancel(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.Ban;
                    btn2.IconColor = btn2.ForeColor = Color.DarkRed;
                    //
                    btn3.DialogResult = DialogResult.Retry;
                    btn3.Text = str_Retry(_is_rtl);
                    btn3.IconChar = FontAwesome.Sharp.IconChar.Redo;
                    btn3.IconColor = btn3.ForeColor = Color.DarkOrange;
                }

            }

            if (_Type == buttons_type.YseNo)
            {
                btn1.Visible = btn2.Visible = true;
                //OK Button
                btn1.Location = new Point(xCenter - (btn1.Width / 2) - 5, yCenter);
                //Cancel Button
                btn2.Location = new Point(xCenter + (btn2.Width / 2) + 5, yCenter);
                btn1.ImageAlign = btn2.ImageAlign = (_is_rtl) ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;

                if (_is_rtl)
                {
                    btn1.DialogResult = DialogResult.No;
                    btn1.Text = str_no(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    btn1.IconColor = btn1.ForeColor = Color.DarkRed;
                    
                    //
                    btn2.DialogResult = DialogResult.Yes;
                    btn2.Text = str_yes(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn2.IconColor = btn2.ForeColor = Color.DarkGreen;
                }
                else
                {

                    btn1.DialogResult = DialogResult.Yes;
                    btn1.Text = str_yes(_is_rtl);
                    btn1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    btn1.IconColor = btn1.ForeColor = Color.DarkGreen;
                    //
                    btn2.DialogResult = DialogResult.No;
                    btn2.Text = str_no(_is_rtl);
                    btn2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    btn2.IconColor = btn2.ForeColor = Color.DarkRed;
                }

            }


        }

        private string str_ok(bool is_rtl)
        {
            return (is_rtl) ? "حسنا" : "Ok";
        }
        private string str_cancel(bool is_rtl)
        {
            return (is_rtl) ? "إلغاء" : "Cancel";
        }

        private string str_Retry(bool is_rtl)
        {
            return (is_rtl) ? "إعادة المحاولة" : "Retry";
        }

        private string str_yes(bool is_rtl)
        {
            return (is_rtl) ? "نعم" : "Yes";
        }

        private string str_no(bool is_rtl)
        {
            return (is_rtl) ? "لا" : "No";
        }

        private void set_rtl(bool _is_rtl)
        {
            btn_ar.Visible = _is_rtl;
            btn_en.Visible = !_is_rtl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.IsRight = true;
            //this.MessageBoxButtons1 = MessageBoxButtons.YesNo;
           
        }

        #region -> Drag Form
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        #endregion

        private void btn_en_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
