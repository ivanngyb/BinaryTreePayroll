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

        public void DeleteEmployee(string value)
        {
            try
            {
                bTree.Delete(value);
                DisplayEmployee();
                UpdateStatusLabel("Employee " + value + " deleted successfully");
                ClearReset();
            }
            catch (Exception e)
            {
                UpdateStatusLabel("Error removing employee");
                Console.WriteLine(e.Message);
            }
            
        }

        public void FindEmployee(string value)
        {
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

        public void UpdateRootText()
        {
            TextBoxRoot.Text = bTree.gsRoot.gsData;
        }

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

        public void ClearReset() 
        {
            TextBoxInput.Clear();
            TextBoxInput.Focus();
        }

        public void UpdateStatusLabel(string text)
        {
            StatusStripLabel.Text = text;
        }

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

        private void ButtonPrefill_Click(object sender, EventArgs e)
        {
            PrefillEmployee();
        }

        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
