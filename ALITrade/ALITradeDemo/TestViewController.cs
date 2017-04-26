using System;
using ALITrade.iOS;
using Foundation;
using UIKit;

namespace ALITradeDemo
{
    enum kTableViewRowType
    {
        // 登录测试
        kTableViewRowTypeLogin = 0,
        // 退出登录测试
        kTableViewRowTypeLogout,
        // 电商交易测试
        kTableViewRowTypeTradeBiz,
        // 个人交易信息
        kTableViewRowTypePersonalBizInfo,
        // Webview绑定
        kTableViewRowTypeWebviewBinding,

        kTableViewRowTypeCount,
    };

    public class TestViewController : UITableViewController
    {
        public TestViewController ()
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            Title = "ALiTradeSDK 3.0";
            View.BackgroundColor = UIColor.White;

            TableView.Source = new TableSource ();
        }

        private class TableSource : UITableViewSource
        {
            public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell ("cell");
                cell = cell ?? new UITableViewCell (UITableViewCellStyle.Default, "cell");
                cell.TextLabel.TextAlignment = UITextAlignment.Center;
                return cell;
            }

            public override nint RowsInSection (UITableView tableview, nint section)
            {
                return (int)kTableViewRowType.kTableViewRowTypeCount;
            }

            public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
            {
                var row = (kTableViewRowType)indexPath.Row;
                string title = null;
                switch (row)
                {
                case kTableViewRowType.kTableViewRowTypeLogin:
                    {
                        title = @"登录测试";
                        break;
                    }

                case kTableViewRowType.kTableViewRowTypeLogout:
                    {
                        title = @"退出登录测试";
                        break;
                    }

                case kTableViewRowType.kTableViewRowTypeTradeBiz:
                    {
                        title = @"电商交易测试";
                        break;
                    }

                case kTableViewRowType.kTableViewRowTypePersonalBizInfo:
                    {
                        title = @"个人交易信息";

                        break;
                    }

                case kTableViewRowType.kTableViewRowTypeWebviewBinding:
                    {
                        title = @"Webview绑定";
                        break;
                    }

                default:
                    {
                        break;
                    }
                }
                cell.TextLabel.Text = title;
            }

            public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
            {
                kTableViewRowType row = (kTableViewRowType)indexPath.Row;
                switch (row)
                {
                case kTableViewRowType.kTableViewRowTypeLogin:
                    {
                        //// 主动调用登录接口
                        //var loginService = ALBBFix.LoginService;
                        //loginService.ShowLogin (UIApplication.SharedApplication.KeyWindow.RootViewController,
                        //                       (session) =>
                        //                       {

                        //                       },
                        //                       (error) =>
                        //                       {
                        //                           var alert = new UIAlertView (error.ToString (), null, null, "OK");
                        //                           alert.Show ();
                        //                       }
                        //                       , true);

                        break;
                    }
                // 登出 解除授权
                case kTableViewRowType.kTableViewRowTypeLogout:
                    //ALBBFix.LoginService.Logout ();
                    break;
                case kTableViewRowType.kTableViewRowTypeTradeBiz:
                    break;

                case kTableViewRowType.kTableViewRowTypePersonalBizInfo:
                    break;

                case kTableViewRowType.kTableViewRowTypeWebviewBinding:
                    AlibcTradePage page = AlibcTradePageFactory.Page ("http://s.click.taobao.com/t?e=m%3D2%26s%3D1jBWv7M6gTUcQipKwQzePOeEDrYVVa64LKpWJ%2Bin0XJRAdhuF14FMQTfn3Ee1bdjxq3IhSJN6GTIhnv1oNPKcIu1IsQeTOU265Sw8eKESWqqgdP%2BAKekAmlX8n%2F4fqv2WdvMW3csa5338r%2Bm48V%2FzcYOae24fhW0");
                    AlibcTradeSDK tradeSDK = AlibcTradeSDK.SharedInstance ();
                    IAlibcTradeService service = tradeSDK.TradeService;
                    var showParams = new AlibcTradeShowParams ();

                    //绑定WebView
                    var wvVC = new TestWebViewController ();
                    //@return 0标识跳转到手淘打开了,1标识用h5打开,-1标识出错
                    var res = service.WebView (wvVC, (UIWebView)wvVC.View, page, showParams, null, null, (obj) => { }, (obj) => { });
                    // @return 0标识跳转到手淘打开了,1标识用h5打开,-1标识出错
                    if (res == 1)
                    {
                    }
                    break;
                default:
                    {
                        break;
                    }
                }
                tableView.DeselectRow (indexPath, true);
            }
        }
    }
}

