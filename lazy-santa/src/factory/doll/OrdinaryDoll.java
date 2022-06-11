package factory.doll;

import factory.Toy;

public class OrdinaryDoll extends Toy {
	 @Override
	    public void prepare()  {
	        setName("ordinary doll");
	        System.out.println("dwarfs creating ordinary doll");
	    }
}
