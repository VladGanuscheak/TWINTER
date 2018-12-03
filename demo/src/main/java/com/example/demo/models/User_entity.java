package com.example.demo.models;

import javax.persistence.*;
import javax.validation.constraints.NotNull;
import javax.validation.constraints.Null;
import java.sql.Blob;

@Entity
@Table(name = "USER", schema = "springbootdb")
public class User_entity {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long User_ID;

    @NotNull
    private String User;

    @Null
    private Blob UPhoto;

    @Null
    private Blob HeaderPhoto;

    @ManyToOne
    @JoinColumn(nullable = true, foreignKey = @ForeignKey(name="BIO_Id"))
    private Long BIO_Id;


    public User_entity(Long User_ID, String User, Blob UPhoto, Blob HeaderPhoto, Long BIO_Id)
    {
        this.User_ID = User_ID;
        this.User = User;
        this.BIO_Id = BIO_Id;
        this.UPhoto = UPhoto;
        this.HeaderPhoto = HeaderPhoto;
    }


    public void setUser_ID(Long user_ID) {
        User_ID = user_ID;
    }

    public Long getUser_ID() {
        return User_ID;
    }

    public void setUser(String user) {
        User = user;
    }

    public String getUser() {
        return User;
    }

    public void setUPhoto(Blob UPhoto) {
        this.UPhoto = UPhoto;
    }

    public Blob getUPhoto() {
        return UPhoto;
    }

    public void setHeaderPhoto(Blob headerPhoto) {
        HeaderPhoto = headerPhoto;
    }

    public Blob getHeaderPhoto() {
        return HeaderPhoto;
    }

    public void setBIO_Id(Long BIO_Id) {
        this.BIO_Id = BIO_Id;
    }

    public Long getBIO_Id() {
        return BIO_Id;
    }
}
