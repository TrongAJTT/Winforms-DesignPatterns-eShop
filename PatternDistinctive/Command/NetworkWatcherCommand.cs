using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _3S_eShop.PatternDistinctive.Command
{
    public class NetworkWatcherCommand : ICommand<bool>
    {
        private readonly Action<bool> _onNetworkChanged;
        private bool _isWatching = false;

        public NetworkWatcherCommand(Action<bool> onNetworkChanged)
        {
            _onNetworkChanged = onNetworkChanged;
        }

        // Bắt đầu theo dõi mạng
        public bool Execute()
        {
            if (!_isWatching)
            {
                _isWatching = true;
                NetworkChange.NetworkAvailabilityChanged += OnNetworkAvailabilityChanged;
            }
            return _isWatching;
        }

        // Dừng theo dõi mạng
        public void stop()
        {
            if (_isWatching)
            {
                _isWatching = false;
                NetworkChange.NetworkAvailabilityChanged -= OnNetworkAvailabilityChanged;
            }
        }

        private void OnNetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            _onNetworkChanged?.Invoke(e.IsAvailable);
        }
    }
}
