package com.example.demo.models;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity()
@Table(name = "MEDIA", schema = "springbootdb")
public class media_entity {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long media_Id;

    @NotNull
    private int media_type;

    @NotNull
    private String URL;

    public media_entity(Long media_Id, int media_type, String URL)
    {
        this.media_Id = media_Id;
        this.media_type = media_type;
        this.URL = URL;
    }

    public void setMedia_Id(Long media_Id) {
        this.media_Id = media_Id;
    }

    public Long getMedia_Id() {
        return media_Id;
    }

    public void setMedia_type(int media_type) {
        this.media_type = media_type;
    }

    public int getMedia_type() {
        return media_type;
    }

    public void setURL(String URL) {
        this.URL = URL;
    }

    public String getURL() {
        return URL;
    }
}
