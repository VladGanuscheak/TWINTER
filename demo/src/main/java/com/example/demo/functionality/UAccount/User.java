package com.example.demo.functionality.UAccount;

// This class Defines several possible User states
// (Using bitwise OR can get all his/her states)

import com.example.demo.functionality.twint.Poll;
import com.example.demo.functionality.twint.Twint;

import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;

class UserStatus extends ProcessStatus // In Java isn't multiple inheritance, so ProcessStatus should be inherited here...
{
    int ONLINE = 1;
    int ACTIVE = 2;
    int BANNED = 4;
}
public class User extends UserStatus {

    // fields
    private String NickName;
    private int status;
    private int NrFollowers;
    private int NrFollowing;

    //private photo UPhoto;
    //private photo HeaderPhoto;

    BIO description;

    // Constructor
    public User(String NickName)
    {
        this.NickName = NickName;
        this.status = ONLINE | ACTIVE;
    }

    // setters
    // public boolean setUPhoto(photo UPhoto) { this.UPhoto = UPhoto; }
    // public boolean setHeaderPhoto(photo HeaderPhoto) { this.HeaderPhoto = HeaderPhoto; }
    // public boolean setBio(param p...)
    public boolean setNickName(String NickName)
    {
        if (this.NickName == NickName) return FAIL;
        this.NickName = NickName;
        return OK;
    }
    public boolean setNrFollowers(int NrFollowers)
    {
        if (NrFollowers < 0) return FAIL;
        this.NrFollowers = NrFollowers;
        return OK;
    }
    public boolean setNrFollowing(int NrFollowing)
    {
        if (NrFollowing < 0) return FAIL;
        this.NrFollowing = NrFollowing;
        return OK;
    }
    //
    public boolean changeStatus()
    {
        return OK;
    }
    // getters
    public String getNickName(){ return NickName;}
    public int getStatus(){ return status; }
    public int getNrFollowers(){return NrFollowers;}
    public int getNrFollowing(){return NrFollowing;}
    //public BIO getBIO() {return bio;}

    // About UserStatus (getStatus)
    boolean IsOnline()
    {
        return ((status & ONLINE) > 0);
    }
    boolean IsOffline()
    {
        return !this.IsOnline();
    }
    boolean IsActive()
    {
        return ((status & ACTIVE) > 0);
    }
    boolean IsInactive()
    {
        return !this.IsActive();
    }
    boolean IsBanned()
    {
        return ((status & BANNED) > 0);
    }
    boolean IsNotBanned()
    {
        return !this.IsBanned();
    }
    // About UserStatus (setStatus)
    public void setOnline()
    {
        status |= ONLINE;
    }
    public void setOffline()
    {
        status = (this.IsOnline() ? status ^ ONLINE : status);
    }
    public void setActive()
    {
        status |= ACTIVE;
    }
    public void setInactive()
    {
        status = (this.IsActive() ? status ^ ACTIVE : status);
    }
    public void setBanned()
    {
        status |= BANNED;
    }
    public void setNotBanned()
    {
        status = (this.IsBanned() ? status ^ BANNED : status);
    }
    // For DEBUGGING:
    public void showUserState()
    {
        String ans = "";
        if (this.IsOnline()) ans += "ONLINE ";
        if (this.IsOffline()) ans += "OFFLINE ";
        if (this.IsActive()) ans += "ACTIVE ";
        if (this.IsInactive()) ans += "INACTIVE ";
        if (this.IsBanned()) ans += "BANNED ";
        if (this.IsNotBanned()) ans += "NOT_BANNED ";
        ans += '\n';
        System.out.print(ans);
    }
    // Special:
    public boolean DoTwint()
    {
        Twint T = new Twint("Currently I'm in Chisinau... Such a wonderfull day #Chisinau #MakesMeWonder #Chisinau_wonders_me");
        T.setLocation("Chisinau"); // Location (it's optional)
        String[] variants = {"Go to Patria", "Restaurant", "BurgerCity"}; // All the variants for the Poll
        //
        ArrayList<String> Hash = T.getHashTag(); // All HashTags (#) in the message
        for(int i = -1; ++i < Hash.size(); System.out.print(Hash.get(i) + "\n")); // Printing all the HashTags
        //
        // Testing the Poll:
        T.setPoll(new Poll(3, new Date(), 60, variants)); // Creating the Poll
        System.out.print("Testing the Poll\n");
        Scanner in = new Scanner(System.in); // For reading
        T.printStats(); // Prints all the variants (including their votes)
        INFINITY_LOOP: while(true)
        {
            switch((char)(in.next().charAt(0)))
            {
                case 'V':
                    System.out.print("Enter the index to add vote\n");
                    T.getPoll().VoteAt(in.nextInt());
                    break;
                case 'A':
                    System.out.print("Enter the variant to the Poll (String value)\n");
                    T.getPoll().AppendNewVariant(in.nextLine());
                    break;
                case 'D':
                    System.out.print("Enter the index to remove variant\n");
                    T.getPoll().DeleteVariantAt(in.nextInt());
                    break;
                case 'E':
                    break INFINITY_LOOP;
            }
            T.printStats();
        }
        return OK;
    }
    boolean ReTwint()
    {
        return OK;
    }
    boolean Search()
    {
        return OK;
    }
    boolean Modify()
    {
        return OK;
    }
}
