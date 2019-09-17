﻿using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Liddup.Controls;
using Liddup.iOS.Renderers;

[assembly: ExportRenderer(typeof(AudioSlider), typeof(AudioSliderRenderer))]
namespace Liddup.iOS.Renderers
{
    class AudioSliderRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.MinimumTrackTintColor = UIColor.White;
                Control.MaximumTrackTintColor = UIColor.FromRGBA(173, 174, 178, 40);

                if (e.NewElement != null && (e.NewElement as AudioSlider).HasThumb)
                    Control.SetThumbImage(UIImage.FromBundle("small_slider"), UIControlState.Normal);
                else
                    Control.SetThumbImage(new UIImage(), UIControlState.Normal);
            }
        }
    }
}
