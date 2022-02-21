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
    public partial class TerminologyE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Create a SELECT statement.
            String select = "SELECT term, termDefinition FROM Terminology WHERE term LIKE 'E%' ORDER BY term";

            // Create a database connection.
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

            // Create a command object.
            SqlCommand cmdSelect = new SqlCommand(select, connection);

            // Create a data reader.
            SqlDataReader terms;

            // Open the database connection.
            connection.Open();

            // Execute the SELECT command. 
            terms = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

            // Display employees hired within a specified range in a GridView control.
            gvE.DataSource = terms;
            gvE.DataBind();

            gvE.HeaderRow.Cells[0].Text = "Term";
            gvE.HeaderRow.Cells[1].Text = "Definition";

            // Discard the command object and database connection.
            cmdSelect.Dispose();
            connection.Dispose();
        }
    }
}