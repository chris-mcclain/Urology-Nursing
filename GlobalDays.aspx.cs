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
    public partial class GlobalDays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProcedure.SelectedIndex > 0)
            {
                // Create a SELECT statement.
                String strSelect = "SELECT globalDays FROM Surgeries WHERE procedureID =  " + ddlProcedure.SelectedValue;

                // Create a database connection.
                SqlConnection conSelect = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(strSelect, conSelect);

                // Create a data reader.
                SqlDataReader drGlobalDays;

                // Open the database connection.
                conSelect.Open();

                // Execute the SELECT command. 
                drGlobalDays = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                while (drGlobalDays.Read())
                {
                    // Display CPT code for the chosen imaging.
                    lblGlobalNumber.Text = drGlobalDays["globalDays"].ToString();
                }

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                conSelect.Dispose();

                lblGlobalNumber.Visible = true;
            }
        }
    }
}