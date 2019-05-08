package com.zplay.unity.adsyumi;

public interface YumiURewardVideoListener {
    void onAdLoaded();
    void onAdFailedToLoad(String errorReason);
    void onAdOpening();
    void onAdStartPlaying();
    void onAdRewarded();
    void onAdClosed(boolean isRewarded);
    void onAdFailedToShow(String errorReason);
    void onAdClicked();

}
