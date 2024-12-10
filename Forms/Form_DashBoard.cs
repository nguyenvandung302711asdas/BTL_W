using DONGHO.Forms;
using DONGHO.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Form_DashBoard : Form
    {
        public string ReceivedData_Name { get; set; }
        public string ReceivedData_Role { get; set; }

        int PanelWidth;
        bool isCollapsed;
        public Form_DashBoard()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void Form_DashBoard_Load(object sender, EventArgs e)
        {
            lblQuyen.Text = ReceivedData_Role; // Hiển thị dữ liệu nhận được
            lblName.Text = ReceivedData_Name;
        }


        private void BtnBanSP_Click(object sender, EventArgs e)
        {

            if(lblQuyen.Text == "Quản trị viên")
            {
                moveSidePanel(btnBanSP);
                uc_BanSP ucB = new uc_BanSP();
                AddControlsToPanel(ucB);
            }
            else
            {
                //MessageBox.Show("Chỉ có quản trị viên mới được truy cập");
                Form_ThongBao f = new Form_ThongBao();
                f.lblThongBao.Text = "Chỉ có Quản trị viên mới có thể truy cập";
               f.ShowDialog();
            }

          
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 20;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 20;
                if (panelLeft.Width <= 80)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }


        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }


        //su kien dan den control



        private void BtnSanPham_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSanPham);
            uc_SanPham ucP = new uc_SanPham();
            AddControlsToPanel(ucP);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCaiDat);
            uc_CaiDat ucC = new uc_CaiDat();
            AddControlsToPanel(ucC);
        }

      
    }
}
