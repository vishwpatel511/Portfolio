using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_S2016_Lesson2
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Page.Title)
            {
                case "Home":

                    Debug.WriteLine("Home was clicked!!");
                    Home.Attributes.Add("class", "active");
                    

                    break;
                case "About":

                    About.Attributes.Add("class", "active");

                    break;
                case "Contact":

                    Contact.Attributes.Add("class", "active");

                    break;
                case "Projects":
                    Projects.Attributes.Add("class", "active");

                    break;
            }
        }
    }
}