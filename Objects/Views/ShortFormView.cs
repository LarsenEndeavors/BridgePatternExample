using System;
using BridgePatternExample.Objects.Resources;

namespace BridgePatternExample.Objects.Views
{
    public class ShortFormView : View
    {
        public ShortFormView(IResource resource) : base(resource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Short-form view with a(n) " + Resource.GetSnippet() + " resource.");
        }
    }
}