package command;

import entities.MagicBoard;

public class OrdinaryDollOrder implements Command {
//--------------------------------------------------------------------------------------------------------------------------------	
	public MagicBoard magicBoard;

//--------------------------------------------------------------------------------------------------------------------------------
    public OrdinaryDollOrder(MagicBoard magicBoard) {
        this.magicBoard = magicBoard;
    }	
 //--------------------------------------------------------------------------------------------------------------------------------
	@Override
	public void execute() {
		magicBoard.requestToyFromDwarfs("ordinary doll");		
	}
//--------------------------------------------------------------------------------------------------------------------------------
}
