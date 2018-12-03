package com.example.demo.functionality.twint;


import java.util.ArrayList;

public class Twint {

    // fields
    private String msg;
    private String Location;
    private Poll poll;
    private Media media;

    // Constructor
    public Twint(String msg)
    {
        this.msg = msg;
        Location = "Somewhere";
        poll = null;
    }

    // methodes

    // setters
    public void setMsg(String msg)
    {
        this.msg = msg;
    }
    public void setLocation(String Location)
    {
        this.Location = Location;
    }
    public void setPoll(Poll poll)
    {
        this.poll = poll;
    }
    // ...


    // getters
    public String getMsg(){return msg;}
    public String getLocation(){return Location;}
    public Poll getPoll(){return poll;}
    public Media getMedia(){return media;}
    //
    // Special one Hashtag # (Tranding):
    public ArrayList<String> getHashTag() // Verified! It works FINE!
    {
        ArrayList<String> ans = new ArrayList<String>();
        for(int i = 1; i < msg.length(); )
        {
            String HashTag = "#";
            if (msg.charAt(i - 1) == '#')
            {
                while(i < msg.length() && msg.charAt(i) != '#' && msg.charAt(i) != ' ') HashTag += msg.charAt(i++);
            }
            if (HashTag.length() > 1)
            {
                ans.add(HashTag);
            }
            i++;
        }
        return ans;
    }

    // for DEBUGGING
    public void printStats()
    {
        for(int i = -1; ++i < this.getPoll().getNvariants(); )
        {
            System.out.print(this.getPoll().getStatsAt(i).getKey() + " " + this.getPoll().getStatsAt(i).getValue() + "\n");
        }
        System.out.print('\n');
    }
}
