﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_S2016_LESSON1C
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            FullNameBox.Text = FirstNameTextBox.Text +" " +TextBox1.Text;
        }
       

       
    }
}