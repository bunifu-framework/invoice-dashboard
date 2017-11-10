using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_Bunifu_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bunifuFlatButton10.selected = true;
            //color for the areaStacked chart with High datapoints
            bunifuDataViz1.colorSet.Add(Color.FromArgb(228, 231, 250));
            //color for the Bunifu_Line
            bunifuDataViz1.colorSet.Add(Color.FromArgb(227, 245, 225));
            //color for the areaStacked chart with low datapoints
            bunifuDataViz1.colorSet.Add(Color.FromArgb(94, 110, 212));
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            //  (Bunifu.Framework.UI.BunifuFlatButton) sender 
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {


            bunifuTileButton1.color = Color.White;
            bunifuTileButton2.color = Color.White;
            bunifuTileButton3.color = Color.White;
            bunifuTileButton4.color = Color.White;
            bunifuTileButton5.color = Color.White;

            pictureBox2.Location = new Point(pictureBox2.Location.X, ((Bunifu.Framework.UI.BunifuTileButton)sender).Location.Y);
            ((Bunifu.Framework.UI.BunifuTileButton)sender).color = Color.FromArgb(251, 251, 253);
        }
        private void bunifuDataViz1_Load(object sender, EventArgs e)
        { }
        public void plotdata()
        {
           //create a new canvas for the charts
            var canvas = new Bunifu.DataViz.Canvas();
            //add datapoints of the two area charts(Bunifu_stackedArea_Chart)
            var datapoint_low = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea);
            var datapoint_high = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_stackedArea);
            datapoint_low.addLabely("Jan","100");
            datapoint_low.addLabely("Feb", "160");
            datapoint_low.addLabely("Mar", "155");
            datapoint_low.addLabely("Apr", "165");
            datapoint_low.addLabely("May", "205");
            datapoint_low.addLabely("Jun", "155");
            datapoint_low.addLabely("Jul", "120");
            datapoint_low.addLabely("Aug", "100");
            datapoint_low.addLabely("Sep", "130");
            datapoint_low.addLabely("Oct", "125");
            datapoint_low.addLabely("Nov", "150");
            datapoint_low.addLabely("Dec", "90");

            datapoint_high.addLabely("Jan","100");
            datapoint_high.addLabely("Feb","190");
            datapoint_high.addLabely("Mar","165");
            datapoint_high.addLabely("Apr","180");
            datapoint_high.addLabely("May","240");
            datapoint_high.addLabely("Jun","195");
            datapoint_high.addLabely("Jul","190");
            datapoint_high.addLabely("Aug","130");
            datapoint_high.addLabely("Sep","160");
            datapoint_high.addLabely("Oct","155");
            //add the datapoints  to the canvas
            canvas.addData(datapoint_low);
            canvas.addData(datapoint_high);
    
            //to the same canvas, create datapoints for Bunifu_line
            var bunifu_line_datapoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);

            bunifu_line_datapoint.addLabely("Jan", "100");
            bunifu_line_datapoint.addLabely("Feb", "160");
            bunifu_line_datapoint.addLabely("Mar", "155");
            bunifu_line_datapoint.addLabely("Apr", "165");
            bunifu_line_datapoint.addLabely("May", "205");
            bunifu_line_datapoint.addLabely("Jun", "155");
            bunifu_line_datapoint.addLabely("Jul", "120");
            bunifu_line_datapoint.addLabely("Aug", "100");
            bunifu_line_datapoint.addLabely("Sep", "130");
            bunifu_line_datapoint.addLabely("Oct", "125");
            bunifu_line_datapoint.addLabely("Nov", "150");
            bunifu_line_datapoint.addLabely("Dec", "90");

            //add those datapoints to the chart
            canvas.addData(bunifu_line_datapoint);

            //render canvas
            bunifuDataViz1.Render(canvas);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            plotdata();
            timer1.Stop();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           // plotdata();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel11_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataViz1_Load_1(object sender, EventArgs e)
        {

        }
    }
}

