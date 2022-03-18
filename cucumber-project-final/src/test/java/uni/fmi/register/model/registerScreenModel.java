package uni.fmi.register.model;

import uni.fmi.register.RegisterService;

public class registerScreenModel {
	//----------------------------------------------------------------------------------------------------------------------------	
	private String username;
	private String password;
	private String password2;
	private String email;
	private String message;
	//----------------------------------------------------------------------------------------------------------------------------	
	public void setUsername(String username) {
      		this.username = username;
	}

	public void setFirstPassword(String password) {
  		this.password = password;
	}

	public void setSecondPassword(String password) {
  		this.password2 = password;	
	}

	public void setEmail(String email) {
  		this.email = email;
	}

	public void clickRegisterButton() {
		message = RegisterService.register(username, password, password2, email);
	}

	public String getMessage() { 
		return message;
	}
	//----------------------------------------------------------------------------------------------------------------------------	

}
