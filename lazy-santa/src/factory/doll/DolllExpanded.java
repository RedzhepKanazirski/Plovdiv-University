package factory.doll;
import factory.Toy;
import factory.Toys;

public class DolllExpanded extends Toys {
	 @Override
	    public Toy createToy(String toyName) {
	        if(toyName.equalsIgnoreCase("robot doll")) 
	            return new RobotDoll();
	        

	        if(toyName.equalsIgnoreCase("ordinary doll")) 
	            return new OrdinaryDoll();
	        

	        System.out.println("undefined");
	        return null;
	    }
}
