using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testDeploy.Controllers;
//using testDeploy.DataDefinitions;
using testDeploy.ServiceReference1;

namespace testDeploy
{
    public partial class ViewData : System.Web.UI.Page
    {
        //Fields
        TableRow headers;

        //Executes on page load
        protected void Page_Load(object sender, EventArgs e)
        {
            //Initialize table headers
            headers = new TableRow();
            TableCell idCell, valueCell, timestampCell;
            idCell = new TableCell();
            idCell.Text = "ID";
            valueCell = new TableCell();
            valueCell.Text = "Value";
            timestampCell = new TableCell();
            timestampCell.Text = "Timestamp";
            headers.Cells.Add(idCell);
            headers.Cells.Add(valueCell);
            headers.Cells.Add(timestampCell);
            //Populate Table
            RefreshTable();
        }


        //Processes a refresh button click event
        protected void RefreshDataButtonClick(object sender, EventArgs e)
        {
            RefreshTable();
        }

        //Populates the table with records
        protected void RefreshTable()
        {
            DataTable.Rows.Clear();
            List<Record> records = MainController.RetrieveAllRecords();
            TableRow row;
            TableCell idCell, valueCell, timestampCell;
            //Add headers
            DataTable.Rows.Add(headers);
            //Add data
            for (int i = records.Count - 1; i >= 0; i--)
            {
                row = new TableRow();
                idCell = new TableCell();
                idCell.Text = records[i].id;
                valueCell = new TableCell();
                valueCell.Text = records[i].value.ToString();
                timestampCell = new TableCell();
                timestampCell.Text = records[i].dateTime.ToString();
                row.Cells.Add(idCell);
                row.Cells.Add(valueCell);
                row.Cells.Add(timestampCell);
                DataTable.Rows.Add(row);
            }
        }

    }
}