using System;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Photos;
using UIKit;

namespace TZImagePicker
{
    // @interface TZAssetModel : NSObject
    [BaseType (typeof (NSObject))]
    interface TZAssetModel
    {
        // @property (nonatomic, strong) id asset;
        [Export ("asset", ArgumentSemantic.Strong)]
        NSObject Asset { get; set; }

        // @property (assign, nonatomic) BOOL isSelected;
        [Export ("isSelected")]
        bool IsSelected { get; set; }

        // @property (assign, nonatomic) TZAssetModelMediaType type;
        [Export ("type", ArgumentSemantic.Assign)]
        TZAssetModelMediaType Type { get; set; }

        // @property (copy, nonatomic) NSString * timeLength;
        [Export ("timeLength")]
        string TimeLength { get; set; }

        // +(instancetype)modelWithAsset:(id)asset type:(TZAssetModelMediaType)type;
        [Static]
        [Export ("modelWithAsset:type:")]
        TZAssetModel ModelWithAsset (NSObject asset, TZAssetModelMediaType type);

        // +(instancetype)modelWithAsset:(id)asset type:(TZAssetModelMediaType)type timeLength:(NSString *)timeLength;
        [Static]
        [Export ("modelWithAsset:type:timeLength:")]
        TZAssetModel ModelWithAsset (NSObject asset, TZAssetModelMediaType type, string timeLength);
    }

