using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        double AddNumbers(double num1, double num2);

        [OperationContract]
        double SubtractNumbers(double num1, double num2);

        [OperationContract]
        double MultiplyNumbers(double num1, double num2);

        [OperationContract]
        double DivideNumbers(double num1, double num2);
    }
}
