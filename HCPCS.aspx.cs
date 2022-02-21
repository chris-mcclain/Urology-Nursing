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
    public partial class HCPCS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlSupply_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlSupply.SelectedIndex > 0)
            {
                // Create a SELECT statement.
                String select = "SELECT HCPCSCode FROM Supplies WHERE supplyID =  " + ddlSupply.SelectedValue;

                // Create a database connection.
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader drSupplyHCPCS;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                drSupplyHCPCS = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                while (drSupplyHCPCS.Read())
                {
                    // Display the ICD-10 code associated with the chosen diagnosis.
                    lblSupplyHCPCS.Text = drSupplyHCPCS["HCPCSCode"].ToString();
                }

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();

                lblSupplyHCPCS.Visible = true;
            }
        }

        protected void ddlMedication_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Create a SELECT statement.
            String select = "SELECT HCPCSCode FROM Medications WHERE medicationID =  " + ddlMedication.SelectedValue;

            // Create a database connection.
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

            // Create a command object.
            SqlCommand cmdSelect = new SqlCommand(select, connection);

            // Create a data reader.
            SqlDataReader drMedicationHCPCS;

            // Open the database connection.
            connection.Open();

            // Execute the SELECT command. 
            drMedicationHCPCS = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

            while (drMedicationHCPCS.Read())
            {
                // Display the ICD-10 code associated with the chosen diagnosis.
                lblMedicationHCPCS.Text = drMedicationHCPCS["HCPCSCode"].ToString();
            }

            // Discard the command object and database connection.
            cmdSelect.Dispose();
            connection.Dispose();

            lblMedicationHCPCS.Visible = true;
        }
    }
}