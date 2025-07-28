using System;

namespace _3S_eShop.PatternDistinctive.Observer.Countdown
{
    public class CountdownEventArgs : EventArgs
    {
        /// <summary>
        /// Số giây còn lại trong quá trình đếm ngược.
        /// </summary>
        public int SecondsRemaining { get; }

        /// <summary>
        /// Tỷ lệ phần trăm thời gian còn lại (0.0 đến 100.0).
        /// </summary>
        public double PercentLeft { get; }

        public CountdownEventArgs(int secondsRemaining, double percentLeft)
        {
            SecondsRemaining = secondsRemaining;
            PercentLeft = percentLeft;
        }
    }

}
