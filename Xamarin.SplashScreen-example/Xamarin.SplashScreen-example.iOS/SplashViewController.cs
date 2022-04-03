using Airbnb.Lottie;
using UIKit;

namespace Xamarin.SplashScreen_example.iOS
{
    public class SplashViewController : UIViewController
    {
        public SplashViewController() : base() { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var viewAnimation = LOTAnimationView.AnimationNamed("IgniscorLogo");
            viewAnimation.ContentMode = UIViewContentMode.Center;
            View.AddSubview(viewAnimation);
            View.BackgroundColor = UIColor.FromRGB(12, 18, 72);

            viewAnimation.Center = View.Center;

            viewAnimation.PlayWithCompletion((finished) =>
            {
                UIApplication.SharedApplication.Delegate.FinishedLaunching
                    (UIApplication.SharedApplication, new Foundation.NSDictionary());
            });
        }
    }
}