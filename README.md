UIStackView Example
===
## 前言
    IOS 9带来了很多新特性.UIKit也不断在更新,IOS 9苹果引入了 UIStackView,它将让开发
    者更容易的创建和管理界面元素.

## 介绍  
    UIStackView其实就是实现了Auto Layout的一个视图容器,早在Xode5苹果就引入Auto Layout,
    为了方便界面在不同尺寸屏幕下的布局,如今UIStackView的引入更加方便了开发者,你只需
    要简单设置几个属性就可以完成界面的布局.
    
    假如主视图有三个子视图,IOS 8上需要使用Auto Layout纯代码来布局,要创建五个以上
    NSLayoutConstraint来布局.
```csharp
private void InitConstraint()
{
	NSLayoutConstraint constraint = NSLayoutConstraint.Create (view0, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view1, NSLayoutAttribute.Leading, 20, 0);
	this.View.AddConstraint (constraint);
	NSLayoutConstraint constraint1 = NSLayoutConstraint.Create (view1, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view2, NSLayoutAttribute.Leading, 20, 0);
	this.View.AddConstraint (constraint1);
	NSLayoutConstraint constraint2 = NSLayoutConstraint.Create (view2, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, view3, NSLayoutAttribute.Leading, 20, 0);
	this.View.AddConstraint (constraint2);
	NSLayoutConstraint constraint3 = NSLayoutConstraint.Create (view3, NSLayoutAttribute.Leading, NSLayoutRelation.Equal, this.View, NSLayoutAttribute.Leading, 20, 0);
	this.View.AddConstraint (constraint3);
}
```

    IOS 7之前的就需要在中ViewDidLayoutSubviews就得写大量magic number,来控制布局.
```csharp
public override void ViewDidLayoutSubviews ()
{
	base.ViewDidLayoutSubviews ();
	nint spacing = 20;
	nint width = 50;
	nint height = 30;
	this.view0.Frame = new CGRect (spacing, spacing, width , height);
	this.view1.Frame = new CGRect (view0.Frame.Right + height, spacing, width , height);
	this.view2.Frame = new CGRect (view1.Frame.Right + height, spacing, width , height);
	this.view3.Frame = new CGRect (view2.Frame.Right + height, spacing, width , height);
}
```

    而使用UIStackView只需要简单设置几个属性就可以完成.
```csharp
private void InitStackView()
{
	StackView.Axis = UILayoutConstraintAxis.Horizontal;
	StackView.Spacing = 20;
	StackView.Alignment = UIStackViewAlignment.Fill;
	StackView.Distribution = UIStackViewDistribution.EqualSpacing;
}
```

## 详细 

    Axis表示Stack View的子视图是水平排布还是垂直排布.
    Alignment控制subview对齐方式.
    Distribution定义subview的分布方式.
    Spacing 定义子视图之间的最小间距.


## 延伸
    想要了解更多关于Xcode7中 UIStackView的内容,推荐阅读 WWDC 2015 的 
    session 218 Mysteries of Auto Layout, Part 1.在视频前15分钟里,
    Jason Yao 介绍了 UIStackView,并且现场制作了一个Demo演示如何操作的.

### [Weibo](http://weibo.com/deepbass)
