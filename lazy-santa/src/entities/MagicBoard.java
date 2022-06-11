package entities;

import java.util.ArrayList;
import java.util.List;
import observer.Observable;
import observer.Observer;

public class MagicBoard implements Observable {
//--------------------------------------------------------------------------------------------------------------------------------
	private String requestedToy;
    private final List<Observer> workingDwarf;
  //--------------------------------------------------------------------------------------------------------------------------------

    public MagicBoard() {
        workingDwarf = new ArrayList<>(); 
    }
 //--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void subscribe(Observer observer) {
        if(observer != null) {
            workingDwarf.add(observer);
            observer.setMagicBoard(this);
        } else {
            throw new IllegalArgumentException("cannot be null");
        }
    }
 //--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void unsubscribe(Observer observer) {
        if(observer != null) {
            workingDwarf.remove(observer);
            observer.removeMagicBoard();
        } else {
            throw new IllegalArgumentException("cannot be null");
        }
    }
//--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public void notifyObservers() {
        for(Observer dwarf : workingDwarf) {
            dwarf.update();
        }
    }
//--------------------------------------------------------------------------------------------------------------------------------
    @Override
    public String getToy() {
        return requestedToy;
    }
//--------------------------------------------------------------------------------------------------------------------------------
    public void requestToyFromDwarfs(String requestedToyFromSanta) {
        if(requestedToyFromSanta == null || requestedToyFromSanta.isBlank()) {
            throw new IllegalArgumentException("cannot be null");
        }
        requestedToy = requestedToyFromSanta;
        System.out.printf("%s appears on the magic board immediately. Santa is waiting.XOXOXO \n", requestedToyFromSanta);
        notifyObservers();
        System.out.println("\n");
    }
//--------------------------------------------------------------------------------------------------------------------------------
}
