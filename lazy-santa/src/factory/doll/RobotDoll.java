package factory.doll;

import factory.Toy;

public class RobotDoll extends Toy {
	 @Override
	    public void prepare()  {
	        setName("robot doll");
	        System.out.println("dwarfs creating robot doll");
	    }
}
