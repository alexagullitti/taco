using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TacoFormsApplication
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }
      //connect the database
      SqlConnection Connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gullitti\Documents\tacoDatabase.mdf;Integrated Security=True;Connect Timeout=30");


      private void updateButton_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrEmpty(firstName.Text) && string.IsNullOrEmpty(lastName.Text) && string.IsNullOrEmpty(address.Text))
         {
            MessageBox.Show("all Fields are empty please enter something");
         }
         else if(string.IsNullOrEmpty(firstName.Text))
         {
            MessageBox.Show("You must enter a first name to update that delivery");
         }
         else
         {
            string tempString = "Update Customers set";
            if (!string.IsNullOrEmpty(lastName.Text))
            {
               tempString += " lastName = '" + lastName.Text + "' ,";
            }
            if (!string.IsNullOrEmpty(address.Text))
            {
               tempString += " address = '" + address.Text + "'";
            }
            if (tempString.EndsWith(","))//removes ',' if at the end
            {
               tempString = tempString.Substring(0, tempString.Length - 1);
            }

            tempString += " where firstName = '" + firstName.Text + "'";

            try
            {
               SqlCommand sqlStatement = new SqlCommand(tempString, Connection);
               Connection.Open();
               sqlStatement.ExecuteNonQuery();
               MessageBox.Show("Delivery Successfully updated");
               Connection.Close();
            }
            catch
            {
               Connection.Close();
               MessageBox.Show("Please close application try again");
            }
         }
      }

      //searches for a specfic row
      private void searchButton_Click(object sender, EventArgs e)
      {
         string searchQuery = "Select * from Customers where ";
         if (!string.IsNullOrEmpty(firstName.Text))
         {
            searchQuery += " firstName = '" + firstName.Text + "' and";
         }
         if (!string.IsNullOrEmpty(lastName.Text))
         {
            searchQuery += " lastName = '" + lastName.Text + "' and";
         }
         if (!string.IsNullOrEmpty(address.Text))
         {
            searchQuery += " address = '" + address.Text + "'";
         }
         if (searchQuery.EndsWith("and"))//removes 'and' if at the end
         {
            searchQuery = searchQuery.Substring(0, searchQuery.Length - 3);
         }
         try
         {
            Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(searchQuery, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            Connection.Close();
         }
         catch
         {
            Connection.Close();
            MessageBox.Show("Please close application try again");
         }
      }
        

      //adds a new delivery
      private void addButton_Click(object sender, EventArgs e)
      {
         //make sure the primary key firstName is not empty
         if (string.IsNullOrEmpty(firstName.Text))
         {
            MessageBox.Show("Please enter a First Name");
         }
         else
         {
            //build the insert statement
            SqlCommand sqlStatement = new SqlCommand("insert into Customers values('" + firstName.Text + "','" + lastName.Text + "','" + address.Text + "')", Connection);
            try
            {
               Connection.Open();
               sqlStatement.ExecuteNonQuery();
               MessageBox.Show("Delivery Successfully added");
               Connection.Close();
            }
            catch
            {
               //close the connection if anything goes wrong
               Connection.Close();
               MessageBox.Show("Please check your entries, delivery was not scheduled");
            }
         }
      }
      
      //deletes a delivery
      private void deleteButton_Click(object sender, EventArgs e)
      {
         SqlCommand sqlStatement;
         //cannot delete if nothing is entered
         if (string.IsNullOrEmpty(firstName.Text) && string.IsNullOrEmpty(lastName.Text) && string.IsNullOrEmpty(address.Text))
         {
            MessageBox.Show("all Fields are empty please enter something");
         }
         else
         { // creates delete statement depending on input
            var tempString = "Delete from Customers where ";
            if (!string.IsNullOrEmpty(firstName.Text))
            {
               tempString += " firstName = '" + firstName.Text + "' and";
            }
            if (!string.IsNullOrEmpty(lastName.Text))
            {
               tempString += " lastName = '" + lastName.Text + "' and";
            }
            if (!string.IsNullOrEmpty(address.Text))
            {
               tempString += " address = '" + address.Text + "'";
            }
            if(tempString.EndsWith("and"))//removes 'and' if at the end
            {
               tempString = tempString.Substring(0, tempString.Length - 3);
            }
            
            try
                 {
                    sqlStatement = new SqlCommand(tempString, Connection);
                    Connection.Open();
                    sqlStatement.ExecuteNonQuery();
                    MessageBox.Show("Delivery Successfully Removed");
                    Connection.Close();
                 }
                 catch
                 {
                    Connection.Close();
                    MessageBox.Show("Please check your entries, delivery was not removed");
                 }
         }
      }

      //returns all rows
      private void searchAll_Click(object sender, EventArgs e)
      {
         try
         {
            Connection.Open();
            string query = "select * from Customers";
            SqlDataAdapter da = new SqlDataAdapter(query, Connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
            Connection.Close();
         }
         catch
         {
            Connection.Close();
            MessageBox.Show("Please close application try again");
         }
      }
   }
}
