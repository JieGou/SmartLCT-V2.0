
namespace Nova.SmartLCT.Interface
{
    using GalaSoft.MvvmLight.Messaging;
    using System;
    using System.Runtime.CompilerServices;
    using System.Windows;

    public class DialogMessage : GenericMessage<string>
    {
        public DialogMessage(string content, Action<MessageBoxResult> callback)
            : base(content)
        {
            this.Callback = callback;
        }

        public DialogMessage(object sender, string content, Action<MessageBoxResult> callback)
            : base(sender, content)
        {
            this.Callback = callback;
        }

        public DialogMessage(object sender, object target, string content, Action<MessageBoxResult> callback)
            : base(sender, target, content)
        {
            this.Callback = callback;
        }

        public void ProcessCallback(MessageBoxResult result)
        {
            if (this.Callback != null)
            {
                this.Callback(result);
            }
        }

        public MessageBoxButton Button { get; set; }

        public Action<MessageBoxResult> Callback { get; private set; }

        public string Caption { get; set; }

        public MessageBoxResult DefaultResult { get; set; }

        public MessageBoxImage Icon { get; set; }

        public MessageBoxOptions Options { get; set; }
    }
}
