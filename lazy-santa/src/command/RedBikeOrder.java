package command;

import entities.MagicBoard;

public class RedBikeOrder implements Command {
//--------------------------------------------------------------------------------------------------------------------------------
	public MagicBoard magicBoard;
	
//--------------------------------------------------------------------------------------------------------------------------------
    public RedBikeOrder(MagicBoard magicBoard) {
        this.magicBoard = magicBoard;
    }
//--------------------------------------------------------------------------------------------------------------------------------
	@Override
	public void execute() {
		magicBoard.requestToyFromDwarfs("red bike");		
	}
//--------------------------------------------------------------------------------------------------------------------------------
}
