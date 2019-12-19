using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proxy
{
    public partial class Form1 : Form
    {
        Client client;
        public Form1()
        {
            InitializeComponent();
            string[] products = { "Ноутбук", "Планшет", "Смартфон", "Наушники" };
            list_product_goods.Items.AddRange(products);
            list_product_goods.SelectedIndexChanged += list_product_goods_SelectedIndexChanged;
        }

        private void list_product_goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelecteGoods = list_product_goods.SelectedItem.ToString();
            MessageBox.Show(SelecteGoods);
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            if (client.(txt_Full_name.Text, txt_phone_number.Text, txt_adress.Text))
            {
                client.();
            }
        }
    }
}
