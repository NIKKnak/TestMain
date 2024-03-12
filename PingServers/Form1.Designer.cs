namespace PingServers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            fontDialog1 = new FontDialog();
            errorProvider1 = new ErrorProvider(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            errorProvider1.SetError(button1, resources.GetString("button1.Error"));
            errorProvider1.SetIconAlignment(button1, (ErrorIconAlignment)resources.GetObject("button1.IconAlignment"));
            errorProvider1.SetIconPadding(button1, (int)resources.GetObject("button1.IconPadding"));
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            errorProvider1.SetError(label1, resources.GetString("label1.Error"));
            errorProvider1.SetIconAlignment(label1, (ErrorIconAlignment)resources.GetObject("label1.IconAlignment"));
            errorProvider1.SetIconPadding(label1, (int)resources.GetObject("label1.IconPadding"));
            label1.Name = "label1";
            label1.UseCompatibleTextRendering = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            resources.ApplyResources(errorProvider1, "errorProvider1");
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private FontDialog fontDialog1;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}
