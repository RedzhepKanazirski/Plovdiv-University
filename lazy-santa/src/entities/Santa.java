package entities;
import command.BlueBikeOrder;
import command.Command;
import command.OrdinaryDollOrder;
import command.RedBikeOrder;
import command.RobotDollOrder;
import factory.Toy;
import java.util.ArrayList;
import java.util.List;

public class Santa {
//--------------------------------------------------------------------------------------------------------------------------------
	private static Santa instance;
    private final List<Toy> warehouse;
//--------------------------------------------------------------------------------------------------------------------------------
    
    public static Santa getInstance() {
        if(instance == null)
        {
            instance = new Santa();
        }
        return instance;
    }
//--------------------------------------------------------------------------------------------------------------------------------
    private Santa(){
        warehouse = new ArrayList<>();
    }
//--------------------------------------------------------------------------------------------------------------------------------
    public void addToy(Toy toy) {
        if(toy != null) {
            warehouse.add(toy);
        } else {
            throw new IllegalArgumentException("error");
        }
    }

 //--------------------------------------------------------------------------------------------------------------------------------
    public void requestToy(String wantedToy, MagicBoard magicBoard) {
        Command command = null;
        switch (wantedToy.toLowerCase()) {
            case "blue bike" -> command = new BlueBikeOrder(magicBoard);
            case "red bike" -> command = new RedBikeOrder(magicBoard);
            case "ordinary doll" -> command = new OrdinaryDollOrder(magicBoard);
            case "robot doll" -> command = new RobotDollOrder(magicBoard);
        }
       
        command.execute();
    }
 //--------------------------------------------------------------------------------------------------------------------------------
}


