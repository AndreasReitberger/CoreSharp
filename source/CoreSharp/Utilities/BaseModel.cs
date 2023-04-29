using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel;

namespace AndreasReitberger.Core.Utilities {
    public partial class BaseModel : ObservableObject, INotifyPropertyChanged, ICloneable
    {
        #region ICloneable
        public object Clone()
        {
            return MemberwiseClone();
        }
        #endregion
    }
}
