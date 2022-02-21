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
    public partial class Terminology : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        //protected void btnA_Click(object sender, EventArgs e)
        //{
        //    // Create a SELECT statement.
        //    String select = "SELECT term, termDefinition FROM Terminology WHERE term LIKE 'A%' ORDER BY term";

        //    // Create a database connection.
        //    SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

        //    // Create a command object.
        //    SqlCommand cmdSelect = new SqlCommand(select, connection);

        //    // Create a data reader.
        //    SqlDataReader terms;

        //    // Open the database connection.
        //    connection.Open();

        //    // Execute the SELECT command. 
        //    terms = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

        //    // Display employees hired within a specified range in a GridView control.
        //    gvA.DataSource = terms;
        //    gvA.DataBind();

        //    gvA.HeaderRow.Cells[0].Text = "Term";
        //    gvA.HeaderRow.Cells[1].Text = "Definition";

        //    // Discard the command object and database connection.
        //    cmdSelect.Dispose();
        //    connection.Dispose();
        //   // gvA.Visible = true;
        //}

        //protected void btnB_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyB.aspx");
        //}

        //protected void btnC_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyC.aspx");
        //}

        //protected void btnD_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyD.aspx");
        //}

        //protected void btnE_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyE.aspx");
        //}

        //protected void btnF_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyF.aspx");
        //}

        //protected void btnG_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyG.aspx");
        //}

        //protected void btnH_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyH.aspx");
        //}

        //protected void btnI_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyI.aspx");
        //}

        //protected void btnJ_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyJ.aspx");
        //}

        //protected void btnK_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyK.aspx");
        //}

        //protected void btnL_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyL.aspx");
        //}

        //protected void btnM_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyM.aspx");
        //}

        //protected void btnN_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyN.aspx");
        //}

        //protected void btnO_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyO.aspx");
        //}

        //protected void btnP_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyP.aspx");
        //}

        //protected void btnQ_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyQ.aspx");
        //}

        //protected void btnR_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyR.aspx");
        //}

        //protected void btnS_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyS.aspx");
        //}

        //protected void btnT_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyT.aspx");
        //}

        //protected void btnU_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyU.aspx");
        //}

        //protected void btnV_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyV.aspx");
        //}

        //protected void btnW_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyW.aspx");
        //}

        //protected void btnX_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyX.aspx");
        //}

        //protected void btnY_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyY.aspx");
        //}

        //protected void btnZ_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("TerminologyZ.aspx");
        //}

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a SELECT statement.
                String select = "SELECT term, termDefinition FROM Terminology WHERE term LIKE @term ORDER BY term";

                // Create a database connection. 
                SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                cmdSelect.Parameters.AddWithValue("@term", txtSearch.Text);

                // Create a data reader.
                SqlDataReader terms;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                terms = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvSearch.DataSource = terms;
                gvSearch.DataBind();

                gvSearch.HeaderRow.Cells[0].Text = "Term";
                gvSearch.HeaderRow.Cells[1].Text = "Definition";

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            catch
            {
                string alert = txtSearch.Text + " was not found in the database";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alert + "');", true);
            }
        }   
    }
}