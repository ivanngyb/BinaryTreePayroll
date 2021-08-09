using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Yang Beng Ng (Ivan)
//ID: 30031552
//Description: Payroll system that sorts name
//Reference: AVL Tree code is sourced from file provided my lecturer on Blackboard

namespace BinaryTreePayroll
{
    public partial class PayrollForm : Form
    {
        BinaryTree bTree = new BinaryTree();

        public PayrollForm()
        {
            InitializeComponent();
        }

        //Function for adding employeess 
        public void AddEmployee(string value)
        {

            try
            {
                bTree.Add(value);
                DisplayEmployee();
                UpdateStatusLabel("Employee " + value + " added successfully");
                ClearReset();
            }
            catch (Exception e)
            {
                UpdateStatusLabel("Error adding employee");
                Console.WriteLine(e.Message);
            }
        }

        //Function for deleting employees
        public void DeleteEmployee(string value)
        {
            try
            {
                if (bTree.Find(value))
                {
                    bTree.Delete(value);
                    DisplayEmployee();
                    UpdateStatusLabel("Employee " + value + " deleted successfully");
                    ClearReset();
                }
                else 
                {
                    UpdateStatusLabel("Error removing employee (can't find " + value + ")");
                }
            }
            catch (Exception e)
            {
                UpdateStatusLabel("Error removing employee");
                Console.WriteLine(e.Message);
            }
            
        }

        //Fuunction for finding employees
        public void FindEmployee(string value)
        {
            //If value is found highlight value in listbox
            if (bTree.Find(value))
            {
                UpdateStatusLabel("Employee " + value + " was found!");
                for (int i = 0; i < ListBoxEmployee.Items.Count; i++)
                {
                    if (ListBoxEmployee.Items[i].ToString().ToLower().Equals(value.ToLower()))
                    {
                        ListBoxEmployee.SelectedIndex = i;
                    }
                }
                ClearReset();
            }
            else
            {
                UpdateStatusLabel("Employee " + value + " could not be found!");
            }
        }

        //Function for displaying employees
        public void DisplayEmployee()
        {
            try
            {
                ListBoxEmployee.Items.Clear();
                bTree.Display(ListBoxEmployee);
                UpdateRootText();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Changing the root text
        public void UpdateRootText()
        {
            TextBoxRoot.Text = bTree.gsRoot.gsData;
        }

        //Prefill a list of employees into binary tree
        public void PrefillEmployee()
        {
            bTree.Add("Liam");
            bTree.Add("Noah");
            bTree.Add("Oliver");
            bTree.Add("Elijah");
            bTree.Add("William");
            bTree.Add("Olivia");
            bTree.Add("Amelia");
            bTree.Add("Benjamin");
            bTree.Add("Xavier");
            bTree.Add("Harper");
            bTree.Add("Sophia");

            DisplayEmployee();
            UpdateRootText();
            ButtonPrefill.Enabled = false;
        }
        //Resetting text fields

        public void ClearReset() 
        {
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }

        //Function to update status label
        public void UpdateStatusLabel(string text)
        {
            StatusStripLabel.Text = text;
        }

        //Button click function for adding employee
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                AddEmployee(TextBoxInput.Text);
            }
            else
            {
                UpdateStatusLabel("Please enter an employee name to add");
            }
        }

        //Button click function for removing employee
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                DeleteEmployee(TextBoxInput.Text);
            }
            else if (ListBoxEmployee.SelectedIndex >= 0)
            {
                DeleteEmployee(ListBoxEmployee.Items[ListBoxEmployee.SelectedIndex].ToString());
            }
            else
            {
                UpdateStatusLabel("Please select or enter an employee to delete");
            }
        }

        //Button click function for searching employee
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                FindEmployee(TextBoxInput.Text);
            }
            else
            {
                UpdateStatusLabel("Please enter an employee name to search");
            }
        }

        //Button to prefill tree with employees
        private void ButtonPrefill_Click(object sender, EventArgs e)
        {
            PrefillEmployee();
        }

        //Text box function to handle input type to only allow letters
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
