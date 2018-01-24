using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EntitiesLib;
using EmpBusinessLayer;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HRMSService" in code, svc and config file together.
public class HRMSService : IHRMSService
{
    public void AddEmp(Emplyoee emp)
    {

        BLL bLL = new BLL();
        bLL.AddEmployee(emp);
        
    }

    public int DeleteEmployee(int ecode)
    {
        BLL bLL = new BLL();
        return bLL.RemoveEmployee(ecode); ;
    }

    public List<Emplyoee> GetAllEmpForMe()
    {

        try
        {

            int x = 15, y = 0;
            int z = x / y;
        }
        catch(DivideByZeroException c)
        {
            FaultException<DivideByZeroException> fex = new FaultException<DivideByZeroException>(c, "divide by 0");
            throw fex;
        }

        List<Emplyoee> empList = new List<Emplyoee>();

        BLL bLL = new BLL();
        empList = bLL.GetAllEmps();

        return empList;
    }

    public Emplyoee GetEmpById(int ecode)
    {
        throw new NotImplementedException();
    }

    public int UpdateSalary(int ecode, int salary)
    {
        throw new NotImplementedException();
    }
}
