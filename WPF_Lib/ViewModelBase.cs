
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AlphaBIM
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Phương thức OnPropertyChanged(“propertyName”): Giúp giao diện WPF tự động cập nhật
        /// khi Property(propertyName) thay đổi giá trị ở behind code.
        /// - propertyName: là tên của Property bị Change value.
        /// - CallerMemberName: Khi propertyName = "" thì lấy “propertyName” là Property gọi phương thức OnPropertyChanged()
        /// [ENGLISH BELOW]
        /// Method OnPropertyChanged(“propertyName”): help WPF interface update automatically
        /// when Property(propertyName) change value in behind code.
        /// - propertyName: name of Property Changed value.
        /// - CallerMemberName: if propertyName = "", “propertyName” will be Property that call method OnPropertyChanged()
        /// </summary>
        /// <param name="propertyName">Name of Property Changed value</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

