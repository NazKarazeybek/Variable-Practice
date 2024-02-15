using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Variable_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hockeyButton_Click(object sender, EventArgs e)
        {
            string playerName = "Wayne Gretzky";
            int playerNumber = 99;


            outputLabel.Text = $"{playerName} is number {playerNumber}";


        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            double radius = 15;
            double pi = 3.14;
            double area = radius * radius * pi;

            outputLabel.Text = $"The area of the circle with a raidus of {radius}cm is {area}cm^2";
        }

        private void carpetButton_Click(object sender, EventArgs e)
        {
            double length = 8.5;
            double width = 6;
            double costPerMeter = 19.95;
            double area = length * width;
            double totalCost = area * costPerMeter;

            outputLabel.Text = $"The area of the room with dimensions {length}m x {width}m is {area}m^2";
            outputLabel.Text += $"\n\nThe cost to carpet this area at ${costPerMeter} per square metre is {totalCost}";
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            double shirtCost = 12.49;
            double tax = 0.13;
            double totalTax = tax * shirtCost;
            double totalCost = shirtCost + totalTax;
            double tendered = 20.00;
            double change = tendered - totalCost;
            outputLabel.Text = "Bill of Sale";
            outputLabel.Text += $"\n\nShirt:         {shirtCost}";
            outputLabel.Text += $"\n\nTax:            {totalTax}";
            outputLabel.Text += $"\nTotal:           {totalCost}";
            outputLabel.Text += $"\n\nTendered:      {tendered}";
            outputLabel.Text += $"\nChange:           {change}";
        }
    }
}
