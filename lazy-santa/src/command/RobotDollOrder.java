package command;

import entities.MagicBoard;

public class RobotDollOrder implements Command {
//--------------------------------------------------------------------------------------------------------------------------------
	public MagicBoard magicBoard;
	
//--------------------------------------------------------------------------------------------------------------------------------
    public RobotDollOrder(MagicBoard magicBoard) {
        this.magicBoard = magicBoard;
    }
 //--------------------------------------------------------------------------------------------------------------------------------
	@Override
	public void execute() {
		magicBoard.requestToyFromDwarfs("robot doll");		
	}
//--------------------------------------------------------------------------------------------------------------------------------
}
