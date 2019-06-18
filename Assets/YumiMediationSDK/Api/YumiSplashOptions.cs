﻿
namespace YumiMediationSDK.Api
{ 
    public class YumiSplashOptions 
    {
        /// <summary>
        /// your fetch time.
        /// over the deadline, sdk will return the yumiMediationSplashAdFailToShow delegate.
        /// default is 3s.
        /// </summary>
        public int adFetchTime { get; private set; }
        /// <summary>
        /// the ad orientation.
        /// </summary>
        /// <value>The ad orientation.</value>
        public YumiSplashOrientation adOrientation { get; private set; }

        internal YumiSplashOptions(YumiSplashOptionsBuilder builder)
        {
            adFetchTime = builder.adFetchTime;
            adOrientation = builder.adOrientation;
        }
    }

    public class YumiSplashOptionsBuilder 
    { 
         public YumiSplashOptionsBuilder()
        {
            adFetchTime = 3;
            adOrientation = YumiSplashOrientation.YUMISPLASHORIENTATION_UNKNOWN;
        }

        internal int adFetchTime { get; private set; }
        internal YumiSplashOrientation adOrientation { get; private set; }

        public YumiSplashOptions Build()
        {
            return new YumiSplashOptions(this);
        }
        /// <summary>
        /// Sets the ad fetch time.
        /// </summary>
        /// <returns>Builder instance</returns>
        /// <param name="duration">Duration.</param>
        public YumiSplashOptionsBuilder setAdFetchTime(int duration)
        {
            adFetchTime = duration;
            return this;
        }
        /// <summary>
        /// Sets the ad orientation.
        /// </summary>
        /// <returns>Builder instance.</returns>
        /// <param name="orientation">Orientation.</param>
        public YumiSplashOptionsBuilder setAdOrientation(YumiSplashOrientation orientation)
        {
            adOrientation = orientation;
            return this;
        }
    }

    public enum YumiSplashOrientation
    {
        /// <summary>
        /// The yumi splash orientation unknown.
        /// </summary>
        YUMISPLASHORIENTATION_UNKNOWN,
        /// <summary>
        /// The yumisplashorientation portrait.
        /// </summary>
        YUMISPLASHORIENTATION_PORTRAIT,
        /// <summary>
        /// The yumisplashorientation portraitupsidedown.
        /// </summary>
        YUMISPLASHORIENTATION_PORTRAITUPSIDEDOWN,
        /// <summary>
        /// The yumisplashorientation landscapeleft.
        /// </summary>
        YUMISPLASHORIENTATION_LANDSCAPELEFT,
        /// <summary>
        /// The yumisplashorientation landscaperight.
        /// </summary>
        YUMISPLASHORIENTATION_LANDSCAPERIGHT
    }

}