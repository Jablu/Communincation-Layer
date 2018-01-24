using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using EmpBusinessLayer;
using EntitiesLib;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHRMSService" in both code and config file together.
[ServiceContract]
public interface IHRMSService
{
    [OperationContract]
    [FaultContract(typeof(DivideByZeroException))]
    List<Emplyoee> GetAllEmpForMe();

    [OperationContract]
    Emplyoee GetEmpById(int ecode);

    [OperationContract]
    void AddEmp(Emplyoee emp);

    [OperationContract]
    int DeleteEmployee(int ecode);

    [OperationContract]
    int UpdateSalary(int ecode, int salary);
}
