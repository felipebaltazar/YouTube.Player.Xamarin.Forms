using AVFoundation;
using AVKit;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using YouTube.Player;

[assembly: ExportRenderer(typeof(Xamarin.Forms.YoutubePlayer.VideoPlayer),
                          typeof(Xamarin.Forms.YoutubePlayer.iOS.VideoPlayerRenderer))]

namespace Xamarin.Forms.YoutubePlayer.iOS
{
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, UIView>
    {
        PlayerView player;

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> args)
        {
            base.OnElementChanged(args);

            if (args.NewElement != null)
            {
                if (Control == null)
                {
                    // Set Player property to AVPlayer
                    player = new PlayerView();
                    player.LoadVideoById(this.Element.VideoId);
                    // Use the View from the controller as the native control
                    SetNativeControl(player);

                    if(Element.AutoPlay)
                        player.PlayVideo();
                }
            }
        }
    }
}