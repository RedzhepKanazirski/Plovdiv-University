package main;

import entities.Dwarfs;
import entities.MagicBoard;
import entities.Santa;

public class Main {
//--------------------------------------------------------------------------------------------------------------------------------
	 public static Santa santaInstance = Santa.getInstance();
//--------------------------------------------------------------------------------------------------------------------------------
	    static class Workshop {
	        public MagicBoard magicBoard;
	        public Dwarfs dwarf;
	        //--------------------------------------------------------------------------------------------------------------------
	        public Workshop(String dwarfName) {
	            magicBoard = new MagicBoard();
	            dwarf = new Dwarfs(dwarfName);
	            magicBoard.subscribe(dwarf);
	        }
	        //--------------------------------------------------------------------------------------------------------------------
	        public MagicBoard getMagicBoard() {
	            return magicBoard;
	        }
	    }
//--------------------------------------------------------------------------------------------------------------------------------
	    public static void main(String[] args) {
	        Workshop santaWorkshop = new Workshop("TheElderDwarf");
	        santaInstance.requestToy("red bike", santaWorkshop.getMagicBoard());
	        santaInstance.requestToy("blue bike", santaWorkshop.getMagicBoard());
	        santaInstance.requestToy("ordinary doll", santaWorkshop.getMagicBoard());
	        santaInstance.requestToy("robot doll", santaWorkshop.getMagicBoard());
	    }
 //--------------------------------------------------------------------------------------------------------------------------------
}
