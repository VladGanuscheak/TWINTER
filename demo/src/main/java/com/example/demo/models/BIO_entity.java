package com.example.demo.models;

import com.example.demo.functionality.UAccount.Birthday;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Null;

@Entity()
@Table(name = "BIO", schema = "springbootdb")
public class BIO_entity {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long BIO_Id;

    @NotNull
    private String Location;

    @Null
    private String Website;

    @NotNull
    private int DD;

    @NotNull
    private int MM;

    @NotNull
    private  int YYYY;

    public BIO_entity(Long BIO_Id, String Location, String Website, int DD, int MM, int YYYY)
    {
        this.BIO_Id = BIO_Id;
        this.Location = (Location.isEmpty() ? "-" : Location);
        this.Website = Website;
        // Setting ONLY VALID data
        Birthday bday = new Birthday(DD, MM, YYYY);
        this.DD = bday.getDD();
        this.MM = bday.getMM();
        this.YYYY = bday.getYYYY();
    }

    public Long getBIO_Id() { return BIO_Id; }
    public void setBIO_Id(Long BIO_Id) { this.BIO_Id = BIO_Id; }

    public String getLocation() { return Location; }
    public void setLocation(String Location) { this.Location = Location; }

    public String getWebsite() { return Website; }
    public void setWebsite(String Website) { this.Website = Website; }

    public int getDD() { return DD; }
    public void setDD(int DD) { this.DD = DD; }

    public int getMM() { return MM; }
    public void setMM(int MM) { this.MM = MM; }

    public int getYYYY() { return YYYY; }
    public void setYYYY(int YYYY) { this.YYYY = YYYY; }
}
