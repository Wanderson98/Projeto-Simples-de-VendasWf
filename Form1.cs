using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Aula31
{
    public partial class Form1 : MaterialForm
    {

        public decimal Preco { get; set; }
        public decimal PrecoTotal { get; set; }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            
            ltbProdutos.AddItem(txtProduto.Text);
            Preco = decimal.Parse(txtPreco.Text);
            ltbPrecos.AddItem("R$ " + Preco.ToString("F2"));
            PrecoTotal += Preco;


            txtProduto.Text = null;
            txtPreco.Text = null;


            lblPrecoTotal.Text ="R$ "+  PrecoTotal.ToString("F2");
        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ltbProdutos_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
               //string test = txtProduto.Text;
               // for (int i = 0; i < ltbProdutos.Count; i++)
               // {
               //     if(txtProduto.Text == ltbProdutos.Items[i].Text)
               //     {
               //         ltbProdutos.Items.RemoveAt(i);
               //         ltbPrecos.Items.RemoveAt(i) ;
               //     }
               // }

                //int index = ltbProdutos.SelectedIndex;
                //PrecoTotal -= decimal.Parse(ltbPrecos.Items[index].ToString());
                //lblPrecoTotal.Text = "R$ " + PrecoTotal.ToString("F2");

                ltbProdutos.Items.RemoveAt(ltbProdutos.SelectedIndex);
                ltbPrecos.Items.RemoveAt(ltbProdutos.SelectedIndex);



            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, false); 
            }
           
           
        }
    }
}
