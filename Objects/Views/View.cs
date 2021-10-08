using BridgePatternExample.Objects.Resources;

namespace BridgePatternExample.Objects.Views
{
    public abstract class View
    {
        protected IResource Resource { get; set; }

        protected View(IResource resource)
        {
            Resource = resource;
        }

        public abstract void Show();
    }
}