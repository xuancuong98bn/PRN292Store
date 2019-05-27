using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormDemo_1
{
    public partial class Form4 : Form
    {
        List<Car> listCar;
        public Form4()
        {
            InitializeComponent();
            listCar = new List<Car>();
            initCar();
        }

        public void initCar()
        {
            string[] arrName = { "Vios A", "Vios E", "Vios G", "City", "Morning", "Bright", "Light", "Meow", "Dog", "Duck" };
            string[] arrBrand = { "Toyota", "Kya", "Toyota", "Exe", "Toyota", "Toyota", "Boss", "Narita", "Yasshi", "Toyota" };
            double[] arrPrice = { 100000, 200000, 3000, 400000, 500, 658, 987655, 326657, 36645, 3132464 };
            for (int i = 0; i < 10; i++)
            {
                listCar.Add(new Car(i, arrName[i], arrBrand[i], arrPrice[i]));
            }
        }

        private void LoadGrid()
        {
            dataGridViewResult.DataSource = listCar;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Car> result = new List<Car>();
            result = listCar.Where(item => item.name.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim())).ToList();
            list.DataSource = result;
            list.DisplayMember = "name";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Car> result = new List<Car>();
            result = listCar.Where(item => item.name.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim())).ToList();
            list.DataSource = result;
            list.DisplayMember = "name";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            List<Car> result = new List<Car>();
            result = listCar.Where(item => item.name.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim())).ToList();
            var max = result.Max(item => item.price);
            result = listCar.Where(item => item.price == max).ToList();
            list.DataSource = result;
            list.DisplayMember = "name";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            var total = listCar.Count(item => item.name.ToLower().Trim().Contains(txtSearch.Text.ToLower().Trim()));
            MessageBox.Show(total.ToString(), "Total record finded", MessageBoxButtons.OK);
        }
    }

    public class Car
    {
        public int code { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public double price { get; set; }

        public Car()
        {
        }

        public Car(int code, string name, string brand, double price)
        {
            this.code = code;
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        public override string ToString()
        {
            return code + "\t" + name + "\t" + brand + "\t" + price;
        }
    }
}
