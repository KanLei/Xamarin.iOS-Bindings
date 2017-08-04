using System;
using UIKit;
using Foundation;
using CoreGraphics;

using MJRefresh;
using System.Threading.Tasks;

namespace MJRefreshDemo
{
    public class DemoViewController : UITableViewController
    {
        public DemoViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var refresh = new MJRefreshNormalHeader();
            refresh.RefreshingBlock = async () =>
                        {
                            await Task.Delay(3000);
                            refresh.EndRefreshing();
                        };
            TableView.SetMJHeader(refresh);

            TableView.Source = new TableSource(TableView);
        }

        private class TableSource : UITableViewSource
        {
            public TableSource(UITableView tableView)
            {
                tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "cell");
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell("cell", indexPath) as UITableViewCell;
                cell.TextLabel.Text = indexPath.Row.ToString();
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return 50;
            }
        }
    }
}
