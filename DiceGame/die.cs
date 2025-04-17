using System;

public class Die{
    //Die has 6 sides, we can roll it 
    Random dieSide = new Random();
    public int dieValue = 0;


    public int rollDie(){
        //this will roll a random number between 1 and 6 and depending on the side will assign value to dieValue with switch method
        dieValue = dieSide.Next(1,7);
        return dieValue;
    }
    

}