package factory.bike;

import factory.Toy;

public class BlueBike extends Toy {
	 @Override
	    public void prepare()  {
	        setName("blue bike");
	        System.out.println("dwarfs creating blu bike");
	    }
}
