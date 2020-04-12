﻿using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using Xamarin.Forms;

namespace MijnSauna.Frontend.Phone.Controls
{
    public class SwirlControl : SKCanvasView
    {
        public Color Color1 { get; set; }

        public static readonly BindableProperty Color1Property = BindableProperty.Create(
            propertyName: nameof(Color1),
            returnType: typeof(Color),
            declaringType: typeof(SwirlControl),
            defaultValue: Color.White,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: Color1PropertyChanged);

        private static void Color1PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            
        }

        public Color Color2 { get; set; }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {

            var paint = new SKPaint
            {
                Color = Color2.ToSKColor(),
                Style = SKPaintStyle.Fill,
                IsAntialias = true
            };

            var bounds = e.Surface.Canvas.LocalClipBounds;
            var canvas = e.Surface.Canvas;

            canvas.Clear(Color1.ToSKColor());

            //var point1 = new SKPoint(bounds.Left, bounds.Top);
            //var point2 = new SKPoint(bounds.Left + bounds.Width / 2, bounds.Top);
            //var point3 = new SKPoint(bounds.Left + bounds.Width / 2, bounds.Top + bounds.Height);
            //var point4 = new SKPoint(bounds.Left + bounds.Width, bounds.Top + bounds.Height);
            //var point5 = new SKPoint(bounds.Left, bounds.Top + bounds.Height);

            var point1 = new SKPoint(0, bounds.Height);
            var point2 = new SKPoint(bounds.Width / 2, bounds.Height);
            var point3 = new SKPoint(bounds.Width / 2, 0);
            var point4 = new SKPoint(bounds.Width, 0);
            var point5 = new SKPoint(bounds.Width, bounds.Height);

            using (var path = new SKPath())
            {
                path.MoveTo(point1);
                path.CubicTo(point2, point3, point4);
                path.LineTo(point5);
                path.Close();
                canvas.DrawPath(path, paint);
            }
        }
    }
}