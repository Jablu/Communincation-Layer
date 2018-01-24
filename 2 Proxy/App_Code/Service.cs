using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]

    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public int Add(int n1, int n2)
    {
        return n1 + n2;
    }

    [WebMethod]
    public int Subtract(int n1, int n2)
    {
        return n1 - n2;
    }
}