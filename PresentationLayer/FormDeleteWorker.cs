using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class FormDeleteWorker : Form
    {
        private WorkerBL workerBL;
        public FormDeleteWorker()
        {
            InitializeComponent();
            workerBL = new WorkerBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            DialogResult result = MessageBox.Show("Xoa nhan vien?",
                        "xac nhan xoa?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Gọi hàm xóa từ DataLayer
                    int numOfRows = workerBL.DeleteWorker(id);
                    if (numOfRows > 0)
                    {
                        MessageBox.Show("Xoa thanh cong!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Khong tim thay nhan vien voi Id tren!", "Thong bao");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
