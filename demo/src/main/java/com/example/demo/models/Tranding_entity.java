package com.example.demo.models;

import javax.persistence.*;
import javax.validation.constraints.NotNull;

@Entity()
@Table(name = "TRADING", schema = "springbootdb")
public class Tranding_entity
{
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long Tranding_Id;

    @NotNull
    private String HashTag;

    @ManyToOne
    @JoinColumn(nullable = false, foreignKey = @ForeignKey(name="Twint_Id"))
    private  Long Twint_Id;

    Tranding_entity(Long Tranding_Id, String HashTag, Long Twint_Id)
    {
        this.Tranding_Id = Tranding_Id;
        this.HashTag = HashTag;
        this.Twint_Id = Twint_Id;
    }

    public void setTranding_Id(Long tranding_Id) {
        Tranding_Id = tranding_Id;
    }

    public Long getTranding_Id() {
        return Tranding_Id;
    }

    public void setHashTag(String hashTag) {
        HashTag = hashTag;
    }

    public String getHashTag() {
        return HashTag;
    }

    public void setTwint_Id(Long twint_Id) {
        Twint_Id = twint_Id;
    }

    public Long getTwint_Id() {
        return Twint_Id;
    }
}
