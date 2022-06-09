using System;
using System.Data.Entity.SqlServer;
using System.Data.SqlTypes;
using System.Linq;
using System.Windows.Forms;
using WinFormsEntityFrameWork.models;
using EntityState = System.Data.Entity.EntityState;

namespace WinFormsEntityFrameWork
{
    public partial class Form1 : Form
    {
        private int rowIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Select();
        }

        private void Select()
        {
            using DeliveryContext employeeContext = new DeliveryContext();
            var deliveries = employeeContext.Deliveries.OrderByDescending(p => p.NumberOfDelivery);
            dataGridView1.DataSource = deliveries.ToList();
            ;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using DeliveryContext deliveryContext = new DeliveryContext();
            deliveryContext.Deliveries.Add(new Delivery
            {
                PriceOfDelivery = Int32.Parse(priceOfDelivery.Text),
                AddressOfDelivery = addressOfDelivery.Text,
                DescriptionOfDelivery = descriptionOfDelivery.Text
            });

            deliveryContext.SaveChanges();

            Select();
            priceOfDelivery.Text = null;
            addressOfDelivery.Text = null;
            descriptionOfDelivery.Text = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            priceOfDelivery.Text = dataGridView1.Rows[e.RowIndex].Cells["PriceOfDelivery"].Value.ToString();
            addressOfDelivery.Text = dataGridView1.Rows[e.RowIndex].Cells["AddressOfDelivery"].Value.ToString();
            descriptionOfDelivery.Text = dataGridView1.Rows[e.RowIndex].Cells["DescriptionOfDelivery"].Value.ToString();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Select();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
          
            using DeliveryContext employeeContext = new DeliveryContext();
            var employees = employeeContext.Deliveries
                // .Where(p => p.PriceOfDelivery == price, !string.IsNullOrEmpty(priceFilter.Text))
                // .Where(p => p.AddressOfDelivery == addressFilter.Text, !string.IsNullOrEmpty(addressFilter.Text))
                // .Where(p => p.DescriptionOfDelivery == descFilter.Text, !string.IsNullOrEmpty(descFilter.Text))
                // .Where(p => p.NumberOfDelivery == number, !string.IsNullOrEmpty(numberFilter.Text));
                .Where(p => p.DescriptionOfDelivery == descFilter.Text, !string.IsNullOrEmpty(descFilter.Text))
                .Where(p => p.AddressOfDelivery == comboBox1.Text, !string.IsNullOrEmpty(comboBox1.Text));
            dataGridView1.DataSource = employees.ToList();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Delivery model = new Delivery();
            using DeliveryContext employeeContext = new DeliveryContext();
            model.NumberOfDelivery = int.Parse(dataGridView1.Rows[rowIndex].Cells["NumberOfDelivery"].Value.ToString());
            model = employeeContext.Deliveries.Where(p => p.NumberOfDelivery == model.NumberOfDelivery)
                .FirstOrDefault();
            model.PriceOfDelivery = Int32.Parse(priceOfDelivery.Text);
            model.AddressOfDelivery = addressOfDelivery.Text;
            model.DescriptionOfDelivery = descriptionOfDelivery.Text;
            employeeContext.Entry(model).State = EntityState.Modified;
            employeeContext.SaveChanges();

            Select();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delivery model = new Delivery();
            using DeliveryContext deliveryContext = new DeliveryContext();
            model.NumberOfDelivery = int.Parse(dataGridView1.Rows[rowIndex].Cells["NumberOfDelivery"].Value.ToString());
            model = deliveryContext.Deliveries.Where(p => p.NumberOfDelivery == model.NumberOfDelivery)
                .FirstOrDefault();
            model.PriceOfDelivery = Int32.Parse(priceOfDelivery.Text);
            model.AddressOfDelivery = addressOfDelivery.Text;
            model.DescriptionOfDelivery = descriptionOfDelivery.Text;
            deliveryContext.Deliveries.Remove(model);
            deliveryContext.SaveChanges();

            Select();
        }
    }
}