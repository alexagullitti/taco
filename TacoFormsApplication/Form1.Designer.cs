namespace TacoFormsApplication
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
         this.addButton = new System.Windows.Forms.Button();
         this.updateButton = new System.Windows.Forms.Button();
         this.deleteButton = new System.Windows.Forms.Button();
         this.searchButton = new System.Windows.Forms.Button();
         this.searchAll = new System.Windows.Forms.Button();
         this.firstName = new System.Windows.Forms.TextBox();
         this.lastName = new System.Windows.Forms.TextBox();
         this.address = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.dataGrid = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
         this.SuspendLayout();
         // 
         // addButton
         // 
         this.addButton.Location = new System.Drawing.Point(32, 264);
         this.addButton.Name = "addButton";
         this.addButton.Size = new System.Drawing.Size(75, 23);
         this.addButton.TabIndex = 0;
         this.addButton.Text = "Add";
         this.addButton.UseVisualStyleBackColor = true;
         this.addButton.Click += new System.EventHandler(this.addButton_Click);
         // 
         // updateButton
         // 
         this.updateButton.Location = new System.Drawing.Point(32, 304);
         this.updateButton.Name = "updateButton";
         this.updateButton.Size = new System.Drawing.Size(75, 23);
         this.updateButton.TabIndex = 1;
         this.updateButton.Text = "Update";
         this.updateButton.UseVisualStyleBackColor = true;
         this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
         // 
         // deleteButton
         // 
         this.deleteButton.Location = new System.Drawing.Point(32, 344);
         this.deleteButton.Name = "deleteButton";
         this.deleteButton.Size = new System.Drawing.Size(75, 23);
         this.deleteButton.TabIndex = 2;
         this.deleteButton.Text = "Delete";
         this.deleteButton.UseVisualStyleBackColor = true;
         this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
         // 
         // searchButton
         // 
         this.searchButton.Location = new System.Drawing.Point(32, 224);
         this.searchButton.Name = "searchButton";
         this.searchButton.Size = new System.Drawing.Size(75, 23);
         this.searchButton.TabIndex = 3;
         this.searchButton.Text = "Search";
         this.searchButton.UseVisualStyleBackColor = true;
         this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
         // 
         // searchAll
         // 
         this.searchAll.Location = new System.Drawing.Point(336, 48);
         this.searchAll.Name = "searchAll";
         this.searchAll.Size = new System.Drawing.Size(112, 23);
         this.searchAll.TabIndex = 4;
         this.searchAll.Text = "Search All";
         this.searchAll.UseVisualStyleBackColor = true;
         this.searchAll.Click += new System.EventHandler(this.searchAll_Click);
         // 
         // firstName
         // 
         this.firstName.Location = new System.Drawing.Point(32, 48);
         this.firstName.Name = "firstName";
         this.firstName.Size = new System.Drawing.Size(100, 20);
         this.firstName.TabIndex = 5;
         // 
         // lastName
         // 
         this.lastName.Location = new System.Drawing.Point(32, 88);
         this.lastName.Name = "lastName";
         this.lastName.Size = new System.Drawing.Size(100, 20);
         this.lastName.TabIndex = 6;
         // 
         // address
         // 
         this.address.Location = new System.Drawing.Point(32, 128);
         this.address.Name = "address";
         this.address.Size = new System.Drawing.Size(100, 20);
         this.address.TabIndex = 7;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(32, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(57, 13);
         this.label1.TabIndex = 8;
         this.label1.Text = "First Name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(32, 72);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(58, 13);
         this.label2.TabIndex = 9;
         this.label2.Text = "Last Name";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(32, 112);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(45, 13);
         this.label3.TabIndex = 10;
         this.label3.Text = "Address";
         // 
         // dataGrid
         // 
         this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGrid.Location = new System.Drawing.Point(200, 88);
         this.dataGrid.Name = "dataGrid";
         this.dataGrid.Size = new System.Drawing.Size(320, 272);
         this.dataGrid.TabIndex = 11;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(562, 418);
         this.Controls.Add(this.dataGrid);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.address);
         this.Controls.Add(this.lastName);
         this.Controls.Add(this.firstName);
         this.Controls.Add(this.searchAll);
         this.Controls.Add(this.searchButton);
         this.Controls.Add(this.deleteButton);
         this.Controls.Add(this.updateButton);
         this.Controls.Add(this.addButton);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addButton;
      private System.Windows.Forms.Button updateButton;
      private System.Windows.Forms.Button deleteButton;
      private System.Windows.Forms.Button searchButton;
      private System.Windows.Forms.Button searchAll;
      private System.Windows.Forms.TextBox firstName;
      private System.Windows.Forms.TextBox lastName;
      private System.Windows.Forms.TextBox address;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DataGridView dataGrid;
   }
}

