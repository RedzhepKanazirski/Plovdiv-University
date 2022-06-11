package factory.bike;

import factory.Toy;

public class RedBike extends Toy {
	 @Override
	    public void prepare()  {
	        setName("red bike");
	        System.out.println("dwarfs creating red bike");
	    }
}
