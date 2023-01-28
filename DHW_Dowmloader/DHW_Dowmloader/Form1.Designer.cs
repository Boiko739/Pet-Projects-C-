
namespace GDZ_Downloader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadButton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.form = new System.Windows.Forms.NumericUpDown();
            this.downloadButton2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.percent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.authors = new System.Windows.Forms.ComboBox();
            this.tasks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.directory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.disciplines = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.form)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadButton1
            // 
            resources.ApplyResources(this.downloadButton1, "downloadButton1");
            this.downloadButton1.Name = "downloadButton1";
            this.downloadButton1.UseVisualStyleBackColor = true;
            this.downloadButton1.Click += new System.EventHandler(this.DownloadGolicButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // form
            // 
            resources.ApplyResources(this.form, "form");
            this.form.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.form.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.form.Name = "form";
            this.form.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // downloadButton2
            // 
            resources.ApplyResources(this.downloadButton2, "downloadButton2");
            this.downloadButton2.Name = "downloadButton2";
            this.downloadButton2.UseVisualStyleBackColor = true;
            this.downloadButton2.Click += new System.EventHandler(this.DownloadBookButton_Click);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.percent,
            this.toolStripProgressBar1,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Name = "toolStrip1";
            // 
            // percent
            // 
            this.percent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.percent.Name = "percent";
            resources.ApplyResources(this.percent, "percent");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DownloadTasksButton_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // authors
            // 
            this.authors.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("authors.AutoCompleteCustomSource"),
            resources.GetString("authors.AutoCompleteCustomSource1"),
            resources.GetString("authors.AutoCompleteCustomSource2"),
            resources.GetString("authors.AutoCompleteCustomSource3"),
            resources.GetString("authors.AutoCompleteCustomSource4")});
            this.authors.FormattingEnabled = true;
            resources.ApplyResources(this.authors, "authors");
            this.authors.Name = "authors";
            // 
            // tasks
            // 
            resources.ApplyResources(this.tasks, "tasks");
            this.tasks.Name = "tasks";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // directory
            // 
            resources.ApplyResources(this.directory, "directory");
            this.directory.Name = "directory";
            this.directory.Click += new System.EventHandler(this.directory_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // disciplines
            // 
            this.disciplines.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("disciplines.AutoCompleteCustomSource"),
            resources.GetString("disciplines.AutoCompleteCustomSource1"),
            resources.GetString("disciplines.AutoCompleteCustomSource2"),
            resources.GetString("disciplines.AutoCompleteCustomSource3"),
            resources.GetString("disciplines.AutoCompleteCustomSource4")});
            this.disciplines.FormattingEnabled = true;
            resources.ApplyResources(this.disciplines, "disciplines");
            this.disciplines.Name = "disciplines";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.directory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.downloadButton2);
            this.Controls.Add(this.form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disciplines);
            this.Controls.Add(this.downloadButton1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.form)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button downloadButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown form;
        private System.Windows.Forms.Button downloadButton2;
        internal System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        internal System.Windows.Forms.ToolStripLabel percent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox authors;
        private System.Windows.Forms.TextBox tasks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox directory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox disciplines;
    }
}

