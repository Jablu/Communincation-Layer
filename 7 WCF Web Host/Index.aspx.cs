using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;
using ServiceReference1;



public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {

            HRMSServiceClient proxy = new HRMSServiceClient();
            List<Emplyoee> list = proxy.GetAllEmpForMe().ToList();
            GridView1.DataSource = list;
            GridView1.DataBind();

        }

        catch(FaultException <DivideByZeroException> ex)
        {
            Label4.Text = ex.Message;
        }

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        HRMSServiceClient proxy = new HRMSServiceClient();

    }

    protected void Label3_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Emplyoee emp = new Emplyoee
        {
            Ecode = int.Parse(TextBox1.Text),
            Ename = TextBox2.Text,
            Salary = int.Parse(TextBox3.Text),
            Deptid = int.Parse(TextBox4.Text),


        };

        HRMSServiceClient proxy = new HRMSServiceClient();
        proxy.AddEmp(emp);
        List<Emplyoee> list = proxy.GetAllEmpForMe().ToList();
        GridView1.DataSource = list;
        GridView1.DataBind();


    }
}