    // @interface TZAlbumModel : NSObject
    [BaseType (typeof (NSObject))]
    interface TZAlbumModel
    {
        // @property (nonatomic, strong) NSString * name;
        [Export ("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (assign, nonatomic) NSInteger count;
        [Export ("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) id result;
        [Export ("result", ArgumentSemantic.Strong)]
        NSObject Result { get; set; }

        // @property (nonatomic, strong) NSArray * models;
        [Export ("models", ArgumentSemantic.Strong)]
        NSObject [] Models { get; set; }

        // @property (nonatomic, strong) NSArray * selectedModels;
        [Export ("selectedModels", ArgumentSemantic.Strong)]
        NSObject [] SelectedModels { get; set; }

        // @property (assign, nonatomic) NSUInteger selectedCount;
        [Export ("selectedCount")]
        nuint SelectedCount { get; set; }
    }

    // @interface TZImagePicker (NSBundle)
    [Category]
    [BaseType (typeof (NSBundle))]
    interface NSBundle_TZImagePicker
    {
        // +(NSString *)tz_localizedStringForKey:(NSString *)key value:(NSString *)value;
        [Static]
        [Export ("tz_localizedStringForKey:value:")]
        string Tz_localizedStringForKey (string key, string value);

        // +(NSString *)tz_localizedStringForKey:(NSString *)key;
        [Static]
        [Export ("tz_localizedStringForKey:")]
        string Tz_localizedStringForKey (string key);
    }

    // @interface TZImagePickerController : UINavigationController
    [BaseType (typeof (UINavigationController))]
    interface TZImagePickerController
    {
        // -(instancetype)initWithMaxImagesCount:(NSInteger)maxImagesCount delegate:(id<TZImagePickerControllerDelegate>)delegate;
        [Export ("initWithMaxImagesCount:delegate:")]
        IntPtr Constructor (nint maxImagesCount, TZImagePickerControllerDelegate @delegate);

        // -(instancetype)initWithMaxImagesCount:(NSInteger)maxImagesCount columnNumber:(NSInteger)columnNumber delegate:(id<TZImagePickerControllerDelegate>)delegate;
        [Export ("initWithMaxImagesCount:columnNumber:delegate:")]
        IntPtr Constructor (nint maxImagesCount, nint columnNumber, TZImagePickerControllerDelegate @delegate);

        // -(instancetype)initWithMaxImagesCount:(NSInteger)maxImagesCount columnNumber:(NSInteger)columnNumber delegate:(id<TZImagePickerControllerDelegate>)delegate pushPhotoPickerVc:(BOOL)pushPhotoPickerVc;
        [Export ("initWithMaxImagesCount:columnNumber:delegate:pushPhotoPickerVc:")]
        IntPtr Constructor (nint maxImagesCount, nint columnNumber, TZImagePickerControllerDelegate @delegate, bool pushPhotoPickerVc);

        // -(instancetype)initWithSelectedAssets:(NSMutableArray *)selectedAssets selectedPhotos:(NSMutableArray *)selectedPhotos index:(NSInteger)index;
        [Export ("initWithSelectedAssets:selectedPhotos:index:")]
        IntPtr Constructor (NSMutableArray selectedAssets, NSMutableArray selectedPhotos, nint index);

        // -(instancetype)initCropTypeWithAsset:(id)asset photo:(UIImage *)photo completion:(void (^)(UIImage *, id))completion;
        [Export ("initCropTypeWithAsset:photo:completion:")]
        IntPtr Constructor (NSObject asset, UIImage photo, Action<UIImage, NSObject> completion);

        // @property (assign, nonatomic) NSInteger maxImagesCount;
        [Export ("maxImagesCount")]
        nint MaxImagesCount { get; set; }

        // @property (assign, nonatomic) NSInteger minImagesCount;
        [Export ("minImagesCount")]
        nint MinImagesCount { get; set; }

        // @property (assign, nonatomic) BOOL alwaysEnableDoneBtn;
        [Export ("alwaysEnableDoneBtn")]
        bool AlwaysEnableDoneBtn { get; set; }

        // @property (assign, nonatomic) BOOL sortAscendingByModificationDate;
        [Export ("sortAscendingByModificationDate")]
        bool SortAscendingByModificationDate { get; set; }

        // @property (assign, nonatomic) CGFloat photoWidth;
        [Export ("photoWidth")]
        nfloat PhotoWidth { get; set; }

        // @property (assign, nonatomic) CGFloat photoPreviewMaxWidth;
        [Export ("photoPreviewMaxWidth")]
        nfloat PhotoPreviewMaxWidth { get; set; }

        // @property (assign, nonatomic) NSInteger timeout;
        [Export ("timeout")]
        nint Timeout { get; set; }

        // @property (assign, nonatomic) BOOL allowPickingOriginalPhoto;
        [Export ("allowPickingOriginalPhoto")]
        bool AllowPickingOriginalPhoto { get; set; }

        // @property (assign, nonatomic) BOOL allowPickingVideo;
        [Export ("allowPickingVideo")]
        bool AllowPickingVideo { get; set; }

        // @property (assign, nonatomic) CGFloat miniDuration;
        [Export ("miniDuration")]
        nfloat MiniDuration { get; set; }

        // @property (assign, nonatomic) CGFloat maxDuration;
        [Export ("maxDuration")]
        nfloat MaxDuration { get; set; }

        // @property (assign, nonatomic) BOOL allowPickingGif;
        [Export ("allowPickingGif")]
        bool AllowPickingGif { get; set; }

        // @property (assign, nonatomic) BOOL allowPickingImage;
        [Export ("allowPickingImage")]
        bool AllowPickingImage { get; set; }

        // @property (assign, nonatomic) BOOL allowTakePicture;
        [Export ("allowTakePicture")]
        bool AllowTakePicture { get; set; }

        // @property (assign, nonatomic) BOOL allowPreview;
        [Export ("allowPreview")]
        bool AllowPreview { get; set; }

        // @property (assign, nonatomic) BOOL autoDismiss;
        [Export ("autoDismiss")]
        bool AutoDismiss { get; set; }

        // @property (nonatomic, strong) NSMutableArray * selectedAssets;
        [Export ("selectedAssets", ArgumentSemantic.Strong)]
        NSMutableArray SelectedAssets { get; set; }

        // @property (nonatomic, strong) NSMutableArray<TZAssetModel *> * selectedModels;
        //[Export ("selectedModels", ArgumentSemantic.Strong)]
        //NSMutableArray<TZAssetModel> SelectedModels { get; set; }

        // @property (assign, nonatomic) NSInteger minPhotoWidthSelectable;
        [Export ("minPhotoWidthSelectable")]
        nint MinPhotoWidthSelectable { get; set; }

        // @property (assign, nonatomic) NSInteger minPhotoHeightSelectable;
        [Export ("minPhotoHeightSelectable")]
        nint MinPhotoHeightSelectable { get; set; }

        // @property (assign, nonatomic) BOOL hideWhenCanNotSelect;
        [Export ("hideWhenCanNotSelect")]
        bool HideWhenCanNotSelect { get; set; }

        // @property (assign, nonatomic) BOOL showSelectBtn;
        [Export ("showSelectBtn")]
        bool ShowSelectBtn { get; set; }

        // @property (assign, nonatomic) BOOL allowCrop;
        [Export ("allowCrop")]
        bool AllowCrop { get; set; }

        // @property (assign, nonatomic) CGRect cropRect;
        [Export ("cropRect", ArgumentSemantic.Assign)]
        CGRect CropRect { get; set; }

        // @property (assign, nonatomic) BOOL needCircleCrop;
        [Export ("needCircleCrop")]
        bool NeedCircleCrop { get; set; }

        // @property (assign, nonatomic) NSInteger circleCropRadius;
        [Export ("circleCropRadius")]
        nint CircleCropRadius { get; set; }

        // @property (copy, nonatomic) void (^cropViewSettingBlock)(UIView *);
        [Export ("cropViewSettingBlock", ArgumentSemantic.Copy)]
        Action<UIView> CropViewSettingBlock { get; set; }

        // -(void)showAlertWithTitle:(NSString *)title;
        [Export ("showAlertWithTitle:")]
        void ShowAlertWithTitle (string title);

        // -(void)showProgressHUD;
        [Export ("showProgressHUD")]
        void ShowProgressHUD ();

        // -(void)hideProgressHUD;
        [Export ("hideProgressHUD")]
        void HideProgressHUD ();

        // @property (assign, nonatomic) BOOL isSelectOriginalPhoto;
        [Export ("isSelectOriginalPhoto")]
        bool IsSelectOriginalPhoto { get; set; }

        // @property (copy, nonatomic) NSString * takePictureImageName;
        [Export ("takePictureImageName")]
        string TakePictureImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoSelImageName;
        [Export ("photoSelImageName")]
        string PhotoSelImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoDefImageName;
        [Export ("photoDefImageName")]
        string PhotoDefImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoOriginSelImageName;
        [Export ("photoOriginSelImageName")]
        string PhotoOriginSelImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoOriginDefImageName;
        [Export ("photoOriginDefImageName")]
        string PhotoOriginDefImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoPreviewOriginDefImageName;
        [Export ("photoPreviewOriginDefImageName")]
        string PhotoPreviewOriginDefImageName { get; set; }

        // @property (copy, nonatomic) NSString * photoNumberIconImageName;
        [Export ("photoNumberIconImageName")]
        string PhotoNumberIconImageName { get; set; }

        // @property (nonatomic, strong) UIColor * oKButtonTitleColorNormal;
        [Export ("oKButtonTitleColorNormal", ArgumentSemantic.Strong)]
        UIColor OKButtonTitleColorNormal { get; set; }

        // @property (nonatomic, strong) UIColor * oKButtonTitleColorDisabled;
        [Export ("oKButtonTitleColorDisabled", ArgumentSemantic.Strong)]
        UIColor OKButtonTitleColorDisabled { get; set; }

        // @property (nonatomic, strong) UIColor * barItemTextColor;
        [Export ("barItemTextColor", ArgumentSemantic.Strong)]
        UIColor BarItemTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * barItemTextFont;
        [Export ("barItemTextFont", ArgumentSemantic.Strong)]
        UIFont BarItemTextFont { get; set; }

        // @property (copy, nonatomic) NSString * doneBtnTitleStr;
        [Export ("doneBtnTitleStr")]
        string DoneBtnTitleStr { get; set; }

        // @property (copy, nonatomic) NSString * cancelBtnTitleStr;
        [Export ("cancelBtnTitleStr")]
        string CancelBtnTitleStr { get; set; }

        // @property (copy, nonatomic) NSString * previewBtnTitleStr;
        [Export ("previewBtnTitleStr")]
        string PreviewBtnTitleStr { get; set; }

        // @property (copy, nonatomic) NSString * fullImageBtnTitleStr;
        [Export ("fullImageBtnTitleStr")]
        string FullImageBtnTitleStr { get; set; }

        // @property (copy, nonatomic) NSString * settingBtnTitleStr;
        [Export ("settingBtnTitleStr")]
        string SettingBtnTitleStr { get; set; }

        // @property (copy, nonatomic) NSString * processHintStr;
        [Export ("processHintStr")]
        string ProcessHintStr { get; set; }

        // -(void)cancelButtonClick;
        [Export ("cancelButtonClick")]
        void CancelButtonClick ();

        // @property (copy, nonatomic) void (^didFinishPickingPhotosHandle)(NSArray<UIImage *> *, NSArray *, BOOL);
        [Export ("didFinishPickingPhotosHandle", ArgumentSemantic.Copy)]
        Action<NSArray<UIImage>, NSArray, bool> DidFinishPickingPhotosHandle { get; set; }

        // @property (copy, nonatomic) void (^didFinishPickingPhotosWithInfosHandle)(NSArray<UIImage *> *, NSArray *, BOOL, NSArray<NSDictionary *> *);
        [Export ("didFinishPickingPhotosWithInfosHandle", ArgumentSemantic.Copy)]
        Action<NSArray<UIImage>, NSArray, bool, NSArray<NSDictionary>> DidFinishPickingPhotosWithInfosHandle { get; set; }

        // @property (copy, nonatomic) void (^imagePickerControllerDidCancelHandle)();
        [Export ("imagePickerControllerDidCancelHandle", ArgumentSemantic.Copy)]
        Action ImagePickerControllerDidCancelHandle { get; set; }

        // @property (copy, nonatomic) void (^didFinishPickingVideoHandle)(UIImage *, id);
        [Export ("didFinishPickingVideoHandle", ArgumentSemantic.Copy)]
        Action<UIImage, NSObject> DidFinishPickingVideoHandle { get; set; }

        // @property (copy, nonatomic) void (^didFinishPickingGifImageHandle)(UIImage *, id);
        [Export ("didFinishPickingGifImageHandle", ArgumentSemantic.Copy)]
        Action<UIImage, NSObject> DidFinishPickingGifImageHandle { get; set; }

        [Wrap ("WeakPickerDelegate")]
        TZImagePickerControllerDelegate PickerDelegate { get; set; }

        // @property (nonatomic, weak) id<TZImagePickerControllerDelegate> pickerDelegate;
        [NullAllowed, Export ("pickerDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPickerDelegate { get; set; }
    }

    // @protocol TZImagePickerControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof (NSObject))]
    interface TZImagePickerControllerDelegate
    {
        // @optional -(void)imagePickerController:(TZImagePickerController *)picker didFinishPickingPhotos:(NSArray<UIImage *> *)photos sourceAssets:(NSArray *)assets isSelectOriginalPhoto:(BOOL)isSelectOriginalPhoto;
        [Export ("imagePickerController:didFinishPickingPhotos:sourceAssets:isSelectOriginalPhoto:")]
        void DidFinishPickingPhotos (TZImagePickerController picker, UIImage [] photos, NSObject [] assets, bool isSelectOriginalPhoto);

        // @optional -(void)imagePickerController:(TZImagePickerController *)picker didFinishPickingPhotos:(NSArray<UIImage *> *)photos sourceAssets:(NSArray *)assets isSelectOriginalPhoto:(BOOL)isSelectOriginalPhoto infos:(NSArray<NSDictionary *> *)infos;
        [Export ("imagePickerController:didFinishPickingPhotos:sourceAssets:isSelectOriginalPhoto:infos:")]
        void DidFinishPickingPhotos (TZImagePickerController picker, UIImage [] photos, NSObject [] assets, bool isSelectOriginalPhoto, NSDictionary [] infos);

        // @optional -(void)imagePickerControllerDidCancel:(TZImagePickerController *)picker __attribute__((deprecated("Use -tz_imagePickerControllerDidCancel:.")));
        [Export ("imagePickerControllerDidCancel:")]
        void ImagePickerControllerDidCancel (TZImagePickerController picker);

        // @optional -(void)tz_imagePickerControllerDidCancel:(TZImagePickerController *)picker;
        [Export ("tz_imagePickerControllerDidCancel:")]
        void Tz_imagePickerControllerDidCancel (TZImagePickerController picker);

        // @optional -(void)imagePickerController:(TZImagePickerController *)picker didFinishPickingVideo:(UIImage *)coverImage sourceAssets:(id)asset;
        [Export ("imagePickerController:didFinishPickingVideo:sourceAssets:")]
        void DidFinishPickingVideo (TZImagePickerController picker, UIImage coverImage, NSObject asset);

        // @optional -(void)imagePickerController:(TZImagePickerController *)picker didFinishPickingGifImage:(UIImage *)animatedImage sourceAssets:(id)asset;
        [Export ("imagePickerController:didFinishPickingGifImage:sourceAssets:")]
        void DidFinishPickingGifImage (TZImagePickerController picker, UIImage animatedImage, NSObject asset);

        // @optional -(void)takeVideo:(TZImagePickerController *)picker;
        [Export ("takeVideo:")]
        void TakeVideo (TZImagePickerController picker);
    }

    // @interface TZAlbumPickerController : UIViewController
    [BaseType (typeof (UIViewController))]
    interface TZAlbumPickerController
    {
        // @property (assign, nonatomic) NSInteger columnNumber;
        [Export ("columnNumber")]
        nint ColumnNumber { get; set; }
    }

    // @interface MyBundle (UIImage)
    [Category]
    [BaseType (typeof (UIImage))]
    interface UIImage_MyBundle
    {
        // +(UIImage *)imageNamedFromMyBundle:(NSString *)name;
        [Static]
        [Export ("imageNamedFromMyBundle:")]
        UIImage ImageNamedFromMyBundle (string name);
    }

    // @interface TZPhotoPreviewCell : UICollectionViewCell
    [BaseType (typeof (UICollectionViewCell))]
    interface TZPhotoPreviewCell
    {
        // @property (nonatomic, strong) TZAssetModel * model;
        [Export ("model", ArgumentSemantic.Strong)]
        TZAssetModel Model { get; set; }

        // @property (copy, nonatomic) void (^singleTapGestureBlock)();
        [Export ("singleTapGestureBlock", ArgumentSemantic.Copy)]
        Action SingleTapGestureBlock { get; set; }

        // -(void)recoverSubviews;
        [Export ("recoverSubviews")]
        void RecoverSubviews ();
    }
}

