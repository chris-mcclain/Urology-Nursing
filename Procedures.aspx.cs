using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace UrologyNursing
{
    public partial class Procedures : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCancerProcedures.Visible = false;
            gvMensHealthProcedures.Visible = false;
            gvUrinaryTractProcedures.Visible = false;
            gvUrogynecologyProcedures.Visible = false;
        }

        protected void mnuProcedures_MenuItemClick(object sender, MenuEventArgs e)
        {
            // Create a database connection. 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

            if (mnuProcedures.SelectedItem.Value == "Cancer")
            {
                // Create a SELECT statement.
                String select = "SELECT procedureName, CPTCode, procedureDescription FROM Surgeries WHERE conditionCategory = 'Cancer' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvCancerProcedures.DataSource = reader;
                gvCancerProcedures.DataBind();

                gvCancerProcedures.HeaderRow.Cells[0].Text = "Procedure";
                gvCancerProcedures.HeaderRow.Cells[1].Text = "CPT Code";
                gvCancerProcedures.HeaderRow.Cells[2].Text = "Description";

                gvCancerProcedures.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuProcedures.SelectedItem.Value == "MensHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT procedureName, CPTCode, procedureDescription FROM Surgeries WHERE conditionCategory = 'MensHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvMensHealthProcedures.DataSource = reader;
                gvMensHealthProcedures.DataBind();

                gvMensHealthProcedures.HeaderRow.Cells[0].Text = "Procedure";
                gvMensHealthProcedures.HeaderRow.Cells[1].Text = "CPT Code";
                gvMensHealthProcedures.HeaderRow.Cells[2].Text = "Description";

                gvMensHealthProcedures.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuProcedures.SelectedItem.Value == "UrinaryTractHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT procedureName, CPTCode, procedureDescription FROM Surgeries WHERE conditionCategory = 'UrinaryTractHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvUrinaryTractProcedures.DataSource = reader;
                gvUrinaryTractProcedures.DataBind();

                gvUrinaryTractProcedures.HeaderRow.Cells[0].Text = "Procedure";
                gvUrinaryTractProcedures.HeaderRow.Cells[1].Text = "CPT Code";
                gvUrinaryTractProcedures.HeaderRow.Cells[2].Text = "Description";

                gvUrinaryTractProcedures.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuProcedures.SelectedItem.Value == "Urogynecology")
            {
                // Create a SELECT statement.
                String select = "SELECT procedureName, CPTCode, procedureDescription FROM Surgeries WHERE conditionCategory = 'Urogynecology' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvUrogynecologyProcedures.DataSource = reader;
                gvUrogynecologyProcedures.DataBind();

                gvUrogynecologyProcedures.HeaderRow.Cells[0].Text = "Procedure";
                gvUrogynecologyProcedures.HeaderRow.Cells[1].Text = "CPT Code";
                gvUrogynecologyProcedures.HeaderRow.Cells[2].Text = "Description";

                gvUrogynecologyProcedures.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }            
        }       
    }
}