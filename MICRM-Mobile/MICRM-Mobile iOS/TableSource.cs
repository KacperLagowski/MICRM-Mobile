using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace MICRM_Mobile_iOS
{
    class TableSource : UITableView
    {
        protected string cellIdentifier = "TableCell";
        string[] tableItems = new string[] { "Vegetables", "Fruits", "Flower Buds", "Legumes", "Bulbs", "Tubers" };
        public TableSource(string[] items)
        {
            tableItems = items;
        }
        public int RowsInSection(UITableView tableview, int section)
        {
            return tableItems.Length;
        }
        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            // request a recycled cell to save memory
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
            // if there are no cells to reuse, create a new one
            if (cell == null)
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            cell.TextLabel.Text = tableItems[indexPath.Row];
            return cell;
        }

    }
}
