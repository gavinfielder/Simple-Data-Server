using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using testDeploy.Controllers;
using testDeploy.DataDefinitions;

namespace testDeploy
{
    public partial class ViewData : System.Web.UI.Page
    {
        //Executes on page load
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        /*
        //TODO: This was intended to avoid memory leaks, but it seems it runs when the server releases the memory, meaning
        //that it unsubscribes right after subscribing
        protected void Page_Unload(object sender, EventArgs e)
        {
            MainController.Unsubscribe(this);
        }
        */

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
            foreach (Record r in records)
            {
                row = new TableRow();
                idCell = new TableCell();
                idCell.Text = r.id;
                valueCell = new TableCell();
                valueCell.Text = r.value.ToString();
                timestampCell = new TableCell();
                timestampCell.Text = r.dateTime.ToString();
                row.Cells.Add(idCell);
                row.Cells.Add(valueCell);
                row.Cells.Add(timestampCell);
                DataTable.Rows.Add(row);
            }
        }
        
    }
}