using Foundation;
using UIKit;
using XamarinTutorial.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace XamarinTutorial.iOS
{
	public class PhoneDialer : IDialer
	{
		public bool Dial(string number)
		{
			return UIApplication.SharedApplication.OpenUrl(new NSUrl("tel:" + number));
		}
	}
}
