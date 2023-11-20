using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Drawing;
using System.Runtime.InteropServices;

namespace DoAn_CSharp
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn; 
        private Panel leftBorderBtn;
        private Form currentChildForm;


        //Constructor 

        public FormMainMenu()
        {
            InitializeComponent();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        // private struct RGBColors

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95,77,221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);

        }
        
        //Methods

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn  != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                
                //Left border button

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon Current child Form

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
            
                currentBtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle  = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;


        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormQuanLyNhanVien());
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormQuanLyKhachHang());
        }

        private void btnQuanLyNhaCungCap_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormQuanLyNhaCungCap());
        }

        private void btnQuanLySanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormQuanLySanPham());
        }

        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormQuanLyDanhMuc());
        }

        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Forms.FormQuanLyHoaDon());
        }

        private void btnQuanLyNhapHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormQuanLyNhapHang());
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormBanHang());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormThongKe());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();

            Reset();

        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            lblTitleChildForm.Text = "HOME";
        }

        //Drag Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int WMsg , int wParam , int lParam);


        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxmize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; 

        }
    }
}
