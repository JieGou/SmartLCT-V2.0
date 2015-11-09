using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using Nova.LCT.GigabitSystem.Common;
using System.ComponentModel;
using System.Windows;
using GalaSoft.MvvmLight;

namespace Nova.SmartLCT.Interface
{
    public enum ElementBindType { None, BaseLayer, Sender, Port, Scanner, ConnectedLine }
    
    public class SenderRealParameters
    {
        public IRectElement Element
        {
            get;
            set;
        }
        public ElementType EleType
        {
            get;
            set;
        }
        #region INotifyPropertyChanged 成员

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }

    public class PortRealParameters
    {
        public IRectLayer PortLayer
        {
            get;
            set;
        }

        public ObservableCollection<IRectElement> SelectedElementCollection
        {
            get;
            set;
        }

        
    }

    public class ScannerRealParameters:ViewModelBase
    {
        private IRectElement scannerElement;
        public IRectElement ScannerElement
        {
            get
            {
                return scannerElement;
            }
            set
            {
                scannerElement = value;
                this.RaisePropertyChanged(ScannerElement.Name.ToString());
            }
        }
        public IRectElement Groupframe
        {
            get;
            set;
        }
        public Rect NoSelectedElementRect
        {
            get;
            set;
        }
        private ScannerCofigInfo scannerConfig = new ScannerCofigInfo();
        public ScannerCofigInfo ScannerConfig
        {
            get
            {
                return scannerConfig;
            }
            set
            {
                scannerConfig = value;
                this.RaisePropertyChanged("ScannerConfig");
            }
        }
    }

    public class ScreenRealParameters
    {
        public IRectLayer ScreenLayer
        {
            get;
            set;
        }
        public ObservableCollection<IRectElement> SelectedElement
        {
            get;
            set;
        }
    }
}
