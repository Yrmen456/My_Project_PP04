using LibraryDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_PP04.Control
{
    public partial class PanelTopBtn : UserControl
    {
        public PanelTopBtn()
        {
            InitializeComponent();
        }

        public async void ShowPriceBasket(Button btn, string txt)
        {
            DataSet dataSet = new DataSet();
            await Task.Run(() =>
            {
                dataSet = SQL.Table($@"Select Sum(Basket.Count * Product.Price) from Basket
                Inner Join Product Product on Product.ID = Basket.ProductID 
                where Basket.UserID = {Data.Data.User.ID};");
            });

            if (dataSet.Tables.Count <= 0)
            {
                MessageBox.Show("F1");
                return;
            }
            if (dataSet.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("F2");
                return;
            }
            var Result = dataSet.Tables[0].Rows[0].ItemArray.Select(x => x.ToString()).ToArray();

            btn.Text = $"{txt}\n {Result[0]} руб.";
        }
    }
}
