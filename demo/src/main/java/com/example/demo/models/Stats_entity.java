package com.example.demo.models;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import javax.validation.constraints.NotNull;

@Entity()
@Table(name = "STATS", schema = "springbootdb")
public class Stats_entity {
    @Id
    private Long poll_Id;

    @Id
    private int order;

    @NotNull
    private int result;

    @NotNull
    private String variant;

    public Stats_entity(Long poll_Id, int order, int result, String variant)
    {
        this.poll_Id = poll_Id;
        this.order = order;
        this.result = result;
        this.variant = variant;
    }

    public void setPoll_Id(Long poll_Id) {
        this.poll_Id = poll_Id;
    }

    public Long getPoll_Id() {
        return poll_Id;
    }

    public void setOrder(int order) {
        this.order = order;
    }

    public int getOrder() {
        return order;
    }

    public void setResult(int result) {
        this.result = result;
    }

    public int getResult() {
        return result;
    }

    public void setVariant(String variant) {
        this.variant = variant;
    }

    public String getVariant() {
        return variant;
    }
}
