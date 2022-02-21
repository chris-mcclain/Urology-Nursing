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
    public partial class CPT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlProcedure.SelectedIndex > 0)
            {
                // Create a SELECT statement.
                String strSelect = "SELECT CPTCode FROM Surgeries WHERE procedureID =  " + ddlProcedure.SelectedValue;

                // Create a database connection.
                SqlConnection conSelect = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(strSelect, conSelect);

                // Create a data reader.
                SqlDataReader drProcedureCPT;

                // Open the database connection.
                conSelect.Open();

                // Execute the SELECT command. 
                drProcedureCPT = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                while (drProcedureCPT.Read())
                {
                    // Display the CPT code for the chosen procedure.
                    lblProcedureCPT.Text = drProcedureCPT["CPTCode"].ToString();
                }

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                conSelect.Dispose();

                lblProcedureCPT.Visible = true;
            }
        }

        protected void ddlImaging_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlImaging.SelectedIndex > 0)
            {
                // Create a SELECT statement.
                String strSelect = "SELECT CPTCode FROM Imaging WHERE imagingID =  " + ddlImaging.SelectedValue;

                // Create a database connection.
                SqlConnection conSelect = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(strSelect, conSelect);

                // Create a data reader.
                SqlDataReader drImagingCPT;

                // Open the database connection.
                conSelect.Open();

                // Execute the SELECT command. 
                drImagingCPT = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                while (drImagingCPT.Read())
                {
                    // Display CPT code for the chosen imaging.
                    lblImagingCPT.Text = drImagingCPT["CPTCode"].ToString();
                }

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                conSelect.Dispose();

                lblImagingCPT.Visible = true;
            }
        }


    }
}