package uni.fmi.login.service;

import java.util.List;

import uml.models.User;

import java.util.Collections;

public class LoginService {
//----------------------------------------------------------------------------------------------------------------	        
	private static List<User> usersDb = Collections.singletonList(new User("Преслав", "a123!red"));
	
//----------------------------------------------------------------------------------------------------------------	        
	public static String login(final String username, final String password) {
		
		if(null== password || null == username)
		{
			return "Въведете име и парола!";
		}
				
		final boolean isUserExists = usersDb.stream().anyMatch(u->u.getUsername().equals(username)&& u.getPassword().equals(password));
				
		return isUserExists?"Успешно влизане!": "Грешни данни!";
	}
//----------------------------------------------------------------------------------------------------------------	        
}
