package com.example.demo.functionality.twint;

import javafx.util.Pair;

import java.util.Date;

class TimeProcessStatus{
    int TimeExpired = 0;
    int StillAvailable = 1;
}

public class Poll extends TimeProcessStatus{

    private int Nvariants;
    private int duration; // In seconds
    private Stats stats;
    //
    private Date date;

    // Constructor
    public Poll(int Nvariants, Date date, int duration, String[] params)
    {
        this.Nvariants = Nvariants;
        this.date = date;
        this.duration = duration * 1000;

        this.date = new Date(); // current Date!

        // Ok!
        if (Nvariants == params.length)
        {
            stats = new Stats(params);
        }
    }

    // methods
    public int DeleteVariantAt(int index) // DELETES one of the Poll variants (if the time has not been expired)
    {
        Date currentDate = new Date();
        if (date.getTime() + duration > currentDate.getTime())
        {
            Nvariants += (stats.DeleteVariantAt(index) ? -1 : 0);
            return StillAvailable;
        }
        return TimeExpired;
    }
    public int AppendNewVariant(String value) // APPENDS a variant into the Poll (if the time has not been expired)
    {
        Date currentDate = new Date();
        if (date.getTime() + duration > currentDate.getTime())
        {
            Nvariants += (stats.AppendNewVariant(value) ? 1 : 0);
            return StillAvailable;
        }
        return TimeExpired;
    }
    public int VoteAt(int index) // Adds an vote (if the time has not been expired)
    {
        Date currentDate = new Date();
        if (date.getTime() + duration > currentDate.getTime())
        {
            return (stats.addVoteAt(index) ? StillAvailable : TimeExpired);
        }
        return TimeExpired;
    }

    // setters

    public void setNvariants(int Nvariants)
    {
        this.Nvariants = Nvariants;
    }
    public void setDuration(int duration)
    {
        this.duration = duration;
    }
    public void setDate(int date) { this.date.setTime(date); }

    // getters
    public int getNvariants(){return Nvariants;}
    public int getDuration(){return duration;}
    public Stats getStats(){return stats;}
    public Date getDate(){return date;}
    // getters: special
    public Pair getStatsAt(int index)
    {
        return stats.getVoteCombinatoion(index);
    } // It WORKS!
}
