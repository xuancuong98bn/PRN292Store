using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BUS
{
    public class BUSProduct
    {
        private static BUSProduct instance;
        public static BUSProduct Instance
        {
            get
            {
                if (instance == null)
                    instance = new BUSProduct();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public static void loadGrid(GridView g)
        {
            //g.DataSource = DAOProduct.loadProduct();
            g.DataSource = DAOProduct.loadProduct2();
            g.DataBind();
        }

        public static void loadComboMa(DropDownList d)
        {
            DataTable dt = DAOProduct.loadCode();
            
            d.DataTextField = dt.Columns["MaHang"].ToString();
            d.DataValueField = dt.Columns["MaHang"].ToString();
            d.DataSource = dt;
            d.DataBind();
        }

        public static Product loadText(String code)
        {
            return DAOProduct.loadDetail(code);
        }
    }
}