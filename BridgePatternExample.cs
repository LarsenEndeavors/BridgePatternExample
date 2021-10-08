using System;
using BridgePatternExample.Objects;
using BridgePatternExample.Objects.Resources;
using BridgePatternExample.Objects.Views;

namespace BridgePatternExample
{
    internal static class BridgePatternExample
    {
        /*
         * The majority of this code is mocked or directly taken from the Christopher Okhravi Design pattern
         * YouTube series in an effort to teach myself and get familiar with these patterns.  None of this is
         * meant to be original content, and if you see this and wonder why it's in my repo, mostly it's for me,
         * but I'm happy that you're here and here's proof that I have at least heard of this particular pattern!
         *
         * Author: Nicholas Larsen
         * Date: 2021/10/08
         */
        
        
        private static void Main()
        {
            // The bridge pattern is a way to allow for abstract objects to be created
            // with non-specific interfaces to allow for decoupling, these views don't care
            // what the resource they're given is, or what it does, just that they need one.
            View longFormAlbumView = new LongFormView(new AlbumResource());
            View longFormArtistView = new LongFormView(new ArtistResource());
            
            View shortFormAlbumView = new ShortFormView(new AlbumResource());
            View shortFormArtistView = new ShortFormView(new ArtistResource());
            
            longFormAlbumView.Show();
            longFormArtistView.Show();
            
            shortFormAlbumView.Show();
            shortFormArtistView.Show();

        }
    }
}