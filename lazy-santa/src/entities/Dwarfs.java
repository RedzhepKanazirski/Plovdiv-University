package entities;

import factory.Toy;
import factory.bike.BikeExpanded;
import factory.doll.DolllExpanded;
import observer.Observable;
import observer.Observer;

public class Dwarfs implements Observer {
//--------------------------------------------------------------------------------------------------------------------------------
	private String name;
    private Observable observedMagicBoard;
//--------------------------------------------------------------------------------------------------------------------------------
    private final BikeExpanded bikeexpanded;
    private final DolllExpanded dollexpanded;
//--------------------------------------------------------------------------------------------------------------------------------
    public Dwarfs(String name) {
        setName(name);
        dollexpanded = new DolllExpanded();
        bikeexpanded = new BikeExpanded();
    }
//--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void update() {
        if(observedMagicBoard == null) 
            throw new IllegalArgumentException("The magic board is broken");

        Toy readyToy = null;
        String noted = observedMagicBoard.getToy();

        switch (noted) {
            case "robot doll" 
            -> readyToy = dollexpanded.produceToy("robot doll");
            case "ordinary doll" 
            -> readyToy = dollexpanded.produceToy("ordinary doll");
            case "red bike" 
            -> readyToy = bikeexpanded.produceToy("red bike");
            case "blue bike" 
            -> readyToy = bikeexpanded.produceToy("blue bike");
            
            default -> System.out.println("there is no such toy");
        }
    
        if(readyToy == null) {
            throw new IllegalArgumentException("cannot be null");
        }
        Santa.getInstance().addToy(readyToy);
    }
//--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void setMagicBoard(Observable magicBoard) {
        if(magicBoard == null) {
            throw new IllegalArgumentException("cannot be null");
        }
        observedMagicBoard = magicBoard;
    }
//--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void removeMagicBoard() {
        observedMagicBoard = null;
    }
//--------------------------------------------------------------------------------------------------------------------------------
    public void setName(String name) {
        if(name == null || name.isBlank()) {
            throw new IllegalArgumentException("the dwarf name cannot be null");
        }
        this.name = name;
    }
//--------------------------------------------------------------------------------------------------------------------------------
}
