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
    public partial class Conditions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCancer.Visible = false;
            gvMensHealth.Visible = false;
            gvUrinaryTractHealth.Visible = false;
            gvUrogynecology.Visible = false;
        }

        protected void mnuConditions_MenuItemClick(object sender, MenuEventArgs e)
        {
            // Create a database connection. 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

            if (mnuConditions.SelectedItem.Value == "Cancer")
            {
                // Create a SELECT statement.
                String select = "SELECT condition, ICD10Code, conditionDescription FROM Conditions WHERE conditionCategory = 'Cancer' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvCancer.DataSource = reader;
                gvCancer.DataBind();

                gvCancer.HeaderRow.Cells[0].Text = "Condition";
                gvCancer.HeaderRow.Cells[1].Text = "ICD-10 Code";
                gvCancer.HeaderRow.Cells[2].Text = "Description";

                gvCancer.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuConditions.SelectedItem.Value == "MensHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT condition, ICD10Code, conditionDescription FROM Conditions WHERE conditionCategory = 'MensHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvMensHealth.DataSource = reader;
                gvMensHealth.DataBind();

                gvMensHealth.HeaderRow.Cells[0].Text = "Condition";
                gvMensHealth.HeaderRow.Cells[1].Text = "ICD-10 Code";
                gvMensHealth.HeaderRow.Cells[2].Text = "Description";

                gvMensHealth.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuConditions.SelectedItem.Value == "UrinaryTractHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT condition, ICD10Code, conditionDescription FROM Conditions WHERE conditionCategory = 'UrinaryTractHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvUrinaryTractHealth.DataSource = reader;
                gvUrinaryTractHealth.DataBind();

                gvUrinaryTractHealth.HeaderRow.Cells[0].Text = "Condition";
                gvUrinaryTractHealth.HeaderRow.Cells[1].Text = "ICD-10 Code";
                gvUrinaryTractHealth.HeaderRow.Cells[2].Text = "Description";

                gvUrinaryTractHealth.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuConditions.SelectedItem.Value == "Urogynecology")
            {
                // Create a SELECT statement.
                String select = "SELECT condition, ICD10Code, conditionDescription FROM Conditions WHERE conditionCategory = 'Urogynecology' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvUrogynecology.DataSource = reader;
                gvUrogynecology.DataBind();

                gvUrogynecology.HeaderRow.Cells[0].Text = "Condition";
                gvUrogynecology.HeaderRow.Cells[1].Text = "ICD-10 Code";
                gvUrogynecology.HeaderRow.Cells[2].Text = "Description";

                gvUrogynecology.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            
        }

    }
}