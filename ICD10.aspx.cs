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
    public partial class ICD10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlICD10Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlICD10Code.SelectedIndex > 0)
            {
                // Create a SELECT statement.
                String select = "SELECT ICD10Code FROM Conditions WHERE conditionID =  " + ddlICD10Code.SelectedValue;

                // Create a database connection.
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbUrologyConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader drICD10Code;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                drICD10Code = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                while (drICD10Code.Read())
                {
                    // Display the ICD-10 code associated with the chosen diagnosis.
                    lblICD10Code.Text = drICD10Code["ICD10Code"].ToString();
                }

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();

                lblICD10Code.Visible = true;
            }
        }
    }
}