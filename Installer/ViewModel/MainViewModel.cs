using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Installer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _installationStatus = "Prepearing";
        public string InstallationStatus
        {
            get
            {
                return _installationStatus;
            }
            set
            {
                _installationStatus = value;
                RaisePropertyChanged(() => InstallationStatus);
            }
        }

        private RelayCommand _startInstallation;
        public RelayCommand StartInstallation
        {
            get
            {
                return _startInstallation ?? (_startInstallation = new RelayCommand(() =>
                {
                    this.InstallationStatus = "Started";
                }));
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(){}
    }
}