package uni.fmi;

import static org.junit.Assert.assertEquals;

import java.util.HashSet;
import java.util.Set;
import org.junit.Test;

import uml.models.Role;

public class TestSet {
	@Test
	public void testSetwithStrings() {
	final Set<String> testInstance = new HashSet<String>();
		
	    String value1 = "value";
		testInstance.add(value1);
		
		String value2 = "value";
		testInstance.add(value2);
		
		String value3 = "value";
		testInstance.add(value3);
		
		assertEquals(1,testInstance.size());
	}
	
	@Test
	public void testSetwithRoles() {
		final Set<Role> testInstance = new HashSet<Role>();
		
		Role value1 = new Role();
		value1.setRoleCode("Administrator");
		testInstance.add(value1);
		
		Role value2 = new Role();
		value2.setRoleCode("User");
		testInstance.add(value2);
			
		Role value3 = new Role();
		value3.setRoleCode("Administrator");
		testInstance.add(value3);
		
		
		assertEquals(2,testInstance.size());
	}
}
