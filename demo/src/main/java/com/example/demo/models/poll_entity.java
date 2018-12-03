package com.example.demo.models;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity()
@Table(name = "POLL", schema = "springbootdb")
public class poll_entity {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long poll_Id;

    @NotNull
    private int Nvariants;

    @NotNull
    private int duration;

    public poll_entity(Long poll_Id, int Nvariants, int duration)
    {
        this.poll_Id = poll_Id;
        this.Nvariants = Nvariants;
        this.duration = duration;
    }

    public void setPoll_Id(Long poll_Id) {
        this.poll_Id = poll_Id;
    }

    public Long getPoll_Id() {
        return poll_Id;
    }

    public void setNvariants(int nvariants) {
        Nvariants = nvariants;
    }

    public int getNvariants() {
        return Nvariants;
    }

    public void setDuration(int duration) {
        this.duration = duration;
    }

    public int getDuration() {
        return duration;
    }
}
