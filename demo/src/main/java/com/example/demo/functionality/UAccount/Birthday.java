package com.example.demo.functionality.UAccount;

import java.util.Date;

class PrivacyConsts extends ProcessStatus {
    protected final int Public = 0;
    protected final int UserFollowers = 1;
    protected final int FollowingUsers = 2;
    protected final int EachOtherFollowing = 3;
    protected final int OnlyUser = 4;
}
public class Birthday extends PrivacyConsts{

    private int DD;
    private int MM;
    private int YYYY;
    private int privacy;

    // Constructor
    public Birthday()
    {
        this.DD = 1;
        this.MM = 1;
        this.YYYY = 2018;
        this.privacy = Public;
    }
    // Parametrized Constructor
    public Birthday(int DD, int MM, int YYYY)
    {
        this.DD = 1;
        this.MM = 1;
        this.YYYY = 2018;
        this.privacy = Public;
        // Validate data
        this.setDD(DD);
        this.setMM(MM);
        this.setYYYY(YYYY);
    }

    // setters
    boolean LEAP_YEAR(int YYYY)
    {
        return ((YYYY % 4 == 0 && YYYY % 100 != 0) || (YYYY % 400 == 0));
    }
    boolean setDD(int DD)
    {
        int[] Month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if (DD < 1 || DD > Month[MM - 1] + (int)(MM == 1 && LEAP_YEAR(YYYY) ? 1 : 0)) return FAIL;
        this.DD = DD;
        return OK;
    }
    boolean setMM(int MM)
    {
        int[] Month = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        if (MM < 1 || MM > 12 || DD > Month[MM - 1] + (int)(MM == 1 && LEAP_YEAR(YYYY) ? 1 : 0)) return FAIL;
        this.MM = MM;
        return OK;
    }
    boolean setYYYY(int YYYY)
    {
        if (YYYY < 1920 || YYYY > (new Date()).getYear()) return FAIL;
        this.YYYY = YYYY;
        return OK;
    }
    boolean setPrivacy(final int level)
    {
        if (level < Public || level > OnlyUser) return FAIL;
        this.privacy = level;
        return OK;
    }
    // getters
    public int getDD(){return DD;}
    public int getMM(){return MM;}
    public int getYYYY(){return YYYY;}
    public int getPrivacy(){return privacy;}
}
