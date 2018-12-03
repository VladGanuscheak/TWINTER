package com.example.demo.models;

import org.springframework.data.annotation.Id;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Null;

@Entity
@Table(name = "TWINT", schema = "springbootdb")
public class Twint_entity {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long Twint_Id;

    @NotNull
    private String msg;

    @Null
    private String Location;

    @ManyToOne
    @JoinColumn(name = "media_Id")
    private Long media_Id;

    @ManyToOne
    @JoinColumn(foreignKey = @ForeignKey(name=".BIO_Id"))
    private Long poll_Id;


    public Twint_entity(Long twint_id, @NotNull String msg, @Null String location, Long media_id) {
        Twint_Id = twint_id;
        this.msg = (msg.isEmpty() ? "-" : msg);
        Location = location;
        media_Id = media_id;
    }

    public void setTwint_Id(Long twint_Id) {
        Twint_Id = twint_Id;
    }

    public Long getTwint_Id() {
        return Twint_Id;
    }

    public void setMsg(String msg) {
        this.msg = msg;
    }

    public String getMsg() {
        return msg;
    }

    public void setLocation(String location) {
        Location = location;
    }

    public String getLocation() {
        return Location;
    }

    public Long getPoll_Id() {
        return poll_Id;
    }

    public void setPoll_Id(Long poll_Id) {
        this.poll_Id = poll_Id;
    }

    public Long getMedia_Id() {
        return media_Id;
    }

    public void setMedia_Id(Long media_Id) {
        this.media_Id = media_Id;
    }

}
