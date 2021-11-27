using System;
using Client.EmployeeServiceRef;

namespace Client
{
    public partial class EmployeeCRUD : System.Web.UI.Page
    {
        EmployeeClient client = new EmployeeClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void EmpIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.empID = EmpIDBox.Text;
            emp.empName = EmpNameBox.Text;
            emp.empPhNo = EmpPhNoBox.Text;
            emp.empEmail = EmpEmailBox.Text;
            emp.empAdd = EmpAddrBox.Text;

            bool res = client.AddData(emp);

            if (res == true)
                ResLbl.Text = "Employee Data Added Successfully";
            else
                ResLbl.Text = "Error Occured !!";
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.empID = EmpIDBox.Text;
            if(!String.IsNullOrEmpty(EmpNameBox.Text) || !String.IsNullOrWhiteSpace(EmpNameBox.Text)) emp.empName = EmpNameBox.Text;
            if (!String.IsNullOrEmpty(EmpPhNoBox.Text) || !String.IsNullOrWhiteSpace(EmpPhNoBox.Text)) emp.empPhNo = EmpPhNoBox.Text;
            if (!String.IsNullOrEmpty(EmpEmailBox.Text) || !String.IsNullOrWhiteSpace(EmpEmailBox.Text)) emp.empEmail = EmpEmailBox.Text;
            if (!String.IsNullOrEmpty(EmpAddrBox.Text) || !String.IsNullOrWhiteSpace(EmpAddrBox.Text)) emp.empAdd = EmpAddrBox.Text;

            bool res = client.UpdateData(Convert.ToInt32(EmpIDBox.Text), emp);

            if (res == true)
                ResLbl.Text = "Employee Data Updated Successfully";
            else
                ResLbl.Text = "Error Occured !!";
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            bool res  = client.DeleteData(Convert.ToInt32(EmpIDBox.Text));

            if (res == true)
                ResLbl.Text = "Employee Data Deleted Successfully";
            else
                ResLbl.Text = "Error Occured !!";
        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            System.Collections.Generic.IEnumerable<employee> emp = client.FindData(Convert.ToInt32(EmpIDBox.Text));


            if (emp != null)
            {
                ResGrid.DataSource = emp;
                ResGrid.DataBind();
            }
        }

        protected void BtnGetAll_Click(object sender, EventArgs e)
        {
   
            System.Collections.Generic.IEnumerable<employee> emp = client.FindAll();


            if (emp != null)
            {
                ResGrid.DataSource = emp;
                ResGrid.DataBind();
            }
        }
    }
}