using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace Sep8
{
    public delegate void HandleEmployeeDetails(List<Employee> emplist);

    public class Operation : EventArgs
    {
        public static event HandleEmployeeDetails AddEvent;
        public static event HandleEmployeeDetails EditEvent;
        public static event HandleEmployeeDetails UpdateEvent;
        public static event HandleEmployeeDetails RemoveEvent;
        public static event HandleEmployeeDetails DisplayEvent;

        public static  List<Employee> emplist = new List<Employee>();

        static void Main(string[] args)
        {
            AddEvent += Operation_AddEvent;
            RemoveEvent += Operation_RemoveEvent;
            EditEvent += Operation_EditEvent;
            UpdateEvent += Operation_UpdateEvent;
            DisplayEvent += Operation_DisplayEvent;

            List<Employee> emplist=new List<Employee>();
            List<Employee> emplist2=new List<Employee>();
            Employee emp1 = new Employee();
            emp1.EmpID = 20;
            emp1.EmpName = "Salini";
            emp1.DeptNo = 2;
            emp1.Salary = 34000;
           // emp1.Manager = "Sameer";

            Employee emp2=new Employee();
            emp1.EmpID = 19;
            emp1.EmpName = "Shalu";
            emp1.DeptNo = 1;
            emp1.Salary = 34000;
            emp1.Manager = "Sameer";
            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist2.Add(emp1);
            emplist2.Add(emp2);
            UserLogin(emplist2);

            void UserLogin(List<Employee> empList)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Welcome to This Page");
                Console.ForegroundColor = ConsoleColor.White;
                Action<string, string> function = (string Username, string Password) =>
                {
                    Console.WriteLine("Enter Username(Shalu)");
                    Username = Console.ReadLine();
                    Employee Fin = emplist2.Find(x => x.EmpName == Username);
                    if (Fin == null)
                    {
                        Console.WriteLine("Invalid Username");


                    }

                    else if ((Username == Fin.EmpName) && (Password == "Sameer"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Logged in Successfully");
                        Console.WriteLine();
                        Console.ForegroundColor=ConsoleColor.White;
                        Console.WriteLine("Menu \n 1 for Add Employee \n 2 for Edit \n 3 for Update \n 4 for Remove \n 5 for DisplayEmployeeDeatils");
                        int choice = int.Parse(Console.ReadLine());
                        Employee emp = new Employee();

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Enter EmployeeID");
                                emp.EmpID = int.Parse(Console.ReadLine());
                                Console.WriteLine("employee Name");
                                emp.EmpName = Console.ReadLine();
                                Console.WriteLine("Enter Dept No");
                                emp.DeptNo = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Salary");
                                emp.Salary = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Manager Name");
                                emp.Manager = Console.ReadLine();

                                AddEvent(emplist);
                                DisplayEvent(emplist);

                                break;

                            case 2:
                                foreach (Employee item in emplist)
                                {
                                    Console.WriteLine("Employee ID                : " + item.EmpID);
                                    Console.WriteLine("Employee Name              : " + item.EmpName);
                                    Console.WriteLine("Employee Dept No           : " + item.DeptNo);
                                    Console.WriteLine("Employee Salary            : " + item.Salary);
                                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                                    Console.WriteLine("********************************************");
                                }
                                EditEvent(emplist);
                                break;
                            case 3:
                                Console.WriteLine("Enter EmployeeID");
                                emp.EmpID = int.Parse(Console.ReadLine());
                                Console.WriteLine("employee Name");
                                emp.EmpName = Console.ReadLine();
                                Console.WriteLine("Enter Dept No");
                                emp.DeptNo = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Salary");
                                emp.Salary = float.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Manager Name");
                                emp.Manager = Console.ReadLine();

                                UpdateEvent(emplist);
                                break;
                            case 4:
                                foreach (Employee item in emplist)
                                {
                                    Console.WriteLine("Employee ID                : " + item.EmpID);
                                    Console.WriteLine("Employee Name              : " + item.EmpName);
                                    Console.WriteLine("Employee Dept No           : " + item.DeptNo);
                                    Console.WriteLine("Employee Salary            : " + item.Salary);
                                    Console.WriteLine("Employee Reporting Manager : " + item.Manager);
                                    Console.WriteLine("********************************************");
                                }
                                RemoveEvent(emplist);
                                break;
                            case 5:
                                DisplayEvent(emplist);
                                break;
                            default:
                                Environment.Exit(1);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Credentials...Try Again");
                    }
                };
                function("Thashwanth", "Sameer");
            }


            
            
            Console.ReadLine();
        }

        public void AddEmployee(List<Employee> emplist)
        {
            Employee emp = new Employee();
            emplist.Add(emp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Added Successfully");
            Console.WriteLine();
            Console.WriteLine("Employee list");
            Department dept1 = new Department();
            Operations del = new Operations(dept1.DisplayDetails);
            del(emplist);
        }
        
        public void RemoveEmployee(List<Employee> emplist)
        {
            Console.WriteLine("Enter the Emp Id to delete the employee details");
            int id = int.Parse(Console.ReadLine());
            Employee found = emplist.Find(x => x.EmpID == id);
            emplist.Remove(found);
            Console.WriteLine("Deleted Successfully");
            Console.WriteLine();
            Console.WriteLine("Employee list");
            Department dept1 = new Department();
            Operations del = new Operations(dept1.DisplayDetails);
            del(emplist);

        }
        public void EditEmployee(List<Employee> emplist)
        {
            Console.WriteLine("Enter the Emp Id to delete the employee details");
            int id = int.Parse(Console.ReadLine());
            Employee found = emplist.Find(x => x.EmpID == id);
            Console.WriteLine("Enter new details");
            Console.WriteLine("Enter EmployeeID");
            found.EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("employee Name");
            found.EmpName = Console.ReadLine();
            Console.WriteLine("Enter Dept No");
            found.DeptNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            found.Salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Manager Name");
            found.Manager = Console.ReadLine();


            Console.WriteLine("Employee details edited Successfully");

            Console.WriteLine();
            Console.WriteLine("Employee list");
            Department dept1 = new Department();
            Operations del = new Operations(dept1.DisplayDetails);
            del(emplist);

        }
        public void UpdateEmployee(List<Employee> emplist)
        {
            Employee emp = new Employee();
            emplist.Add(emp);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Updated Successfully");
            Console.WriteLine();
            Console.WriteLine("Employee list");
            Department dept1 = new Department();
            Operations del = new Operations(dept1.DisplayDetails);
            del(emplist);

        }


        private static void Operation_DisplayEvent(List<Employee> emplist)
        {
            Department dept = new Department();
            HandleEmployeeDetails del = new HandleEmployeeDetails(dept.DisplayDetails);
            del(emplist);
            //throw new NotImplementedException();
        }

        private static void Operation_UpdateEvent(List<Employee> emplist)
        {
            Operation operation = new Operation();
            HandleEmployeeDetails del = new HandleEmployeeDetails(operation.UpdateEmployee);
            del(emplist);
            //throw new NotImplementedException();
        }

        private static void Operation_EditEvent(List<Employee> emplist)
        {
            Operation operation = new Operation();
            HandleEmployeeDetails del = new HandleEmployeeDetails(operation.EditEmployee);
            del(emplist);
            //throw new NotImplementedException();
        }

        private static void Operation_RemoveEvent(List<Employee> emplist)
        {
            Operation operation = new Operation();
            HandleEmployeeDetails del = new HandleEmployeeDetails(operation.RemoveEmployee);
            del(emplist);
            //throw new NotImplementedException();
        }

        private static void Operation_AddEvent(List<Employee> emplist)
        {
            Operation operation = new Operation();
            HandleEmployeeDetails del = new HandleEmployeeDetails(operation.AddEmployee);
            del(emplist);
            //throw new NotImplementedException();
        }
    }
}
