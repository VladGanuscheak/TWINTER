package com.example.demo.functionality.twint;


import com.example.demo.functionality.UAccount.ProcessStatus;
import javafx.util.Pair;

import java.io.PrintWriter;



// Class Stats is used for Poll class...
public class Stats extends ProcessStatus {

    // fields
    protected int[] results;
    protected String[] variant;

    // methods

    // Constructor
    public Stats(String[] params) {
        variant = new String[params.length];
        results = new int[params.length];
        for(int i = -1; ++i < params.length; variant[i] = params[i], results[i] = 0);
    }

    // setters
    public boolean setVariantValueAt(int index, String value) // OK! ALL is FINE!
    {
        try{
            variant[index] = value;
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            System.out.printf("Warning: Index out of Range!\n");
            return FAIL;
        }
        return OK;
    }
    // Adding vote
    public boolean addVoteAt(int index) // OK! Checked, it works FINE!
    {
        try{
            results[index]++;
        }
        catch(ArrayIndexOutOfBoundsException e)
        {
            PrintWriter out = new PrintWriter(System.out);
            System.out.printf("Warning: Index out of Range!\n");
            return FAIL;
        }
        return OK;
    }
    // Delete a variant
    public boolean DeleteVariantAt(int index) // OK! Checked, it works FINE!
    {
        try
        {
            String[] FinalVariants = new String[variant.length - 1];
            int[] FinalResults = new int[variant.length - 1];
            //
            for(int i = 0, ind = 0; i < variant.length; i++)
            {
                if (index == i) continue;
                FinalResults[ind] = results[i];
                FinalVariants[ind] = variant[i];
                ind++;
            }
            // OK! Change the value of the fields
            variant = FinalVariants;
            results = FinalResults;
        }
        catch(ArrayStoreException e)
        {
            System.out.printf("Warning: Incorrect Size of the resulting array(s)!\n");
            return FAIL;
        }
        catch (ArrayIndexOutOfBoundsException e)
        {
            System.out.printf("Warning: Index out of Range!\n");
            return FAIL;
        }
        return OK;
    }
    // Add a variant (in the end of list)
    public boolean AppendNewVariant(String value) // OK! Checked, It works FINE!
    {
        for(int i = -1; ++i < variant.length; )
        {
            if (variant[i] == value) return FAIL; // No Duplicated options!!!
        }
        String[] FinalVariants = new String[variant.length + 1];
        int[] FinalResults = new int[variant.length + 1];
        //
        for(int i = -1; ++i < variant.length; FinalResults[i] = results[i], FinalVariants[i] = variant[i]);
        FinalResults[results.length] = 0;
        FinalVariants[variant.length] = value;
        // set resulting vales
        variant = FinalVariants;
        results = FinalResults;
        return OK;
    }

    // getters
    public String getVarintAt(int index) // OK! Checked, it works FINE!
    {
        String value = null;
        try{
            value = variant[index];
        }catch(ArrayIndexOutOfBoundsException e)
        {
            System.out.printf("Warning: Index out of Range!\n");
            return null;
        }
        return value;
    }

    public int getResultAt(int index) // OK
    {
        int value = -1;
        try{
            value = results[index];
        }catch(ArrayIndexOutOfBoundsException e)
        {
            System.out.printf("Warning: Index out of Range!\n");
            return -1;
        }
        return value;
    }

    public Pair getVoteCombinatoion(int index) // It's OK!
    {
        return new Pair(this.getVarintAt(index), this.getResultAt(index));
    }
}
