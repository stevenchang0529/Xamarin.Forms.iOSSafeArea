using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.iOSSafeArea.iOS;
using Xamarin.Forms.Platform.iOS;
[assembly: ResolutionGroupName("TP")]
[assembly: ExportEffect(typeof(SafeAreaPaddingEffect), nameof(SafeAreaPaddingEffect))]
namespace Xamarin.Forms.iOSSafeArea.iOS
{
    public class SafeAreaPaddingEffect : PlatformEffect
    {
        Thickness padding;
        protected override void OnAttached()
        {
            if (Element is Layout element)
            {
                if (!UIDevice.CurrentDevice.CheckSystemVersion(11, 0))
                    element.Padding = new Thickness(padding.Left, padding.Top + 20, padding.Right, padding.Bottom);
            }
        }
        protected override void OnDetached()
        {
            if (Element is Layout element)
                element.Padding = padding;
        }
    }
}