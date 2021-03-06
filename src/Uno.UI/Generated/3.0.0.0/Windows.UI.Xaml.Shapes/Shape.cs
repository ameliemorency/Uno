#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Shapes
{
	#if false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class Shape : global::Windows.UI.Xaml.FrameworkElement
	{
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.DoubleCollection StrokeDashArray
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.DoubleCollection)this.GetValue(StrokeDashArrayProperty);
			}
			set
			{
				this.SetValue(StrokeDashArrayProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Stroke
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(StrokeProperty);
			}
			set
			{
				this.SetValue(StrokeProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Stretch Stretch
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Stretch)this.GetValue(StretchProperty);
			}
			set
			{
				this.SetValue(StretchProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PenLineCap StrokeDashCap
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeDashCapProperty);
			}
			set
			{
				this.SetValue(StrokeDashCapProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Brush Fill
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.Brush)this.GetValue(FillProperty);
			}
			set
			{
				this.SetValue(FillProperty, value);
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public  double StrokeThickness
		{
			get
			{
				return (double)this.GetValue(StrokeThicknessProperty);
			}
			set
			{
				this.SetValue(StrokeThicknessProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PenLineCap StrokeStartLineCap
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeStartLineCapProperty);
			}
			set
			{
				this.SetValue(StrokeStartLineCapProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double StrokeMiterLimit
		{
			get
			{
				return (double)this.GetValue(StrokeMiterLimitProperty);
			}
			set
			{
				this.SetValue(StrokeMiterLimitProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PenLineJoin StrokeLineJoin
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PenLineJoin)this.GetValue(StrokeLineJoinProperty);
			}
			set
			{
				this.SetValue(StrokeLineJoinProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.PenLineCap StrokeEndLineCap
		{
			get
			{
				return (global::Windows.UI.Xaml.Media.PenLineCap)this.GetValue(StrokeEndLineCapProperty);
			}
			set
			{
				this.SetValue(StrokeEndLineCapProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  double StrokeDashOffset
		{
			get
			{
				return (double)this.GetValue(StrokeDashOffsetProperty);
			}
			set
			{
				this.SetValue(StrokeDashOffsetProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Xaml.Media.Transform GeometryTransform
		{
			get
			{
				throw new global::System.NotImplementedException("The member Transform Shape.GeometryTransform is not implemented in Uno.");
			}
		}
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty FillProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Fill", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StretchProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stretch", typeof(global::Windows.UI.Xaml.Media.Stretch), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Stretch)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeDashArrayProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeDashArray", typeof(global::Windows.UI.Xaml.Media.DoubleCollection), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.DoubleCollection)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeDashCapProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeDashCap", typeof(global::Windows.UI.Xaml.Media.PenLineCap), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PenLineCap)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeDashOffsetProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeDashOffset", typeof(double), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeEndLineCapProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeEndLineCap", typeof(global::Windows.UI.Xaml.Media.PenLineCap), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PenLineCap)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeLineJoinProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeLineJoin", typeof(global::Windows.UI.Xaml.Media.PenLineJoin), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PenLineJoin)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeMiterLimitProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeMiterLimit", typeof(double), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"Stroke", typeof(global::Windows.UI.Xaml.Media.Brush), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.Brush)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeStartLineCapProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeStartLineCap", typeof(global::Windows.UI.Xaml.Media.PenLineCap), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(global::Windows.UI.Xaml.Media.PenLineCap)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty StrokeThicknessProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"StrokeThickness", typeof(double), 
			typeof(global::Windows.UI.Xaml.Shapes.Shape), 
			new FrameworkPropertyMetadata(default(double)));
		#endif
		#if false || false || false || false
		[global::Uno.NotImplemented]
		protected Shape() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Shapes.Shape", "Shape.Shape()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Shape()
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Fill.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Fill.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Stroke.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Stroke.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeMiterLimit.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeMiterLimit.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeThickness.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeThickness.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeStartLineCap.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeStartLineCap.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeEndLineCap.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeEndLineCap.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeLineJoin.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeLineJoin.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashOffset.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashOffset.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashCap.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashCap.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashArray.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashArray.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Stretch.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.Stretch.set
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.GeometryTransform.get
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.Composition.CompositionBrush GetAlphaMask()
		{
			throw new global::System.NotImplementedException("The member CompositionBrush Shape.GetAlphaMask() is not implemented in Uno.");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.FillProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeMiterLimitProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeThicknessProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeStartLineCapProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeEndLineCapProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeLineJoinProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashOffsetProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashCapProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StrokeDashArrayProperty.get
		// Forced skipping of method Windows.UI.Xaml.Shapes.Shape.StretchProperty.get
	}
}
