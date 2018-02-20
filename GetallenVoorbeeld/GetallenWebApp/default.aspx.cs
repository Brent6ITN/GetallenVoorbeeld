using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GetalLibrary;

namespace GetallenWebApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnZoek_Click(object sender, EventArgs e)
        {
            controller _controller = new controller();

            _controller.setGetal1(Convert.ToInt32(txtgetal1.Text));
            _controller.setGetal2(Convert.ToInt32(txtgetal2.Text));

            lblUitvoer.Text = "GGD:" + _controller.zoekGGD();

        }
    }
}