using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLyQuanCafe.DTO;

namespace QuanLyQuanCafe
{
    public partial class frmTableManager : Form

    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Account loginAccount;

        public Account LoginAccount { get => loginAccount; set => loginAccount = value; }

        public frmTableManager(Account acc)
        {
            InitializeComponent();
            this.loginAccount = acc;

            // Kiểm tra loại tài khoản (Type)
            if (loginAccount.Type == 0) 
            {
                ibtnTaikhoan.Visible = false; 
            }
            else if (loginAccount.Type == 1) 
            {
                ibtnTaikhoan.Visible = true;
            }

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            OpenChildForm(new Trangchu());
        }

        // seting cho iconbutton bat tat
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                if (currentBtn != null)
                {
                    Console.WriteLine($"Current button: {currentBtn.Name}");
                }
                DisableButton();

                // Thiết lập nút hiện tại
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(128, 128, 128);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Cập nhật thanh viền trái
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        // bang doi mau
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 128, 0);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }// bang doi mau
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128, 64, 64); 
                currentBtn.ForeColor = Color.Gainsboro;             
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;  
                currentBtn.IconColor = Color.Gainsboro;           
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText; 
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft; 
            }
        }


        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       
        // click thi doi mau backcolor
        private void ibtnTrangchu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Trangchu());
            

        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
         
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
           
        }


        private void ibtnHoadon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Hoadon());
        }

        private void ibtnlistBan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Danhsachban());
        }

        private void ibtnThucdon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Thucdon());
        }

        private void ibtnDanhmuc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Danhmuc());
        }

        private void ibtnDoanhthu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Doanhthu());
        }

        private void ibtnTaikhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Taikhoan());
        }
        private void ibtnDangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void ibtnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
