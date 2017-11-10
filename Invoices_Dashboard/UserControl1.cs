using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Bunifu_UI
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //add five rows to the BunifuCustomDataGrid
            bunifuCustomDataGrid1.Rows.Add("Send", "10.11.2016", "59", "Coca-Cola", "12,300.00$");
            bunifuCustomDataGrid1.Rows.Add("Send", "13.09.2016", "56", "Philips", "18.450,00$");
            bunifuCustomDataGrid1.Rows.Add("Draft", "10.11.2016", "52", "Volkswagen", "5,600.00$");
            bunifuCustomDataGrid1.Rows.Add("Send", "10.11.2016", "51", "Gucci", "6,890.00$");
            bunifuCustomDataGrid1.Rows.Add("Draft", "10.11.2016", "49", "Nike", "1800.00$");

            //set the color of our first column in every row to different colors and the forecolor to white
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[0].Cells[0]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[0].Cells[0]).Style.BackColor = Color.FromArgb(118, 204, 117);
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[0].Cells[0]).Style.ForeColor = Color.White;

            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[1].Cells[0]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[1].Cells[0]).Style.BackColor = Color.FromArgb(118, 204, 117);
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[1].Cells[0]).Style.ForeColor = Color.White;

            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[2].Cells[0]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[2].Cells[0]).Style.BackColor = Color.FromArgb(110, 108, 219);
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[2].Cells[0]).Style.ForeColor = Color.White;

            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[3].Cells[0]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[3].Cells[0]).Style.BackColor = Color.FromArgb(118, 204, 117);
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[3].Cells[0]).Style.ForeColor = Color.White;

            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[4].Cells[0]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[4].Cells[0]).Style.BackColor = Color.FromArgb(110, 108, 219);
            ((DataGridViewButtonCell)bunifuCustomDataGrid1.Rows[4].Cells[0]).Style.ForeColor = Color.White;

            bunifuCustomDataGrid1.ClearSelection();

            
            //create a for loop thats sets the odd rows color to White and the even rows color to a different color
            for (int i = 0; i < bunifuCustomDataGrid1.Rows.Count; i++)
            {
                // odd rows
                if (i % 2 != 0)
                {
                    bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }
                // even rows
                else
                {
                    bunifuCustomDataGrid1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 247, 252);
                }
            }

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
