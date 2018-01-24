using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int n1 = int.Parse(vctextboxEC.Text);
        int n2 = int.Parse(vctextboxPW.Text);

        Service service = new Service();
        int result = service.Add(n1, n2);
        showBox.Text = result.ToString();
        
    }
}