using System;
using BridgePatternExample.Objects.Resources;

namespace BridgePatternExample.Objects.Views
{
    public class LongFormView : View
    {
        public LongFormView(IResource resource) : base(resource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Long-form view with a(n) " + Resource.GetSnippet() + " resource.");
        }
    }
}