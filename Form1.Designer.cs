namespace Prime_Number_Gen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textbox_number01 = new System.Windows.Forms.TextBox();
            this.textbox_number2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.button_find = new System.Windows.Forms.Button();
            this.listbox_output = new System.Windows.Forms.ListBox();
            this.Sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_number01
            // 
            resources.ApplyResources(this.textbox_number01, "textbox_number01");
            this.textbox_number01.Name = "textbox_number01";
            // 
            // textbox_number2
            // 
            resources.ApplyResources(this.textbox_number2, "textbox_number2");
            this.textbox_number2.Name = "textbox_number2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button_find
            // 
            resources.ApplyResources(this.button_find, "button_find");
            this.button_find.Name = "button_find";
            this.button_find.UseVisualStyleBackColor = true;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // listbox_output
            // 
            resources.ApplyResources(this.listbox_output, "listbox_output");
            this.listbox_output.FormattingEnabled = true;
            this.listbox_output.Items.AddRange(new object[] {
            resources.GetString("listbox_output.Items")});
            this.listbox_output.MultiColumn = true;
            this.listbox_output.Name = "listbox_output";
            // 
            // Sort
            // 
            resources.ApplyResources(this.Sort, "Sort");
            this.Sort.Name = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.listbox_output);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_number2);
            this.Controls.Add(this.textbox_number01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_number01;
        private System.Windows.Forms.TextBox textbox_number2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.ListBox listbox_output;
        private System.Windows.Forms.Button Sort;
    }
}

