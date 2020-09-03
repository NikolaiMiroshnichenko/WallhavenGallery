﻿using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace WallhavenGallery.Behaviors
{
    public class EventToCommandBehavior : Behavior<Entry>
    {
        public Entry AssociatedObject { get; private set; }
        public static readonly BindableProperty CommandProperty =
                BindableProperty.Create("Command", typeof(ICommand), typeof(EventToCommandBehavior), null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            AssociatedObject = bindable;

            bindable.BindingContextChanged += Bindable_BindingContextChanged;
            bindable.Completed += Bindable_Completed;
        }
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.BindingContextChanged -= Bindable_BindingContextChanged;
            bindable.Completed -= Bindable_Completed;

            AssociatedObject = null;
        }

        private void Bindable_BindingContextChanged(object sender, EventArgs e)
        {
            OnBindingContextChanged();
        }
        private void Bindable_Completed(object sender, EventArgs e)
        {
            if (Command == null) return;

            //object parameter = Converter.Convert(e, typeof(object), null, null);
            if (Command.CanExecute(e))
            {
                Command.Execute(e);
            }

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            BindingContext = AssociatedObject.BindingContext;
        }
               
    }
}
