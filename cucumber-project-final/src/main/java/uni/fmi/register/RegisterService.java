package uni.fmi.register;

import java.util.ArrayList;
import java.util.List;

import uml.models.User;

public class RegisterService {
//----------------------------------------------------------------------------------------------------------------	        
	private static List<User> usersDB = new ArrayList<>();
	
//----------------------------------------------------------------------------------------------------------------	        
	public static String register(String username, String password, String password2, String email) {

		if(!password.equals(password2))
		{
			return "Въведете еднакви пароли";
		}
		
		if(username == null || "".equals(username.trim()))
		{
			return "Въведете име";
		}
		
		final User newUser = new User(username, password, email);
		usersDB.add(newUser);
		return "Успешна регистрация";	
	}
//----------------------------------------------------------------------------------------------------------------	        
}
