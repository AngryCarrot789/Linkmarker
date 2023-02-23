using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace Linkmarker.AttachedProperties {
    public static class GridSplitterRelay {
        public static readonly DependencyProperty RelayedSplitterProperty =
            DependencyProperty.RegisterAttached(
                "RelayedSplitter",
                typeof(GridSplitter),
                typeof(GridSplitterRelay),
                new PropertyMetadata(null, OnRelayedSplitterChanged));

        public static void SetRelayedSplitter(Thumb element, GridSplitter value) {
            element.SetValue(RelayedSplitterProperty, value);
        }

        public static GridSplitter GetRelayedSplitter(Thumb element) {
            return (GridSplitter) element.GetValue(RelayedSplitterProperty);
        }

        private static void OnRelayedSplitterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) {
            if (d is Thumb thumb) {
                thumb.DragDelta -= ThumbOnDragDelta;
                if (e.NewValue != null) {
                    thumb.DragDelta += ThumbOnDragDelta;
                }
            }
            else {
                throw new Exception(nameof(RelayedSplitterProperty) + " must be attached to type " + nameof(Thumb));
            }
        }

        private static void ThumbOnDragDelta(object sender, DragDeltaEventArgs e) {
            if (sender is Thumb thumb) {
                GridSplitter splitter = GetRelayedSplitter(thumb);
                if (splitter == null) {
                    return;
                }

                splitter.RaiseEvent(new DragDeltaEventArgs(e.HorizontalChange, 0));
            }
        }
    }
}