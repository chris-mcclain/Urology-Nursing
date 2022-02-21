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
    public partial class Medications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvCancerMeds.Visible = false;
            gvMensHealthMeds.Visible = false;
            gvUrinaryTractMeds.Visible = false;
        }

        protected void mnuMedications_MenuItemClick(object sender, MenuEventArgs e)
        {
             // Create a database connection. 
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbSQL1ConnectionString"].ConnectionString);

            if (mnuMedications.SelectedItem.Value == "Cancer")
            {
                // Create a SELECT statement.
                String select = "SELECT brandMedication, genericMedication, classification, condition, HCPCSCode, " +
                "medDescription FROM Medications AS M, MedicationClassifications AS MC, Conditions AS C " +
                "WHERE M.classificationID = MC.classificationID AND M.conditionID = C.conditionID AND " +
                "C.conditionCategory = 'Cancer' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvCancerMeds.DataSource = reader;
                gvCancerMeds.DataBind();

                gvCancerMeds.HeaderRow.Cells[0].Text = "Brand Name";
                gvCancerMeds.HeaderRow.Cells[1].Text = "Generic Name";
                gvCancerMeds.HeaderRow.Cells[2].Text = "Classification";
                gvCancerMeds.HeaderRow.Cells[3].Text = "Condition";
                gvCancerMeds.HeaderRow.Cells[4].Text = "HCPCS Code";
                gvCancerMeds.HeaderRow.Cells[5].Text = "Medication Description";

                gvCancerMeds.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuMedications.SelectedItem.Value == "MensHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT brandMedication, genericMedication, classification, condition, HCPCSCode, " +
                "medDescription FROM Medications AS M, MedicationClassifications AS MC, Conditions AS C " +
                "WHERE M.classificationID = MC.classificationID AND M.conditionID = C.conditionID AND " +
                "C.conditionCategory = 'MensHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvMensHealthMeds.DataSource = reader;
                gvMensHealthMeds.DataBind();

                gvMensHealthMeds.HeaderRow.Cells[0].Text = "Brand Name";
                gvMensHealthMeds.HeaderRow.Cells[1].Text = "Generic Name";
                gvMensHealthMeds.HeaderRow.Cells[2].Text = "Classification";
                gvMensHealthMeds.HeaderRow.Cells[3].Text = "Condition";
                gvMensHealthMeds.HeaderRow.Cells[4].Text = "HCPCS Code";
                gvMensHealthMeds.HeaderRow.Cells[5].Text = "Medication Description";

                gvMensHealthMeds.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            else if (mnuMedications.SelectedItem.Value == "UrinaryTractHealth")
            {
                // Create a SELECT statement.
                String select = "SELECT brandMedication, genericMedication, classification, condition, HCPCSCode, " +
                "medDescription FROM Medications AS M, MedicationClassifications AS MC, Conditions AS C " +
                "WHERE M.classificationID = MC.classificationID AND M.conditionID = C.conditionID AND " +
                "C.conditionCategory = 'UrinaryTractHealth' ";

                // Create a command object.
                SqlCommand cmdSelect = new SqlCommand(select, connection);

                // Create a data reader.
                SqlDataReader reader;

                // Open the database connection.
                connection.Open();

                // Execute the SELECT command. 
                reader = cmdSelect.ExecuteReader(CommandBehavior.CloseConnection);

                // Display employees hired within a specified range in a GridView control.
                gvUrinaryTractMeds.DataSource = reader;
                gvUrinaryTractMeds.DataBind();

                gvUrinaryTractMeds.HeaderRow.Cells[0].Text = "Brand Name";
                gvUrinaryTractMeds.HeaderRow.Cells[1].Text = "Generic Name";
                gvUrinaryTractMeds.HeaderRow.Cells[2].Text = "Classification";
                gvUrinaryTractMeds.HeaderRow.Cells[3].Text = "Condition";
                gvUrinaryTractMeds.HeaderRow.Cells[4].Text = "HCPCS Code";
                gvUrinaryTractMeds.HeaderRow.Cells[5].Text = "Medication Description";

                gvUrinaryTractMeds.Visible = true;

                // Discard the command object and database connection.
                cmdSelect.Dispose();
                connection.Dispose();
            }
            
        }
    }
}