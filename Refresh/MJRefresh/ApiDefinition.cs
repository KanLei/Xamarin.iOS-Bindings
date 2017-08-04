using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace MJRefresh
{
    // @interface MJRefresh (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_MJRefresh
    {
        // @property (nonatomic, strong) MJRefreshHeader * mj_header;
        [Export("mj_header", ArgumentSemantic.Strong)]
        MJRefreshHeader GetMJHeader();

        [Export("setMj_header:", ArgumentSemantic.Strong)]
        void SetMJHeader(MJRefreshHeader header);

        // @property (nonatomic, strong) MJRefreshFooter * mj_footer;
        [Export("mj_footer", ArgumentSemantic.Strong)]
        MJRefreshFooter GetMJFooter();

        [Export("setMj_footer:", ArgumentSemantic.Strong)]
        void SetMJFooter(MJRefreshFooter footer);

        // -(NSInteger)mj_totalDataCount;
        [Export("mj_totalDataCount")]
        nint MJTotalDataCount();

        // @property (copy, nonatomic) void (^mj_reloadDataBlock)(NSInteger);
        [Export("mj_reloadDataBlock", ArgumentSemantic.Copy)]
        Action<nint> GetMJReloadDataBlock();

        [Export("setMj_reloadDataBlock:", ArgumentSemantic.Copy)]
        void SetMJReloadDataBlock(Action<nint> block);
    }

    // typedef void (^MJRefreshComponentRefreshingBlock)();
    delegate void MJRefreshComponentRefreshingBlock();

    // typedef void (^MJRefreshComponentbeginRefreshingCompletionBlock)();
    delegate void MJRefreshComponentbeginRefreshingCompletionBlock();

    // typedef void (^MJRefreshComponentEndRefreshingCompletionBlock)();
    delegate void MJRefreshComponentEndRefreshingCompletionBlock();

    // @interface MJRefreshComponent : UIView
    [BaseType(typeof(UIView))]
    interface MJRefreshComponent
    {
        // @property (copy, nonatomic) MJRefreshComponentRefreshingBlock refreshingBlock;
        [Export("refreshingBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentRefreshingBlock RefreshingBlock { get; set; }

        // -(void)setRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Export("setRefreshingTarget:refreshingAction:")]
        void SetRefreshingTarget(NSObject target, Selector action);

        // @property (nonatomic, weak) id refreshingTarget;
        [Export("refreshingTarget", ArgumentSemantic.Weak)]
        NSObject RefreshingTarget { get; set; }

        // @property (assign, nonatomic) SEL refreshingAction;
        [Export("refreshingAction", ArgumentSemantic.Assign)]
        Selector RefreshingAction { get; set; }

        // -(void)executeRefreshingCallback;
        [Export("executeRefreshingCallback")]
        void ExecuteRefreshingCallback();

        // -(void)beginRefreshing;
        [Export("beginRefreshing")]
        void BeginRefreshing();

        // -(void)beginRefreshingWithCompletionBlock:(void (^)())completionBlock;
        [Export("beginRefreshingWithCompletionBlock:")]
        void BeginRefreshingWithCompletionBlock(Action completionBlock);

        // @property (copy, nonatomic) MJRefreshComponentbeginRefreshingCompletionBlock beginRefreshingCompletionBlock;
        [Export("beginRefreshingCompletionBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentbeginRefreshingCompletionBlock BeginRefreshingCompletionBlock { get; set; }

        // @property (copy, nonatomic) MJRefreshComponentEndRefreshingCompletionBlock endRefreshingCompletionBlock;
        [Export("endRefreshingCompletionBlock", ArgumentSemantic.Copy)]
        MJRefreshComponentEndRefreshingCompletionBlock EndRefreshingCompletionBlock { get; set; }

        // -(void)endRefreshing;
        [Export("endRefreshing")]
        void EndRefreshing();

        // -(void)endRefreshingWithCompletionBlock:(void (^)())completionBlock;
        [Export("endRefreshingWithCompletionBlock:")]
        void EndRefreshingWithCompletionBlock(Action completionBlock);

        // -(BOOL)isRefreshing;
        [Export("isRefreshing")]
        bool IsRefreshing { get; }

        // @property (assign, nonatomic) MJRefreshState state;
        [Export("state", ArgumentSemantic.Assign)]
        MJRefreshState State { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets scrollViewOriginalInset;
        [Export("scrollViewOriginalInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ScrollViewOriginalInset { get; }

        // @property (readonly, nonatomic, weak) UIScrollView * scrollView;
        [Export("scrollView", ArgumentSemantic.Weak)]
        UIScrollView ScrollView { get; }

        // -(void)prepare __attribute__((objc_requires_super));
        [Export("prepare")]
        void Prepare();

        // -(void)placeSubviews __attribute__((objc_requires_super));
        [Export("placeSubviews")]
        void PlaceSubviews();

        // -(void)scrollViewContentOffsetDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewContentOffsetDidChange:")]
        void ScrollViewContentOffsetDidChange(NSDictionary change);

        // -(void)scrollViewContentSizeDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewContentSizeDidChange:")]
        void ScrollViewContentSizeDidChange(NSDictionary change);

        // -(void)scrollViewPanStateDidChange:(NSDictionary *)change __attribute__((objc_requires_super));
        [Export("scrollViewPanStateDidChange:")]
        void ScrollViewPanStateDidChange(NSDictionary change);

        // @property (assign, nonatomic) CGFloat pullingPercent;
        [Export("pullingPercent")]
        nfloat PullingPercent { get; set; }

        // @property (getter = isAutomaticallyChangeAlpha, assign, nonatomic) BOOL automaticallyChangeAlpha;
        [Export("automaticallyChangeAlpha")]
        bool AutomaticallyChangeAlpha { [Bind("isAutomaticallyChangeAlpha")] get; set; }
    }

    // @interface MJRefreshHeader : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshHeader
    {
        // +(instancetype)headerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("headerWithRefreshingBlock:")]
        MJRefreshHeader HeaderWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        // +(instancetype)headerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("headerWithRefreshingTarget:refreshingAction:")]
        MJRefreshHeader HeaderWithRefreshingTarget(NSObject target, Selector action);

        // @property (copy, nonatomic) NSString * lastUpdatedTimeKey;
        [Export("lastUpdatedTimeKey")]
        string LastUpdatedTimeKey { get; set; }

        // @property (readonly, nonatomic, strong) NSDate * lastUpdatedTime;
        [Export("lastUpdatedTime", ArgumentSemantic.Strong)]
        NSDate LastUpdatedTime { get; }

        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetTop;
        [Export("ignoredScrollViewContentInsetTop")]
        nfloat IgnoredScrollViewContentInsetTop { get; set; }
    }

    // @interface MJRefreshStateHeader : MJRefreshHeader
    [BaseType(typeof(MJRefreshHeader))]
    interface MJRefreshStateHeader
    {
        // @property (copy, nonatomic) NSString * (^lastUpdatedTimeText)(NSDate *);
        [Export("lastUpdatedTimeText", ArgumentSemantic.Copy)]
        Func<NSDate, NSString> LastUpdatedTimeText { get; set; }

        // @property (readonly, nonatomic, weak) UILabel * lastUpdatedTimeLabel;
        [Export("lastUpdatedTimeLabel", ArgumentSemantic.Weak)]
        UILabel LastUpdatedTimeLabel { get; }

        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);
    }

    // @interface MJRefreshNormalHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshNormalHeader
    {
        // @property (readonly, nonatomic, weak) UIImageView * arrowView;
        [Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshGifHeader : MJRefreshStateHeader
    [BaseType(typeof(MJRefreshStateHeader))]
    interface MJRefreshGifHeader
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(UIImage[] images, MJRefreshState state);
    }

    // @interface MJRefreshFooter : MJRefreshComponent
    [BaseType(typeof(MJRefreshComponent))]
    interface MJRefreshFooter
    {
        // +(instancetype)footerWithRefreshingBlock:(MJRefreshComponentRefreshingBlock)refreshingBlock;
        [Static]
        [Export("footerWithRefreshingBlock:")]
        MJRefreshFooter FooterWithRefreshingBlock(MJRefreshComponentRefreshingBlock refreshingBlock);

        // +(instancetype)footerWithRefreshingTarget:(id)target refreshingAction:(SEL)action;
        [Static]
        [Export("footerWithRefreshingTarget:refreshingAction:")]
        MJRefreshFooter FooterWithRefreshingTarget(NSObject target, Selector action);

        // -(void)endRefreshingWithNoMoreData;
        [Export("endRefreshingWithNoMoreData")]
        void EndRefreshingWithNoMoreData();

        // -(void)resetNoMoreData;
        [Export("resetNoMoreData")]
        void ResetNoMoreData();

        // @property (assign, nonatomic) CGFloat ignoredScrollViewContentInsetBottom;
        [Export("ignoredScrollViewContentInsetBottom")]
        nfloat IgnoredScrollViewContentInsetBottom { get; set; }

        // @property (getter = isAutomaticallyHidden, assign, nonatomic) BOOL automaticallyHidden;
        [Export("automaticallyHidden")]
        bool AutomaticallyHidden { [Bind("isAutomaticallyHidden")] get; set; }
    }

    // @interface MJRefreshBackFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshBackFooter
    {
    }

    // @interface MJRefreshBackStateFooter : MJRefreshBackFooter
    [BaseType(typeof(MJRefreshBackFooter))]
    interface MJRefreshBackStateFooter
    {
        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        // -(NSString *)titleForState:(MJRefreshState)state;
        [Export("titleForState:")]
        string TitleForState(MJRefreshState state);
    }

    // @interface MJRefreshBackNormalFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackNormalFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * arrowView;
        [Export("arrowView", ArgumentSemantic.Weak)]
        UIImageView ArrowView { get; }

        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshBackGifFooter : MJRefreshBackStateFooter
    [BaseType(typeof(MJRefreshBackStateFooter))]
    interface MJRefreshBackGifFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(UIImage[] images, MJRefreshState state);
    }

    // @interface MJRefreshAutoFooter : MJRefreshFooter
    [BaseType(typeof(MJRefreshFooter))]
    interface MJRefreshAutoFooter
    {
        // @property (getter = isAutomaticallyRefresh, assign, nonatomic) BOOL automaticallyRefresh;
        [Export("automaticallyRefresh")]
        bool AutomaticallyRefresh { [Bind("isAutomaticallyRefresh")] get; set; }

        // @property (assign, nonatomic) CGFloat triggerAutomaticallyRefreshPercent;
        [Export("triggerAutomaticallyRefreshPercent")]
        nfloat TriggerAutomaticallyRefreshPercent { get; set; }
    }

    // @interface MJRefreshAutoStateFooter : MJRefreshAutoFooter
    [BaseType(typeof(MJRefreshAutoFooter))]
    interface MJRefreshAutoStateFooter
    {
        // @property (assign, nonatomic) CGFloat labelLeftInset;
        [Export("labelLeftInset")]
        nfloat LabelLeftInset { get; set; }

        // @property (readonly, nonatomic, weak) UILabel * stateLabel;
        [Export("stateLabel", ArgumentSemantic.Weak)]
        UILabel StateLabel { get; }

        // -(void)setTitle:(NSString *)title forState:(MJRefreshState)state;
        [Export("setTitle:forState:")]
        void SetTitle(string title, MJRefreshState state);

        // @property (getter = isRefreshingTitleHidden, assign, nonatomic) BOOL refreshingTitleHidden;
        [Export("refreshingTitleHidden")]
        bool RefreshingTitleHidden { [Bind("isRefreshingTitleHidden")] get; set; }
    }

    // @interface MJRefreshAutoNormalFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoNormalFooter
    {
        // @property (assign, nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }
    }

    // @interface MJRefreshAutoGifFooter : MJRefreshAutoStateFooter
    [BaseType(typeof(MJRefreshAutoStateFooter))]
    interface MJRefreshAutoGifFooter
    {
        // @property (readonly, nonatomic, weak) UIImageView * gifView;
        [Export("gifView", ArgumentSemantic.Weak)]
        UIImageView GifView { get; }

        // -(void)setImages:(NSArray *)images duration:(NSTimeInterval)duration forState:(MJRefreshState)state;
        [Export("setImages:duration:forState:")]
        void SetImages(UIImage[] images, double duration, MJRefreshState state);

        // -(void)setImages:(NSArray *)images forState:(MJRefreshState)state;
        [Export("setImages:forState:")]
        void SetImages(UIImage[] images, MJRefreshState state);
    }
}
