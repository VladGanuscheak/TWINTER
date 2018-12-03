package com.example.demo.functionality.UAccount;

public class BIO extends ProcessStatus {

    // private Image Background;
    private String Location;
    private String Website;
    private Birthday birthday;

    // Constructor
    public BIO()
    {
        this.Location = "UNDEFINED";
        this.Website = "htpp/something.org";
        birthday = new Birthday();
    }
    // setters
    public boolean setLocation(String Location)
    {
        if (Location.isEmpty() || Location == null) return FAIL;
        this.Location = Location;
        return OK;
    }
    public boolean setWebsite(String Website)
    {
        if (Website.isEmpty() || Website == null) return FAIL;
        this.Website = Website;
        return OK;
    }
    // getters
    public String getLocation(){return Location;}
    public String getWebsite(){return Website;}
    public Birthday getBirthday(){return birthday;}
}
