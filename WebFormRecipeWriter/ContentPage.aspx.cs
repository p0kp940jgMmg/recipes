using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebFormRecipeWriter
{
    public partial class ContentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string recipe = null;
            //Textsträngarna från 
            string str1 = TextBox1.Text;
            string str2 = TextBox2.Text;
            string str3 = TextBox3.Text;
            string str4 = TextBox4.Text;
            string str5 = TextBox5.Text;

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= 5; i++)
            {
                sb = sb.Append($"str{i};");
            }

            recipe = sb.ToString();

            FileWriter fw = new FileWriter
        }
    }
}