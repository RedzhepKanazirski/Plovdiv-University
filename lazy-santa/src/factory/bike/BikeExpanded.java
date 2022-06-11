package factory.bike;

import factory.Toy;
import factory.Toys;

public class BikeExpanded extends Toys {
	 @Override
	    public Toy createToy(String toyName) {
	        if(toyName.equalsIgnoreCase("blue bike")) {
	            return new BlueBike();
	        }

	        if(toyName.equalsIgnoreCase("red bike")) {
	            return new RedBike();
	        }

	        System.out.println("Undefined");
	        return null;
	    }
}
