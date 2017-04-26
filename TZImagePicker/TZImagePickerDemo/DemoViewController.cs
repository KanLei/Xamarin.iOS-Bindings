using System;
using UIKit;
using Foundation;
using CoreGraphics;
using TZImagePicker;
using System.Diagnostics;
using Photos;
using AVFoundation;
using System.IO;
using CoreMedia;

namespace TZImagePickerDemo
{
    public class DemoViewController : UIViewController
    {
        private PickerDelegate pickerDelegate;

        public DemoViewController ()
        {
            pickerDelegate = new PickerDelegate ();
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var btn = new UIButton (new CGRect (100, 100, 100, 100));
            btn.SetTitleColor (UIColor.Black, UIControlState.Normal);
            btn.SetTitle ("take photo", UIControlState.Normal);
            btn.BackgroundColor = UIColor.White;
            Add (btn);

            btn.TouchUpInside += (sender, e) =>
            {
                var imagePicker = new TZImagePickerController (9, pickerDelegate);

                Debug.WriteLine ($"AllowTakePicture: {imagePicker.AllowTakePicture}");
                Debug.WriteLine ($"AllowPickingImage: {imagePicker.AllowPickingImage}");
                Debug.WriteLine ($"AllowPickingVideo: {imagePicker.AllowPickingVideo}");
                Debug.WriteLine ($"AllowPickingOriginalPhoto: {imagePicker.AllowPickingOriginalPhoto}");
                Debug.WriteLine ($"SortAscendingByModificationDate: {imagePicker.SortAscendingByModificationDate}");
                Debug.WriteLine ($"PhotoPreviewMaxWidth: {imagePicker.PhotoPreviewMaxWidth}");
                Debug.WriteLine ($"PhotoWidth: {imagePicker.PhotoWidth}");


                imagePicker.AllowPickingVideo = false;
                imagePicker.AllowPickingOriginalPhoto = false;
                imagePicker.SortAscendingByModificationDate = false;

                // 设置导航条的文字颜色
                imagePicker.NavigationBar.TintColor = UIColor.Black;

                imagePicker.OKButtonTitleColorNormal = UIColor.Red;
                imagePicker.OKButtonTitleColorDisabled = UIColor.LightGray;

               

                this.PresentViewController (imagePicker, true, () => { });
            };

            var btnTakeVideo = new UIButton (new CGRect (100, 250, 100, 100));
            btnTakeVideo.SetTitleColor (UIColor.Black, UIControlState.Normal);
            btnTakeVideo.SetTitle ("take video", UIControlState.Normal);
            btnTakeVideo.BackgroundColor = UIColor.White;
            Add (btnTakeVideo);

            btnTakeVideo.TouchUpInside += (sender, e) =>
            {
                var imagePicker = new TZImagePickerController (9, pickerDelegate);

                imagePicker.AllowPickingImage = false;
                imagePicker.AllowTakePicture = false;
                imagePicker.AllowPickingVideo = true;
                //imagePicker.AllowPickingOriginalPhoto = false;
                imagePicker.SortAscendingByModificationDate = false;

                imagePicker.MiniDuration = 0.0f;
                imagePicker.MaxDuration = 30.0f;

                // 设置导航条的文字颜色
                //imagePicker.NavigationBar.TintColor = UIColor.Black;

                //imagePicker.OKButtonTitleColorNormal = UIColor.Red;
                //imagePicker.OKButtonTitleColorDisabled = UIColor.LightGray;

                this.PresentViewController (imagePicker, true, () => { });
            };
        }


        private class PickerDelegate : TZImagePickerControllerDelegate
        {
            public override void DidFinishPickingVideo (TZImagePickerController picker, UIImage coverImage, NSObject asset)
            {
                Debug.WriteLine ("DidFinishPickingVideo");
                var phasset = asset as PHAsset;
                Debug.WriteLine (phasset.SourceType);
                Debug.WriteLine (phasset.MediaType);
                Debug.WriteLine (phasset.Location);
                Debug.WriteLine (phasset.LocalIdentifier);

                PHImageManager.DefaultManager.RequestAvAsset (phasset,
                                                             new PHVideoRequestOptions (),
                                                             RequestAvAssetHandler);

            }

            private void RequestAvAssetHandler (AVAsset asset, AVAudioMix audioMix, NSDictionary info)
            {
                var videoUrl = (asset as AVUrlAsset).Url;
                //var temp3 = NSData.FromFile (videoUrl.AbsoluteString);
                var temp4 = NSData.FromUrl (videoUrl);
                string [] paths = NSSearchPath.GetDirectories (NSSearchPathDirectory.CachesDirectory, NSSearchPathDomain.User);
                string downloadPath = paths [0];
                var filePath = Path.Combine (downloadPath, Path.GetFileName (videoUrl.AbsoluteString));
                NSError error;
                bool saveResult = temp4.Save (filePath, NSDataWritingOptions.Atomic, out error);
                if (saveResult)
                {
                    Debug.WriteLine ("Save Success");
                    var url = NSUrl.FromFilename (filePath);
                    var avAsset = AVAsset.FromUrl (url);
                    CMTime duration = asset.Duration;
                }
                else
                {
                    Debug.WriteLine (error);
                }
            }

            public override void DidFinishPickingGifImage (TZImagePickerController picker, UIImage animatedImage, NSObject asset)
            {
                Debug.WriteLine ("DidFinishPickingGifImage");
            }

            public override void DidFinishPickingPhotos (TZImagePickerController picker, UIImage [] photos, NSObject [] assets, bool isSelectOriginalPhoto)
            {
                Debug.WriteLine ("DidFinishPickingPhotos");
            }

            public override void DidFinishPickingPhotos (TZImagePickerController picker, UIImage [] photos, NSObject [] assets, bool isSelectOriginalPhoto, NSDictionary [] infos)
            {
                Debug.WriteLine ("DidFinishPickingPhotos with infos");
            }

            public override void TakeVideo (TZImagePickerController picker)
            {
                Debug.WriteLine ("TakeVideo");
            }

            public override void ImagePickerControllerDidCancel (TZImagePickerController picker)
            {
                Debug.WriteLine ("ImagePickerControllerDidCancel");
            }

            public override void Tz_imagePickerControllerDidCancel (TZImagePickerController picker)
            {
                Debug.WriteLine ("Tz_imagePickerControllerDidCancel");
            }
        }
    }
}

