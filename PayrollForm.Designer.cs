
namespace BinaryTreePayroll
{
    partial class PayrollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBoxEmployee = new System.Windows.Forms.ListBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonPrefill = new System.Windows.Forms.Button();
            this.LabelRoot = new System.Windows.Forms.Label();
            this.TextBoxRoot = new System.Windows.Forms.TextBox();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelText = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxEmployee
            // 
            this.ListBoxEmployee.FormattingEnabled = true;
            this.ListBoxEmployee.Location = new System.Drawing.Point(12, 220);
            this.ListBoxEmployee.Name = "ListBoxEmployee";
            this.ListBoxEmployee.Size = new System.Drawing.Size(276, 225);
            this.ListBoxEmployee.TabIndex = 0;
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 76);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(276, 23);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add Employee";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.Location = new System.Drawing.Point(12, 105);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(276, 23);
            this.ButtonRemove.TabIndex = 1;
            this.ButtonRemove.Text = "Remove Employee";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(12, 134);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(276, 23);
            this.ButtonSearch.TabIndex = 1;
            this.ButtonSearch.Text = "Search Employee";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonPrefill
            // 
            this.ButtonPrefill.Location = new System.Drawing.Point(12, 163);
            this.ButtonPrefill.Name = "ButtonPrefill";
            this.ButtonPrefill.Size = new System.Drawing.Size(276, 23);
            this.ButtonPrefill.TabIndex = 1;
            this.ButtonPrefill.Text = "Prefill Employees";
            this.ButtonPrefill.UseVisualStyleBackColor = true;
            this.ButtonPrefill.Click += new System.EventHandler(this.ButtonPrefill_Click);
            // 
            // LabelRoot
            // 
            this.LabelRoot.AutoSize = true;
            this.LabelRoot.Location = new System.Drawing.Point(12, 195);
            this.LabelRoot.Name = "LabelRoot";
            this.LabelRoot.Size = new System.Drawing.Size(36, 13);
            this.LabelRoot.TabIndex = 2;
            this.LabelRoot.Text = "Root: ";
            // 
            // TextBoxRoot
            // 
            this.TextBoxRoot.Enabled = false;
            this.TextBoxRoot.Location = new System.Drawing.Point(46, 192);
            this.TextBoxRoot.Name = "TextBoxRoot";
            this.TextBoxRoot.Size = new System.Drawing.Size(242, 20);
            this.TextBoxRoot.TabIndex = 3;
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 50);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(276, 20);
            this.TextBoxInput.TabIndex = 4;
            this.TextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "AVL Payroll";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelText,
            this.StatusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(306, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // StatusLabelText
            // 
            this.StatusLabelText.Name = "StatusLabelText";
            this.StatusLabelText.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusStripLabel
            // 
            this.StatusStripLabel.Name = "StatusStripLabel";
            this.StatusStripLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // PayrollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.TextBoxRoot);
            this.Controls.Add(this.LabelRoot);
            this.Controls.Add(this.ButtonPrefill);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListBoxEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayrollForm";
            this.Text = "Payroll Form";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxEmployee;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonPrefill;
        private System.Windows.Forms.Label LabelRoot;
        private System.Windows.Forms.TextBox TextBoxRoot;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelText;
        private System.Windows.Forms.ToolStripStatusLabel StatusStripLabel;
    }
}

