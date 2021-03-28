using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCompany root = new ConcreteCompany("總公司");
            root.Add(new HRDepartment("總公司人資部門"));
            root.Add(new FinanceDepartment("總公司財務部門"));

            ConcreteCompany comp = new ConcreteCompany("A分公司");
            comp.Add(new HRDepartment("A分公司人資部門"));
            comp.Add(new FinanceDepartment("A分公司財務部門"));
            root.Add(comp);

            ConcreteCompany comp1 = new ConcreteCompany("A分公司子公司");
            comp1.Add(new HRDepartment("A分公司子公司人資部門"));
            comp1.Add(new FinanceDepartment("A分公司子公司財務部門"));
            comp.Add(comp1);


            ConcreteCompany comp2 = new ConcreteCompany("B分公司");
            comp2.Add(new HRDepartment("B分公司人資部門"));
            comp2.Add(new FinanceDepartment("B分公司財務部門"));
            root.Add(comp2);

            Console.WriteLine("\n公司組織圖：");
            root.Display(1);

            Console.WriteLine("\n公司職責：");
            root.LineOfDuty();

        }
    }
}
