using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        int SimdikiWidth = 2000;
        int SimdikiHeight = 1200;
        private void Form1_Load(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = false;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            Rectangle ClienCozunurluk = new Rectangle();
            ClienCozunurluk = Screen.GetBounds(ClienCozunurluk);
            float OranWidth = ((float)ClienCozunurluk.Width / (float)SimdikiWidth);
            float OranHeight = ((float)ClienCozunurluk.Height / (float)SimdikiHeight);
            this.Scale(new SizeF(OranWidth, OranHeight));
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            panelCustomersSubMenu.Visible = true;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = childForm; childForm.TopLevel = false; childForm.FormBorderStyle = FormBorderStyle.None; childForm.Dock = DockStyle.Fill; panelForm.Controls.Add(childForm); panelForm.Tag = childForm; childForm.BringToFront(); childForm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddCustomerForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm1 = null;
        private void openChildForm1(Form childForm1)
        {
            if (activeForm1 != null) { activeForm1.Close(); }
            activeForm1 = childForm1; childForm1.TopLevel = false;childForm1.FormBorderStyle = FormBorderStyle.None; childForm1.Dock = DockStyle.Fill; panelForm.Controls.Add(childForm1); panelForm.Tag = childForm1; childForm1.BringToFront(); childForm1.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm1(new mevcurmusteriler());
        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
